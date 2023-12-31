﻿using PokemonMMOBattleServer.PokemonBattleService.BattleData.APIResponse;
using PokemonMMOBattleServer.PokemonBattleService.Framework.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokemonMMOBattleServer.PokemonBattleService.BattleData
{
    public class Pkmn_DataObject
    {
        public string api_key = "pikachu";
        public StatManager statManager = new();
        public List<string> moves = new();
        public int level = 50;
        public bool canBeSentOut = true;
        public Pkmn_DataObject() 
        {
            statManager.AddStat("mhp", "HP", 0);
            statManager.AddStat("atk", "Attack", 0);
            statManager.AddStat("def", "Defense", 0);
            statManager.AddStat("spatk", "Special Attack", 0);
            statManager.AddStat("spdef", "Special Defense", 0);
            statManager.AddStat("spd", "Speed", 0);

            SetupFromAPI(); // temp
        }

        public async void SetupFromAPI(string id  = "charizard")
        {
            api_key = id;
            HttpClient? client = new();
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(id);
            if (response.IsSuccessStatusCode)
            {
                PokeAPIResponse pokeAPIData = await response.Content.ReadAsAsync<PokeAPIResponse>();

                List<Stat> pokeStats = new()
                {
                    statManager.GetStat("mhp"),
                    statManager.GetStat("atk"),
                    statManager.GetStat("def"),
                    statManager.GetStat("spatk"),
                    statManager.GetStat("spdef"),
                    statManager.GetStat("spd")
                    
                };
                int i = 0; foreach (var stat in pokeAPIData.Stats)
                {
                    pokeStats[i].EditStat(stat.base_stat);
                    i++;
                }
            }
            client.Dispose();  // Remove HTTP Interface Client
            client = null;
        }
    }
}
