using UnityEngine;
using HarmonyLib;
using TheraBytes.Boba.Game;
using System.Collections;
using System.Reflection;

namespace ZombieCureLabsMods.Patches
{
    [HarmonyPatch]
    public class DayPresenceAwarenessPatch
    {
        [HarmonyPatch(typeof(ZombieAwarenessLevel))]
        [HarmonyPatch("DayPresenceAwareness", MethodType.Getter)]
        static class ZombieAwarenessLevel_DayPresenceAwareness
        {
            static bool Prefix(ref float __result)
            {
                __result = 0;
                return false;
            }
        }
    }
}