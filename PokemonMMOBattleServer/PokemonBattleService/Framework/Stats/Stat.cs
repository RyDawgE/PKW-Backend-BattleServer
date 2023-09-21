using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Stats.Modifier;


namespace PokemonMMOBattleServer.PokemonBattleService.Framework.Stats
{
    public class Stat
    {
        List<StatModifier> Modifiers = new();

        string id = "";
        string name = "stat name";
        float value = 0;

        event EventHandler OnStatEditedEvent;

        public Stat(string name = "stat name", string id = "defaultId", float value = 0)
        {
            this.name = name;
            this.id = id;
            this.value = value;
        }

        public float Evaluate()
        {
            float val = value;
            foreach(StatModifier modifier in Modifiers)
            {
                val = modifier.Evaluate(val);
            }
            return val;
        }

        public float EditStat(float value)
        {
            this.value = value;

            return this.value;
        }
    }
    


}
