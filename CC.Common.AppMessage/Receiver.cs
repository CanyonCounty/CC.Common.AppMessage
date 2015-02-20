using System;
using System.Net;
using System.Net.Sockets;

namespace CC.Common.AppMessage
{
  public class Receiver
  {
    public delegate void ReceivedMessage(object sender, string message);

    private ReceivedMessage _receivedMessage;
    private int _UDPPort;

    public Receiver(ReceivedMessage receivedMessage, int UDPPort)
    {
      _receivedMessage = receivedMessage;
      _UDPPort = UDPPort;

      ListenUDP();
    }
    public Receiver(ReceivedMessage receivedMessage): this(receivedMessage, ServiceInfo.UDPPort) {}

    private void ListenUDP()
    {
      var broadcastAddress = new IPEndPoint(IPAddress.Any, _UDPPort);
      var udpClient = new UdpClient();
      udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
      udpClient.ExclusiveAddressUse = false;
      udpClient.Client.Bind(broadcastAddress);

      UdpState s = new UdpState() { e = broadcastAddress, u = udpClient };

      udpClient.BeginReceive(new AsyncCallback(this.ReceiveCallback), s);
    }

    private void ReceiveCallback(IAsyncResult ar)
    {
      UdpState state = (UdpState)(ar.AsyncState);
      UdpClient u = state.u;
      IPEndPoint e = state.e;

      Byte[] receiveBytes = u.EndReceive(ar, ref e);
      var data = Helpers.DeserializeObject<string>(receiveBytes);

      if (_receivedMessage != null) _receivedMessage(this, data);
      
      u.BeginReceive(new AsyncCallback(this.ReceiveCallback), state);
    }
    
    class UdpState
    {
      public IPEndPoint e;
      public UdpClient u;
    }
  }
}
