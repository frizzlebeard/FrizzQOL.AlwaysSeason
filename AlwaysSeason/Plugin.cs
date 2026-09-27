using BepInEx;
using HarmonyLib;

namespace AlwaysSeason
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "com.frizzqol.alwaysseason";
        public const string PluginName = "FrizzQOL Always Season";
        public const string PluginVersion = "0.1.0";

        internal static Plugin Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            Harmony harmony = new Harmony(PluginGuid);
            try
            {
                harmony.PatchAll();
                Logger.LogInfo($"{PluginName} {PluginVersion} loaded");
            }
            catch (System.Exception ex)
            {
                Logger.LogError($"Harmony patch failed: {ex.Message}");
            }
        }

        internal static void LogInfo(string message)
        {
            if (Instance != null)
            {
                Instance.Logger.LogInfo(message);
            }
        }
    }
}
