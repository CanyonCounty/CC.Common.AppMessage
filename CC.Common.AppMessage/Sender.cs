using System.Net;
using System.Net.Sockets;

namespace CC.Common.AppMessage
{
  public static class Sender
  {
    /// <summary>
    /// Send our our server message
    /// </summary>
    public static void SendMessage(string message)
    {
      SendMessage(message, ServiceInfo.UDPPort);
    }

    public static void SendMessage(string message, int UDPPort)
    {
      // Create a socket udp ipv4 socket
      using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
      {
        // Create our endpoint using the IP broadcast address and our port
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, UDPPort);

        // Serialize our ping "payload"
        byte[] data = Helpers.SerializeObject<string>(message);

        // Tell our socket to reuse the address so we can send and
        // receive on the same port.
        sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

        // Tell the socket we want to broadcast - if we don't do this it
        // won't let us send.
        sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);

        // Send the ping and close the socket.
        sock.SendTo(data, endPoint);
        sock.Close();
      }
    }
  }
}
