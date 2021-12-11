using System;
using System.Collections;
using System.Reflection;
using GlobalEnums;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using Modding;
using Modding.Delegates;
using UnityEngine;

namespace hkhppoint5
{
    public class hkhplol : Mod, ITogglableMod
    {
        PlayerData pd = PlayerData.instance;

        public override void Initialize()
        {
            ModHooks.NewGameHook += NewGame;
            ModHooks.AfterSavegameLoadHook += SaveGame;
            Log("Initializing");
            
        }

        public void NewGame()
        {
            this.Healthy(pd);
        }

        public void SaveGame(SaveGameData lol2)
        {
            this.NewGame();

        }

        public void Unload()
        {
            ModHooks.NewGameHook -= NewGame;
            ModHooks.AfterSavegameLoadHook -= SaveGame;
        }

        public void Healthy(PlayerData pd)
        {
            pd.health = 1;
            pd.maxHealthBase = 1;
            pd.maxHealthCap = 1;
            pd.maxHealth = 1;
        }
    }
}
