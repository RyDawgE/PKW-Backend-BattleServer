using PokemonMMOBattleServer.PokemonBattleService.BattleFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData.Field
{
    public class Pkmn_FieldSpot
    {
        Pkmn_FieldContainer owningField;
        public Pkmn_FieldSpot(Pkmn_FieldContainer _fieldContainer) 
        {
            Console.WriteLine("Made Field Slot");
            owningField = _fieldContainer;
        }

    }
}
