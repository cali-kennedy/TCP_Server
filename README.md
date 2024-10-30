# TCP Server Application (Visual Basic .NET)

This project is a simple TCP server application created in Visual Basic .NET. The server listens for incoming TCP connections on port `1000`. Once connected, it can receive data from a client and display it in a designated text box. Additionally, the server allows users to send data back to the client.

## Features
- **Listen for Incoming Connections**: The server listens on port `1000` for incoming TCP connections.
- **Data Reception**: Incoming data from the client is displayed in `TextBox2`.
- **Data Sending**: Users can enter text in `TextBox1` and send it to the client by clicking `Button2`.

## Project Files
- **TCP_Server.sln**: The Visual Studio solution file for the TCP Server application.
- **Form1.vb**: The main form code for the server, containing logic for establishing connections, receiving, and sending data.

## Requirements
- **.NET Framework** or **.NET Core**
- **Visual Studio** (or any compatible IDE that supports VB.NET)

## How to Use
1. **Set Up the Server**:
   - Open `TCP_Server.sln` in Visual Studio.
   - Run the application, which will open a form with text boxes and buttons.

2. **Start Listening**:
   - Click **Button1** to start the server. The server begins listening for client connections on port `1000`.

3. **Receive Data**:
   - Once a client connects and sends data, it will be displayed in `TextBox2`.
   - A client can be created by running TCP_Client repository

4. **Send Data**:
   - Type a message in `TextBox1` and click **Button2** to send the data back to the client.

## Configuration
- **Port**: The server listens on port `1000`. To change the port, modify the port number in the line:
  ```vb
  TCPListenerz = New TcpListener(IPAddress.Any, 1000)
