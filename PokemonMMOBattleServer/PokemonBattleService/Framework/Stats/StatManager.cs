using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.Framework.Stats
{
    public class StatManager
    {
        public Dictionary<string, Stat> Stats = new();

        public StatManager()
        {

        }

        public Stat AddStat(string statId, string statName, float value) 
        {
            Stat statRef = new Stat(statName, statId, value);
            Stats.Add(statId, statRef);

            return statRef;
        }
    }
}
