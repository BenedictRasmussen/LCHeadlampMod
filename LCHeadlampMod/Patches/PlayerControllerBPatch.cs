using GameNetcodeStuff;
using HarmonyLib;

namespace LCHeadlampMod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        // This is a clean way to patch public methods. It does not work with private.
        // [HarmonyPatch(nameof(PlayerControllerB.Update))]
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private static void infiniteSprintPatch(ref float ___sprintMeter)
        {
            // sprintMeter is used as a multiplier between 0 and 1. Setting it back to 1 will keep it full every frame.
            ___sprintMeter = 1f;
        }
    }
}
