using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using cb0t;


public enum RoomLanguage : byte
{
        Arabic = 11,
        Chinese = 12,
        Czech = 14,
        Danish = 15,
        Dutch = 16,
        English = 10,
        Finnish = 27,
        French = 28,
        German = 29,
        Italian = 30,
        Japanese = 17,
        Kirghiz = 19,
        Polish = 20,
        Portuguese = 21,
        Russian = 31,
        Slovak = 22,
        Spanish = 23,
        Swedish = 25,
        Turkish = 26,
        Any = 255
}

public class ChannelListItem
{
    public IPAddress IP { get; set; }
    public ushort Port { get; set; }
    public RoomLanguage Lang { get; set; }
    public string Name { get; set; }
    public string Topic { get; set; }
    public ushort Users { get; set; }
}



class Program
{

    
    static void Main()
    {
        string filePath = "servers2.dat";
        List<ChannelListItem> full_channel_list = new List<ChannelListItem>();

        byte[] data = File.ReadAllBytes(filePath);
        UdpPacketReader reader = new UdpPacketReader(data);

        while (reader.Remaining() > 0)
        {
            ChannelListItem item = new ChannelListItem();
            item.IP = reader.ReadIP();
            item.Port = reader.ReadUInt16();
            item.Lang = (RoomLanguage)reader.ReadByte();
            item.Name = reader.ReadString();
            item.Topic = reader.ReadString();
            item.Users = reader.ReadUInt16();

            full_channel_list.Add(item);
        }


        foreach (ChannelListItem item in full_channel_list)
{
    Console.WriteLine("IP: " + item.IP);
    Console.WriteLine("Port: " + item.Port);
    Console.WriteLine("Language: " + item.Lang);
    Console.WriteLine("Name: " + item.Name);
    Console.WriteLine("Topic: " + item.Topic);
    Console.WriteLine("Users: " + item.Users);
    Console.WriteLine();
}


        // Now you have all the data from the .dat file in your full_channel_list
    }
}
