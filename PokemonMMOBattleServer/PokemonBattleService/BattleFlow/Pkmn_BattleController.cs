using PokemonMMOBattleServer.BattleLobbyService;
using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using PokemonMMOBattleServer.PokemonBattleService.BattleData.Field;
using PokemonMMOBattleServer.PokemonBattleService.BattleFlow.BattleEvents;
using PokemonMMOBattleServer.PokemonBattleService.BattleInterface.Controllers;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow
{
    public struct TeamSlot
    {
        public PlayerControllerBase controller { get; set;}
        public Pkmn_TrainerDataObject trainer { get; set;}

    }
    public class BattleController
    {
        public Pkmn_BattleRoundEvent? roundQueue;

        public Pkmn_ParticipantData battleParticipants = new();
        public Pkmn_BattleDataClass battleData = new();

        public List<TeamSlot> teamSlots = new();

        public Pkmn_Field? fieldController;

       

        public BattleController()
        {
            fieldController = new Pkmn_Field(this);
            roundQueue = new Pkmn_BattleRoundEvent(this);
        }

        public void SetupBattleController(BattleStartEventArgs e)
        {
            battleParticipants.AITrainerControllers.Add(new Pkmn_AIController()); // Temp! For testing only
            battleParticipants.AITrainerControllers.Add(new Pkmn_AIController()); // Temp! For testing only
            return;
        }

        public void SetupTrainerDataObjects()
        {
            foreach (PlayerControllerBase player in battleParticipants.GetAllPlayerControllers())
            {
                TeamSlot slot = new TeamSlot();
                slot.controller = player;
                slot.trainer = new Pkmn_TrainerDataObject();
                slot.trainer.SetupPokemonParty(player.trainerType, "api path or summ idk"); //Obviously temporary, kek
                teamSlots.Add(slot);
            }
        }


        public void StartBattle()
        {
            Console.WriteLine("Starting Battle");
            SetupTrainerDataObjects();
            fieldController.SetupField();
            roundQueue.SetupRoundEvent();
            return;
        }
    }
}
