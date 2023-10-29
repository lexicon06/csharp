import base64
import socket
import struct
import zlib

def decode_hashlink(hashlink):
    # Remove the "arlnk://" prefix and decode the base64 string
    base64_str = hashlink[8:]
    data = base64.b64decode(base64_str)

    # Decrypt the data using the d67 method
    data = d67(data, 28435)

    # Decompress the data using zlib.decompress method
    data = zlib.decompress(data)

    # Parse the decrypted data into a DecryptedHashlink object
    room = {}
    room['IP'] = socket.inet_ntoa(data[32:36])
    room['Port'] = struct.unpack('!H', data[36:38])[0]
    room['Name'] = data[42:].decode('utf-8').split('\x00', 1)[0]

    return room

def d67(data, b):
    buffer = bytearray(data)

    for i in range(len(data)):
        buffer[i] = (data[i] ^ (b >> 8 & 255)) & 0xFF
        b = ((b + data[i]) * 23219 + 36126) & 0xFFFF

    return bytes(buffer)


def main():
    hashlink = input("Please enter a hashlink! Example: arlnk://F5.......\n")
    room = decode_hashlink(hashlink)
    print(f"Name: {room['Name']}, IP: {room['IP']}, Port: {room['Port']}")



if __name__ == "__main__":
    main()
