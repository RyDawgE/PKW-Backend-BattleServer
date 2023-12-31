﻿// See https://aka.ms/new-console-template for more information

using PokemonMMOBattleServer.BattleLobbyService;
using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using PokemonMMOBattleServer.PokemonBattleService.BattleFlow;
using PokemonMMOBattleServer.ServerService;

namespace PokemonMMOBattleServerApp
{
    class BattleServerProgram
    {
        public BattleServerProgram() {}
        static void Main(string[] args)
        {
            ServerClass? Server = new();
            BattleLobbyClass BattleLobby = new();
            Thread serverThread = new Thread(new ParameterizedThreadStart(ServerThread));
            serverThread.Start(Server);
            EventHandler<ClientJoinEventArgs> newClientHandler = BattleLobby.NewClientHandler;
            Server.NewClientConnection += newClientHandler;
            BattleLobby.StartBattleEvent += StartBattleHandler;
         }


        public static void ServerThread(object ServerReference) // This is the initial function on the Server Thread.
                                                                // It creates the server process
        {
            ServerClass Server = (ServerClass)ServerReference;
            Server.StartServer();
            return;
        }

        public static void StartBattleHandler(Object? sender, BattleStartEventArgs e)
        {
            BattleController battleController = new BattleController();
            battleController.SetupBattleController(e);
            battleController.StartBattle();
            return;
        }
    }
}


