import tkinter as tk
import socket
import uuid
import struct
import socket
import requests

def get_ip_address():
    hostname = socket.gethostname()
    local_ip = socket.gethostbyname(hostname)
    
    public_ip = requests.get('https://api.ipify.org').text
    
    return local_ip, public_ip

local_ip, public_ip = get_ip_address()

print(f"Local IP: {local_ip}")
print(f"Public IP: {public_ip}")



class Application(tk.Frame):
    def __init__(self, master=None):
        super().__init__(master)
        self.master = master
        self.pack()
        self.create_widgets()

    def create_widgets(self):
        self.connect_button = tk.Button(self)
        self.connect_button["text"] = "Connect"
        self.connect_button["command"] = self.connect_bot
        self.connect_button.pack(side="top")

        self.quit = tk.Button(self, text="QUIT", fg="red",
                              command=self.master.destroy)
        self.quit.pack(side="bottom")

    def connect_bot(self):
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        server_address = ('13.59.93.76', 12756)
        print('connecting to {} port {}'.format(*server_address))
        self.sock.connect(server_address)
        self.sock.sendall(self.msg_chat_client_login())
        print('Login Accepted')

    def msg_chat_client_login(self):
        buffer = bytearray()
        buffer.extend(struct.pack('!h', 2))  # id 2
        buffer.extend(uuid.uuid4().bytes)  # guid 16 bytes
        buffer.extend(struct.pack('!h', 666))  # Number of files
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(struct.pack('!h', 5555))  # DC port
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(b'Nick')  # Nick x bytes
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(b'B0t')  # client version xbyte
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer.extend(socket.inet_aton('127.0.0.1'))  # Local IpAdress 4 bytes
        buffer.extend(socket.inet_aton(f'{public_ip}'))  # External IpAdress Null. 4bytes
        buffer.extend(struct.pack('!h', 0))  # client features 1 byte
        buffer.extend(struct.pack('!h', 0))  # current upload 1byte
        buffer.extend(struct.pack('!h', 0))  # maximum uploads allowed 1byte
        buffer.extend(struct.pack('!h', 0))  # current queued users
        buffer.extend(struct.pack('!h', 20))  # User years 1byte
        buffer.extend(struct.pack('!h', 1))  # User sex 1byte
        buffer.extend(struct.pack('!h', 69))  # User country 1byte
        buffer.extend(b'Ares')  # User location xbyte
        buffer.extend(struct.pack('!h', 0))  # Null 1byte
        buffer[0:0] = struct.pack('!h', len(buffer) - 1)
        return buffer

root = tk.Tk()
app = Application(master=root)
app.mainloop()
