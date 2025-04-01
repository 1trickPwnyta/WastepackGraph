using HarmonyLib;
using RimWorld;
using Verse;

namespace WastepackGraph
{
    [HarmonyPatch(typeof(CompWasteProducer))]
    [HarmonyPatch(nameof(CompWasteProducer.ProduceWaste))]
    public static class Patch_CompWasteProducer
    {
        public static void Prefix(int amountToMake)
        {
            Current.Game.GetComponent<GameComponent_WastepackGraph>().Notify_WastepacksGenerated(amountToMake);
        }
    }
}
