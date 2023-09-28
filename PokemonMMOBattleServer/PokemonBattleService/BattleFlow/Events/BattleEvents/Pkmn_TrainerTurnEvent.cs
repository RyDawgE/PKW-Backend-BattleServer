using PokemonMMOBattleServer.PokemonBattleService.BattleFlow.BattleEvents;
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
        public readonly PlayerControllerBase? playerControllerReference;
        public Pkmn_TrainerTurnEvent(BattleController battleControllerRef, PlayerControllerBase playerControllerRef) : base(battleControllerRef)
        {
            playerControllerReference = playerControllerRef;
        }

        public override void BattleEventLogic()
        {
            base.BattleEventLogic();
            int slot = battleControllerReference.teamSlots[playerControllerReference.teamSlotIndex].trainer.fieldContainerIndex;
            for (int i=0; i < battleControllerReference.fieldController.fieldContainers[slot].fieldSpots.Count(); i++)
            {
                TrainerSelectionData selection = playerControllerReference.GetSelection(i);
                SelectionSlot selectSlot = new();
                selectSlot.trainerID = playerControllerReference.teamSlotIndex;
                selectSlot.trainerSelectionData = selection;
                battleControllerReference.roundQueue.roundData.selectionData.Add(selectSlot);
                Console.WriteLine(battleControllerReference.fieldController.fieldContainers[slot].fieldSpots[i].pkmnDataObject.api_key);
                

            }
        }
    }
}
