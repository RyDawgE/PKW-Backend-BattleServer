using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using PokemonMMOBattleServer.PokemonBattleService.BattleData.Field;
using PokemonMMOBattleServer.PokemonBattleService.BattleFlow.BattleEvents;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow
{
    public class BattleController
    {
        public Pkmn_BattleRoundEvent? roundQueue;

        public Pkmn_ParticipantData battleParticipants = new();
        public Pkmn_BattleDataClass battleData = new();

        public Pkmn_Field? fieldController;

        public BattleController()
        {
            fieldController = new Pkmn_Field(this);
            roundQueue = new Pkmn_BattleRoundEvent(this);
        }

        public void StartBattle()
        {
            fieldController.SetupField();
            roundQueue.SetupRoundEvent();

        }
    }
}
