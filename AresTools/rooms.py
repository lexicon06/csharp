import enum
import socket
import struct
from typing import List

class RoomLanguage(enum.Enum):
    Arabic = 11
    Chinese = 12
    Czech = 14
    Danish = 15
    Dutch = 16
    English = 10
    Finnish = 27
    French = 28
    German = 29
    Italian = 30
    Japanese = 17
    Kirghiz = 19
    Polish = 20
    Portuguese = 21
    Russian = 31
    Slovak = 22
    Spanish = 23
    Swedish = 25
    Turkish = 26
    Any = 255


class ChannelListItem:
    def __init__(self, ip, port, lang, name, topic, users):
        self.ip = ip
        self.port = port
        self.lang = lang
        self.name = name
        self.topic = topic
        self.users = users

def read_string(data, start_index):
    length = struct.unpack_from('H', data, start_index)[0]
    start_index += 2
    end_index = start_index + length
    return data[start_index:end_index].decode('utf-8'), end_index

def main():
    filePath = "servers.dat"
    full_channel_list: List[ChannelListItem] = []

    with open(filePath, 'rb') as f:
        data = f.read()

    index = 0
    while index < len(data):
        ip = socket.inet_ntoa(data[index:index+4])
        index += 4

        port = struct.unpack_from('H', data, index)[0]
        index += 2

        lang = RoomLanguage(struct.unpack_from('B', data, index)[0])
        index += 1

        name, index = read_string(data, index)
        topic, index = read_string(data, index)

        users = struct.unpack_from('H', data, index)[0]
        index += 2

        item = ChannelListItem(ip, port, lang, name, topic, users)
        full_channel_list.append(item)

    for item in full_channel_list:
        print(f"IP: {item.ip}")
        print(f"Port: {item.port}")
        print(f"Language: {item.lang}")
        print(f"Name: {item.name}")
        print(f"Topic: {item.topic}")
        print(f"Users: {item.users}")
        print()

if __name__ == "__main__":
    main()
