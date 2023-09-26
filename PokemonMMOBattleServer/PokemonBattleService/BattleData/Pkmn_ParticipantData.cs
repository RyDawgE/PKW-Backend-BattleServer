using PokemonMMOBattleServer.PokemonBattleService.Framework.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData
{
    public class Pkmn_ParticipantData
    {
        public List<PlayerControllerBase> NetTrainerControllers = new();
        public List<PlayerControllerBase> AITrainerControllers = new();

        public int GetPlayerCount()
        {
            return NetTrainerControllers.Count() + AITrainerControllers.Count();
        }

        public List<PlayerControllerBase> GetAllPlayerControllers()
        {
            List<PlayerControllerBase> netList = NetTrainerControllers;
            List<PlayerControllerBase> aiList = AITrainerControllers;
            List<PlayerControllerBase> totalList = new();
            totalList.AddRange(aiList);
            totalList.AddRange(netList);
            return totalList;
        }

    }
}
