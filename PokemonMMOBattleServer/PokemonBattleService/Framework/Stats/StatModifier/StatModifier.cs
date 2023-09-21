using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.Framework.Stats.Modifier
{
    public class StatModifier
    {
        string id = "";

        public StatModifier(string id = "") {
            this.id = id;

        }

        public float Evaluate(float value)
        {
            return value;
        }

    }
}
