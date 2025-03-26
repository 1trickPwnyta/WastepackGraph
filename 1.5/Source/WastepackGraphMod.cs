using HarmonyLib;
using Verse;

namespace WastepackGraph
{
    public class WastepackGraphMod : Mod
    {
        public const string PACKAGE_ID = "wastepackgraph.1trickPwnyta";
        public const string PACKAGE_NAME = "Wastepack Graph";

        public WastepackGraphMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
