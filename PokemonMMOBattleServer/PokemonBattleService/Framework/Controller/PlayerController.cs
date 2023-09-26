using PokemonMMOBattleServer.PokemonBattleService.BattleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.Framework.Controller
{
    public class TrainerSelectionData
    {
        string event_id = "move"; //move, item, switch, run
        string event_selection_id = "tackle"; //move_id, item_id, party_slot_id, none
        int target_team_id = 0;
        int target_id = 0;
        List<string> event_args = new List<string>(); //mega

    }
    public class PlayerControllerBase
    {
        public TrainerDataType trainerType = TrainerDataType.ai; //by default
        public PlayerControllerBase() { }
        public virtual TrainerSelectionData GetSelection()
        {
            return new TrainerSelectionData(); 
        }
    }

}
