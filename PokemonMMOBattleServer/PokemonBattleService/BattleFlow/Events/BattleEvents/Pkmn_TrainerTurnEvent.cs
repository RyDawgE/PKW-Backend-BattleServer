﻿using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow.Events.BattleEvents
{
    public class Pkmn_TrainerTurnEvent: BattleEventBase
    {
        public Pkmn_TrainerTurnEvent(BattleController battleControllerRef) : base(battleControllerRef)
        {

        }
    }
}