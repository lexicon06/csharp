import struct
import socket

def read_servers(file_path):
    with open(file_path, 'rb') as f:
        data = f.read()

    servers = []
    for i in range(0, len(data), 6):
        ip = socket.inet_ntoa(data[i:i+4])
        port = struct.unpack('!H', data[i+4:i+6])[0]
        
        servers.append((ip, port))

    return servers

servers = read_servers('servers.dat')
for server in servers:
    print(f'IP: {server[0]}, Port: {server[1]}')
