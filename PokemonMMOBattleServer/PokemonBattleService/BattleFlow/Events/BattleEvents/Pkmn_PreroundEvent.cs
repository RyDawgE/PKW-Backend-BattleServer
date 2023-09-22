using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow.Events.BattleEvents
{
    public class Pkmn_BattlePreroundEvent : BattleEventBase
    {
        public Pkmn_BattlePreroundEvent(BattleController battleControllerRef) : base(battleControllerRef)
        {

        }
    }
}
