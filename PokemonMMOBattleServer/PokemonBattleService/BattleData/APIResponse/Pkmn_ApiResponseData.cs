using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData.APIResponse
{
    public class PokeAPIStat
    {
        public int base_stat { get; set; }
    }

    public class PokeAPIResponse  // This is the final response class. All data derived from PokeAPI will end up here.
                                  // This needs to copy the format exactly, but it doesn't need all of the data.
    {
        public List<PokeAPIStat> Stats { get; set; }
    }
}
