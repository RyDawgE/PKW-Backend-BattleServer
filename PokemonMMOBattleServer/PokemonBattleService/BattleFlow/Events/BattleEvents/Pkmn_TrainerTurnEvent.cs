using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow.Events.BattleEvents
{
    public class Pkmn_TrainerTurnEvent: BattleEventBase
    {
        private readonly PlayerControllerBase? playerControllerReference;
        public Pkmn_TrainerTurnEvent(BattleController battleControllerRef, PlayerControllerBase playerControllerRef) : base(battleControllerRef)
        {
            playerControllerReference = playerControllerRef;
        }

        public override void BattleEventLogic()
        {
            base.BattleEventLogic();
            playerControllerReference.GetSelection();
        }
    }
}
