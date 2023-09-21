// See https://aka.ms/new-console-template for more information

using PokemonMMOBattleServer.BattleLobbyService;
using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using PokemonMMOBattleServer.ServerService;

namespace PokemonMMOBattleServerApp
{
    class ServerProgram
    {
        public ServerProgram() {}
        static void Main(string[] args)
        {
            ServerClass? Server = new();
            BattleLobbyClass BattleLobby = new();
            Thread serverThread = new Thread(new ParameterizedThreadStart(ServerThread));
            serverThread.Start(Server);
            EventHandler<ClientJoinEventArgs> newClientHandler = BattleLobby.NewClientHandler;
            Server.NewClientConnection += newClientHandler;

            Pkmn_DataObject test = new();
        }


        public static void ServerThread(object ServerReference) // This is the initial function on the Server Thread.
                                                                // It creates the server process
        {
            ServerClass Server = (ServerClass)ServerReference;
            Server.StartServer();
            return;
        }

    }
}


