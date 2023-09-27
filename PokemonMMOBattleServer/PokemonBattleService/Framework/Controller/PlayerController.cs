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
        public string event_id = "move"; //move, item, switch, run
        public string event_selection_id = "tackle"; //move_id, item_id, party_slot_id, none
        public int target_team_id = 0; //team
        public int target_id = 0; //specific pokemon
        public List<string> event_args = new(); //mega
    }

    public class PlayerControllerBase
    {
        public TrainerDataType trainerType = TrainerDataType.ai; //by default
        public PlayerControllerBase() { }

        public int teamSlotIndex = -1;
        public virtual TrainerSelectionData GetSelection(int fieldID) //field ID corresponds to what pokemon the selection will count towards
        {
            Console.WriteLine("Trainer Turn");
            return new TrainerSelectionData(); 
        }
    }

}
