﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;
using UnityEngine;
using HarmonyLib;

namespace ProjectRimFactory.Common.HarmonyPatches
{
    [HarmonyPatch(typeof(ModContentPack), "get_Patches")]
    class Patch_ModContentPack_Pathes
    {
        static void Postfix(ModContentPack __instance, ref IEnumerable<PatchOperation> __result)
        {
            if(__instance.PackageId.ToLower() == LoadedModManager.GetMod<ProjectRimFactory_ModComponent>().Content.PackageId.ToLower())
            {
                var setting = LoadedModManager.GetMod<ProjectRimFactory_ModComponent>().Settings;
                __result = __result.Concat(setting.Patches);
            }
        }
    }
}
