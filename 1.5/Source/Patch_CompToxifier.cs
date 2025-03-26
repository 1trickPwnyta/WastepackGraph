using HarmonyLib;
using RimWorld;
using Verse;

namespace WastepackGraph
{
    [HarmonyPatch(typeof(CompToxifier))]
    [HarmonyPatch("PolluteNextCell")]
    public static class Patch_CompToxifier
    {
        public static void Prefix(CompToxifier __instance)
        {
            if (__instance.CanPolluteNow)
            {
                float wastepackEquivalent = ((CompProperties_Toxifier)__instance.props).cellsToPollute / 6f;
                Current.Game.GetComponent<GameComponent_WastepackGraph>().Notify_WastepacksGenerated(wastepackEquivalent);
            }
        }
    }
}
