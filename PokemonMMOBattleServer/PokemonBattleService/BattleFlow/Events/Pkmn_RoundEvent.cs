using PokemonMMOBattleServer.PokemonBattleService.BattleFlow.Events.BattleEvents;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow;
using PokemonMMOBattleServer.PokemonBattleService.Framework.RoundFlow.BattleEvent;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleFlow.BattleEvents
{

    public class Pkmn_RoundData
    {
        public Dictionary<TeamSlot, TrainerSelectionData> selectionData = new();
    }
    public class Pkmn_BattleRoundEvent: RoundEventBase
    {
        private readonly BattleController? battleControllerReference;

        public Pkmn_RoundData roundData = new();
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
            roundData = new Pkmn_RoundData();

            // This is the main flow. It should look like this:
            // Preround - Check Win Conditions
            // Trainer Turn A - Choose Move
            // Trainer Turn B - Choose Move
            // Midround - Generate Turn Order
            // Battle Turn 1 - Execute Move
            // Battle Turn 2 - Execute Move
            // Postround - Timed Events End

            battleEvents.Add(new Pkmn_BattlePreroundEvent(GetBattleController()));
            foreach (PlayerControllerBase trainer in GetBattleController().battleParticipants.GetAllPlayerControllers())
            {
                battleEvents.Add(new Pkmn_TrainerTurnEvent(GetBattleController(), trainer)); 
            }
        }        
    }
}
