using PokemonMMOBattleServer.PokemonBattleService.BattleFlow;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData.Field
{
    public class Pkmn_Field
    {
        public readonly BattleController battleControllerReference;
        public List<Pkmn_FieldContainer> fieldContainers = new();
        public Pkmn_Field(BattleController _battleController) 
        {
            battleControllerReference = _battleController;
        }

        public void SetupField()
        {
            foreach (TeamSlot slot in battleControllerReference.teamSlots)
            {
                Pkmn_FieldContainer container = new Pkmn_FieldContainer(battleControllerReference, slot.trainer);
                fieldContainers.Add(container);
                slot.trainer.fieldContainerIndex = fieldContainers.Count() -1;
                container.CreateFieldSpots();
            }
        }

    }
}
