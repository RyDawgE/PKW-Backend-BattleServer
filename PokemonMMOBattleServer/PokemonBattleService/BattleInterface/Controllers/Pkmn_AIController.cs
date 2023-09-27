using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleInterface.Controllers
{
    public class Pkmn_AIController: PlayerControllerBase
    {
        public Pkmn_AIController() : base() 
        { 

        }
        public override TrainerSelectionData GetSelection(int fieldID)
        {
            base.GetSelection(fieldID);
            TrainerSelectionData data = new();
            return data;

        }


    }
}
