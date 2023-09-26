using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.Framework.Controller
{
    public class TrainerSelectionData
    {
        string event_id = "move";
        string event_selection_id = "move_id";
        int target_team_id = 0;
        int target_id = 0;
        List<string> event_args = new List<string>();

    }
    public class PlayerControllerBase
    {
        public PlayerControllerBase() { }
        public virtual TrainerSelectionData GetSelection()
        {
            return new TrainerSelectionData(); 
        }
    }

}
