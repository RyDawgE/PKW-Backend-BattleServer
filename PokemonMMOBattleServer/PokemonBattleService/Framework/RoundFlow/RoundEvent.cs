using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;

namespace PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow
{
    public class RoundEventBase
    {
        public List<BattleEventBase> battleEvents = new();
        public RoundEventBase()
        {

        }

        public virtual void SetupRoundEvent()
        {
            return;
        }

        public virtual void EvaluateBattleEvents()
        {
            foreach (BattleEventBase b_event in battleEvents) 
            {
                b_event.BattleEventLogic();
            }
        }

    }
}
