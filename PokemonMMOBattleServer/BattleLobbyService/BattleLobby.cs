// See https://aka.ms/new-console-template for more information
using PokemonMMOBattleServer.ServerService;
using System.Net.Sockets;

namespace PokemonMMOBattleServer.BattleLobbyService
{
    public class BattleStartEventArgs : EventArgs
    {
        public List<Socket>? Clients { get; set; }
        public DateTime TimeJoined { get; set; }
    }

    public class BattleLobbyClass
    {
        public List<Socket> ActiveClients = new();

        public static int PlayersToStart = 2;

        public event EventHandler<BattleStartEventArgs> StartBattleEvent;



        public BattleLobbyClass()
        {
        }

        public void NewClientHandler(object server, ClientJoinEventArgs e)
        {
            Console.WriteLine("Client has Joined.");  // Should emit this to all existing clients as well. We can accept new clients, but should be delegated
                                                      // to spectators. This is not implemented yet.
            ActiveClients.Add(e.Client);
            if (ActiveClients.Count == PlayersToStart ) //If we want to do another client confirmation, this is where it will go.
            {
                StartBattle();
            }
            return;
        }

        public void StartBattle()
        {
            BattleStartEventArgs battleArgs = new();         
            battleArgs.Clients = ActiveClients;             
            battleArgs.TimeJoined = DateTime.Now;
            StartBattleEvent.Invoke(this, battleArgs);

            return;
        }


    }
}