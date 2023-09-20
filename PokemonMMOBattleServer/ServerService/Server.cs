using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;



namespace PokemonMMOBattleServer.ServerService
{
    public class ClientJoinEventArgs : EventArgs
    {
        public Socket? Client { get; set; }
        public DateTime TimeJoined { get; set; }
    }

    public class ServerClass
    {
        public IPHostEntry? ipHostInfo;
        public IPAddress? ipAddress;

        public IPEndPoint? ipEndPoint;

        public Socket? listener;

        public List<Socket> ActiveClients = new();

        public event EventHandler<ClientJoinEventArgs> NewClientConnection;


        public ServerClass()
        {
            this.ipHostInfo = ipHostInfo;
            this.ipAddress = ipAddress;
        }


        public void StartServer(){

            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);

            Socket server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener = server;
            listener.Bind(ipEndPoint);
            listener.Listen(100);

            Console.WriteLine($"Server Started... Listening for messages.");

            HandleIncomingData();
            return;
        }
        public void HandleIncomingData()
        {
            while (true)
            {

                Socket client = listener.Accept();  //This is a blocking method. The following code will not run unless a client is accepted
                int message = client.Receive(new byte[1024]);
                ActiveClients.Add(client);
                Console.WriteLine("New Client Recieved");

                ClientJoinEventArgs clientArgs = new();  // This chunk handles Client Event args
                clientArgs.Client = client;              // Think of this like setting up an Event Dispatcher in Unreal
                clientArgs.TimeJoined = DateTime.Now;    // The argumetn is a class, so we make a new one and fill it with values.

                NewClientConnection?.Invoke(this, clientArgs);
            }

            return;
        }

        public void EmitMessage(String Message, List<Socket> Exclude)
        {
            foreach (Socket client in this.ActiveClients)
            {
                if (!Exclude.Contains(client))
                {
                    //Send message to client
                    return;
                }
            }
        }
    }
}
