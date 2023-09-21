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

        public float EvaluateStat(string statId)
        {
            return Stats[statId].Evaluate();
        }

        public Stat GetStat(string id)
        {
            return Stats[id];
        }

        public float EditStatValue(string statId, float value)
        {
            Stats[statId].EditStat(value);
            return value;
        }
    }
}
