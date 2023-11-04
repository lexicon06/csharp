import tkinter as tk
# from tkinter import messagebox   for future use - error handling
import socket
import struct
import zlib
import base64


def e67(data, b):
    buffer = bytearray(len(data))

    for i in range(len(data)):
        buffer[i] = (data[i] ^ (b >> 8)) & 255
        b = ((buffer[i] + b) * 23219 + 36126) & 65535

    return bytes(buffer)


def encode_hashlink(room):
    list = bytearray()
    list.extend(bytearray(20))
    list.extend(bytearray("CHATCHANNEL", 'utf-8'))
    list.append(0)
    list.extend(socket.inet_aton(room['IP']))
    list.extend(struct.pack('!H', room['Port']))
    list.extend(socket.inet_aton(room['IP']))
    list.extend(bytearray(room['Name'], 'utf-8'))
    list.append(0)
    list.append(0)

    buf = bytes(list)
    buf = zlib.compress(buf)
    buf = e67(buf, 28435)

    return "arlnk://"+base64.b64encode(buf).decode('utf-8')


def generate_hashlink():
    room = {
        'IP': ip_entry.get(),
        'Port': int(port_entry.get()),
        'Name': name_entry.get()
    }
    try:
        hashlink = encode_hashlink(room)
        output_text.delete(1.0, tk.END)
        output_text.insert(tk.END, hashlink)
    except Exception as e:
        output_text.delete(1.0, tk.END)
        output_text.insert(tk.END, str(e))

root = tk.Tk()

root.title("Ares Hashlink Encrypt")

tk.Label(root, text="IP", height=2).grid(row=0)
tk.Label(root, text="Port", height=2).grid(row=1)
tk.Label(root, text="Name", height=2).grid(row=2)

ip_entry = tk.Entry(root)
port_entry = tk.Entry(root)
name_entry = tk.Entry(root)

ip_entry.grid(row=0, column=1)
port_entry.grid(row=1, column=1)
name_entry.grid(row=2, column=1)

tk.Button(root, text='Generate Hashlink', command=generate_hashlink, height=2).grid(row=3, column=1, sticky=tk.W, pady=14)

output_text = tk.Text(root, height=5, width=50)
output_text.grid(row=4, column=0, columnspan=2)

root.mainloop()