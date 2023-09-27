using PokemonMMOBattleServer.PokemonBattleService.BattleFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData.Field
{
    public class Pkmn_FieldContainer
    {
        public readonly BattleController battleControllerReference;
        public readonly Pkmn_TrainerDataObject trainerDataObjectReference;
        public List<Pkmn_FieldSpot> fieldSpots = new();
        public Pkmn_FieldContainer(BattleController _battleController, Pkmn_TrainerDataObject _trainerDataObject) 
        {
            battleControllerReference = _battleController;
            trainerDataObjectReference = _trainerDataObject;
        }

        public void CreateFieldSpots()
        {
            for (int i = 0; i < battleControllerReference.battleData.spotsPerTrainer ; i++)
            {
                fieldSpots.Add(new Pkmn_FieldSpot(this));
            }
                
        }
    }
}
