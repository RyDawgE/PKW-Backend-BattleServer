using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow.Events.BattleEvents
{
    public class Pkmn_BattleMidroundEvent: BattleEventBase
    {
        public Pkmn_BattleMidroundEvent(BattleController battleControllerRef) : base(battleControllerRef)
        {

        }

        public void SetupBattleTurnOrder()
        {
            // ToDo
        }
    }
}
