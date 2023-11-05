import socket
import tkinter as tk
from tkinter import messagebox

def check_port(ip, port, protocol):
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM if protocol == 'TCP' else socket.SOCK_DGRAM)
    try:
        sock.connect((ip, int(port)))
        return True
    except:
        return False
    finally:
        sock.close()

def check():
    ip = ip_entry.get()
    port = port_entry.get()
    tcp_result = check_port(ip, port, 'TCP')
    udp_result = check_port(ip, port, 'UDP')
    messagebox.showinfo("Results", f"TCP: {'Open' if tcp_result else 'Closed'}\nUDP: {'Open' if udp_result else 'Closed'}")

root = tk.Tk()
root.title("Port Checker")

ip_label = tk.Label(root, text="IP Address:")
ip_label.pack()
ip_entry = tk.Entry(root)
ip_entry.pack()

port_label = tk.Label(root, text="Port:")
port_label.pack()
port_entry = tk.Entry(root)
port_entry.pack()

check_button = tk.Button(root, text="Check", command=check)
check_button.pack()

root.mainloop()
