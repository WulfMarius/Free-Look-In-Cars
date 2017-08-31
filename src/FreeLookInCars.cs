using Harmony;
using UnityEngine;

namespace FreeLookInCars
{
    [HarmonyPatch(typeof(PlayerInVehicle))]
    [HarmonyPatch("Start")]
    public class FreeLookInCars
    {
        public static void Postfix(PlayerInVehicle __instance)
        {
            __instance.m_YawLimitDegrees = new Vector2(-175, 175);
        }
    }
}
