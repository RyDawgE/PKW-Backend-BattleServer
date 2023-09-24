using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData
{
    public class Pkmn_NetMoveResponseData
    {
        public string move_id { get; set; }

        public int target_team_id { get; set; }

        public int target_mon_id { get; set; }
    }
}
