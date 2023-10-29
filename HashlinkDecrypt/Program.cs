using System;
using System.Text;
using System.Net;
using System.IO;
using cb0t;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a hashlink! Example: arlnk://F5.......");
        string hashlink = Console.ReadLine();
        DecryptedHashlink room = DecodeHashlink(hashlink);
        Console.WriteLine($"Name: {room.Name}, IP: {room.IP}, Port: {room.Port}");
    }

    private static DecryptedHashlink DecodeHashlink(string hashlink)
    {
        // Remove the "arlnk://" prefix and decode the base64 string
        string base64 = hashlink.Substring(8);
        byte[] data = Convert.FromBase64String(base64);

        // Decrypt the data using the d67 method
        data = d67(data, 28435);

        // Decompress the data using Zip.Decompress method from Zip.cs cb0t namespace
        data = Zip.Decompress(data);

        // Parse the decrypted data into a DecryptedHashlink object
        HashlinkReader reader = new HashlinkReader(data);
        reader.SkipBytes(32);
        DecryptedHashlink room = new DecryptedHashlink();
        room.IP = reader;
        room.Port = reader;
        reader.SkipBytes(4);
        room.Name = reader;

        return room;
    }

    private static byte[] d67(byte[] data, int b)
    {
        byte[] buffer = new byte[data.Length];
        Array.Copy(data, buffer, data.Length);

        for (int i = 0; i < data.Length; i++)
        {
            buffer[i] = (byte)(data[i] ^ b >> 8 & 255);
            b = (b + data[i]) * 23219 + 36126 & 65535;
        }

        return buffer;
    }
}

class DecryptedHashlink
{
    public String Name { get; set; }
    public IPAddress IP { get; set; }
    public ushort Port { get; set; }
}

class HashlinkReader
{
    private int Position = 0;
    private List<byte> Data = new List<byte>();

    public HashlinkReader(byte[] bytes)
    {
        this.Data.Clear();
        this.Position = 0;
        this.Data.AddRange(bytes);
    }

    public void SkipBytes(int count)
    {
        this.Position += count;
    }

    public static implicit operator ushort(HashlinkReader p)
    {
        ushort tmp = BitConverter.ToUInt16(p.Data.ToArray(), p.Position);
        p.Position += 2;
        return tmp;
    }

    public static implicit operator IPAddress(HashlinkReader p)
    {
        byte[] tmp = new byte[4];
        Array.Copy(p.Data.ToArray(), p.Position, tmp, 0, tmp.Length);
        p.Position += 4;
        return new IPAddress(tmp);
    }

    public static implicit operator String(HashlinkReader p)
    {
        String str = String.Empty;
        int split = p.Data.IndexOf(0, p.Position);
        byte[] tmp = new byte[split > -1 ? (split - p.Position) : (p.Data.Count - p.Position)];
        Array.Copy(p.Data.ToArray(), p.Position, tmp, 0, tmp.Length);
        p.Position = split > -1 ? (split + 1) : p.Data.Count;
        
	return Encoding.UTF8.GetString(tmp).Replace("\r\n", "\n");
    }
}
