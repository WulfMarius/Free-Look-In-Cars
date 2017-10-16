using UnityEngine;

namespace FreeLookInCars
{
    internal class FreeLookInCars
    {
        public static void OnLoad()
        {
            Debug.Log("[Free-Look-In-Cars]: Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}