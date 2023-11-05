const net = require('node:net');
const util = require('node:util');

// Convert net.Socket.connect to return a promise
const connectAsync = util.promisify(net.Socket.prototype.connect);

async function connect(ep) {
    const sock = new net.Socket();

    try {
        await connectAsync.call(sock, ep);
    } catch (e) {
        console.error(`Error occurred: ${e}`);
        // Handle error here or re-throw and handle elsewhere
        throw e;
    }

    return sock;
}

// Usage:
connect({port: 36020, host: '31.222.202.178'})  // replace with your IP and port
    .then(sock => {
        console.log("Socket is connected and ready to send data.");
        // Now the socket is connected and you can write/read data.
    })
    .catch(e => {
        console.error(`Failed to create socket: ${e}`);
        // Handle error here
    });
