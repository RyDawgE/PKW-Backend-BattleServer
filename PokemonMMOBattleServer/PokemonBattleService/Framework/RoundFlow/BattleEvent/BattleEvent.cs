using PokemonMMOBattleServer.PokemonBattleService.BattleFlow;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent
{
    public class BattleEventBase
    {
        private readonly BattleController? battleControllerReference;
        public BattleEventBase(BattleController battleControllerRef) 
        {
            battleControllerReference = battleControllerRef;
        }

        public virtual void BeginBattleEvent()
        {
            return;
        }
        public virtual void BattleEventLogic()
        {
            return;
        }
        public virtual void EndBattleEvent()
        {
            return;
        }
    }
}
