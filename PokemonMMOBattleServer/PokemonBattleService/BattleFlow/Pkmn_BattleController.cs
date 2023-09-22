using PokemonMMOBattleServer.PokemonBattleService.BattleData;
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
        Pkmn_BattleRoundEvent? RoundQueue;
        public Pkmn_ParticipantData battleParticipants = new();
        public BattleController()
        {
            RoundQueue = new Pkmn_BattleRoundEvent(this);
        }

        public void StartBattle()
        {
            RoundQueue.SetupRoundEvent();

        }
    }
}
