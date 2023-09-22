using PokemonMMOBattleServer.PokemonBattleService.BattleFlow.Events.BattleEvents;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow.BattleEvents
{
    internal class Pkmn_BattleRoundEvent: RoundEventBase
    {
        BattleController? battleControllerReference;
        public Pkmn_BattleRoundEvent(BattleController battleControllerRef) :
            base()
        {
            battleControllerReference = battleControllerRef;
        }

        public BattleController GetBattleController()
        {
            return battleControllerReference;
        }

        public override void SetupRoundEvent()
        {
            base.SetupRoundEvent();
            battleEvents.Add(new Pkmn_BattlePreroundEvent());
            
        }

        
    }
}
