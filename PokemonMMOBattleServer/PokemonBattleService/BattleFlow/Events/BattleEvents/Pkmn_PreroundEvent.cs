using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using PokemonMMOBattleServer.PokemonBattleService.BattleData.Field;
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

        public override void BattleEventLogic()
        {
            base.BattleEventLogic();
            foreach (TeamSlot slot in battleControllerReference.teamSlots) //send out pokemon if user has none
            {
                foreach (Pkmn_FieldSpot fieldSlot in battleControllerReference.fieldController.fieldContainers[slot.trainer.fieldContainerIndex].fieldSpots)
                {
                    if (fieldSlot.pkmnDataObject == null)
                    {
                        Pkmn_DataObject newMon = slot.trainer.GetEligiblePokemonReference();
                        if (newMon != null)
                        {
                            fieldSlot.pkmnDataObject = newMon;
                        }
                    }
                }
            }
        }
    }
}
