import socket
import select
import errno

def connect(ep):
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.setblocking(0)  # set to non-blocking mode

    try:
        sock.connect(ep)
    except BlockingIOError:
        # This exception is expected, it indicates that the connection is in progress.
        pass
    except socket.error as e:
        if e.errno != errno.EINPROGRESS and e.errno != errno.EWOULDBLOCK:
            print(f"Error occurred: {str(e)}")
            # Handle error here or re-raise and handle elsewhere
            raise
        else:
            pass

    return sock

# Usage:
try:
    sock = connect(('31.222.202.178', 36020))  # replace with your IP and port
except Exception as e:
    print(f"Failed to create socket: {str(e)}")
    # Handle error here

# Now you can use the select module to check when the socket is ready to send/receive data.
try:
    ready_to_read, ready_to_write, in_error = select.select([], [sock], [], 15)
    if ready_to_write:
        print("Socket is connected and ready to send data.")
    else:
        print("Socket is not ready after 5 seconds.")
except Exception as e:
    print(f"Error occurred during select: {str(e)}")
    # Handle error here
