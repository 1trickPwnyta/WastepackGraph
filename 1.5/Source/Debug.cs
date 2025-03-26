namespace WastepackGraph
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{WastepackGraphMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
