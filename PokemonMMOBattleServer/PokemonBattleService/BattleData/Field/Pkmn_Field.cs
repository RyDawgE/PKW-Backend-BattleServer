using PokemonMMOBattleServer.PokemonBattleService.BattleFlow;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData.Field
{
    public class Pkmn_Field
    {
        BattleController battleControllerReference;
        List<Pkmn_FieldContainer> fieldContainers = new();
        public Pkmn_Field(BattleController _battleController) 
        {
            battleControllerReference = _battleController;
        }

        public void SetupField()
        {
            foreach (PlayerControllerBase trainer in battleControllerReference.battleParticipants.GetAllPlayerControllers())
            {
                //fieldContainers.Add(new Pkmn_FieldContainer(battleControllerReference, trainer);
                // Field Containers should be made per TrainerDataObject, which hasnt had a place to go yet
                // Come back to this later!! ToDo
            }
        }

    }
}
