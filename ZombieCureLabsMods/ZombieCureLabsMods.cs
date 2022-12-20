using UnityEngine;
using UModFramework.API;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ZombieCureLabsMods
{
    [UMFHarmony(1)] //Set this to the number of harmony patches in your mod.
    [UMFScript]
    class ZombieCureLabsMods : MonoBehaviour
    {
        internal static void Log(string text, bool clean = false)
        {
            using (UMFLog log = new UMFLog()) log.Log(text, clean);
        }

        [UMFConfig]
        public static void LoadConfig()
        {
            ZombieCureLabsModsConfig.Load();
        }

		void Awake()
		{
			Log("ZombieCureLabsMods v" + UMFMod.GetModVersion().ToString(), true);
		}
	}
}