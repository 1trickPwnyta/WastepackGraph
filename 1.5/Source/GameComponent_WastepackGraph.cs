using Verse;

namespace WastepackGraph
{
    public class GameComponent_WastepackGraph : GameComponent
    {
        private float wastepacksGenerated = 0f;

        public GameComponent_WastepackGraph() { }

        public GameComponent_WastepackGraph(Game _) { }

        public float GetWastepacksGenerated()
        {
            return wastepacksGenerated;
        }

        public void ResetWastepacksGenerated()
        {
            wastepacksGenerated = 0f;
        }

        public void Notify_WastepacksGenerated(float count)
        {
            wastepacksGenerated += count;
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref wastepacksGenerated, "wastepacksGenerated");
        }
    }
}
