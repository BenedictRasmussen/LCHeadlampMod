using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace LCHeadlampMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "Pines.Headlamp.154a54a5-2a98-454e-b4f5-7cd6499785e1";
        private const string modName = "Headlamp";
        private const string modVersion = "0.0.1";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static Plugin INSTANCE;

        private ManualLogSource log;

        void Awake()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Plugin();
            }

            log = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            log.LogInfo($"{modName} loading complete");

            harmony.PatchAll(typeof(Plugin));
        }
    }
}
