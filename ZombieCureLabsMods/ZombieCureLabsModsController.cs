using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Collections;
using UnityEngine;
using UModFramework.API;
using HarmonyLib;
using TheraBytes.Boba.Game;

/**
 * Reserved for future use
 **/

namespace ZombieCureLabsMods
{
    public class ZombieCureLabsModsController : MonoBehaviour
    {
        public void OnAwake()
        {
        }

        public void OnUpdate()
        {
        }

        public static ZombieCureLabsModsController Instance { get; set; } = new ZombieCureLabsModsController();
    }
}