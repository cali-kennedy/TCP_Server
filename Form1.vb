'Server Side
'This code is for a simple TCP server application in Visual Basic .NET. It
'creates a TCP server that listens on port 1000 for incoming connections.
'Once a connection is established, it receives data from the client and displays
'it in TextBox2. The user can also send data to the client by typing in
'TextBox1 and clicking Button2.
Imports System.Net
Imports System.Net.Sockets

Public Class Form1

    'Creates a Socket
    Dim TCPServer As Socket

    'Listens for Connections from tcp servers
    Dim TCPListenerz As TcpListener


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' Converts the text from TextBox1 to ASCII bytes
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(TextBox1.Text)
        ' Sends the ASCII bytes through the TCPServer socket
        TCPServer.Send(sendbytes)

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        'Creates a TCP Listener that listens for any IP address with socket 1000
        TCPListenerz = New TcpListener(IPAddress.Any, 1000)
        ' Start Listener
        TCPListenerz.Start()
        'When a client sends a request, TCP accepts the client
        TCPServer = TCPListenerz.AcceptSocket()
        ' By default, when TCP is waiting to receive is stalls the programm
        ' Turn that off
        TCPServer.Blocking = False
        ' Start timer to continuosly check for incoming data
        Timer1.Enabled = True

    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Use a try block to avoid receiving errors when not receiving anything
        Try
            ' Create an array that's the size of ReceiveBufferSize
            Dim rcvbytes(TCPServer.ReceiveBufferSize) As Byte
            ' Receive data from TCPServer and store it in rcvbytes array
            TCPServer.Receive(rcvbytes)
            ' Convert received bytes to ASCII string and display in TextBox2
            TextBox2.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
        Catch ex As Exception
        End Try
    End Sub
End Class
