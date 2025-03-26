using RimWorld;
using Verse;

namespace WastepackGraph
{
    public class HistoryAutoRecorderWorker_Wastepacks : HistoryAutoRecorderWorker
    {
        public override float PullRecord()
        {
            GameComponent_WastepackGraph comp = Current.Game.GetComponent<GameComponent_WastepackGraph>();
            float wastepacksGenerated = comp.GetWastepacksGenerated();
            comp.ResetWastepacksGenerated();
            return wastepacksGenerated;
        }
    }
}
