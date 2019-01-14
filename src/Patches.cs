using Harmony;
using UnityEngine;

namespace FreeLookInCars
{
    [HarmonyPatch(typeof(PlayerInVehicle), "EnterVehicle")]
    public class PlayerInVehicle_EnterVehicle
    {
        public static void Postfix(PlayerInVehicle __instance)
        {
            __instance.m_YawLimitDegrees = new Vector2(-175, 175);
        }
    }
}