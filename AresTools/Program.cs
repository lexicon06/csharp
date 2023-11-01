using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using cb0t;


public enum RoomLanguage
{
    English,
    Spanish,
    // Add other languages as needed
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
