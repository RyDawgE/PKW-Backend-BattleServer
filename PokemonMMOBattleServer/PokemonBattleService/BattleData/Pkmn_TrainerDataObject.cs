using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonMMOBattleServer.PokemonBattleService.BattleData
{
    public enum TrainerDataType
    {
        net,
        ai
    }
    public class Pkmn_TrainerDataObject
    {
        public List<Pkmn_DataObject> Pkmn_Party = new();
        public int fieldContainerIndex = -1;
        
        public Pkmn_TrainerDataObject()
        {

        }

        public void SetupPokemonParty(TrainerDataType type, string trainerPath)
        {
            // Pull from DB here. For now, just randomly generate the team.
            List<string> pkmnIDs = new List<string>
            {
                "pikachu", "charizard", "blastoise", "mudkip", "mewtwo"
            };

            Pkmn_DataObject pkmn = new Pkmn_DataObject();
            pkmn.SetupFromAPI(pkmnIDs[2]); //Ill make this random later, kek
            Pkmn_Party.Add(pkmn);
        }
    }
}
