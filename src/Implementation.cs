using System.Reflection;
using UnityEngine;

namespace FreeLookInCars
{
    public class Implementation
    {
        public const string NAME = "Free-Look-In-Cars";

        public static void OnLoad()
        {
            AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
            Log("Version " + assemblyName.Version);
        }

        internal static void Log(string message)
        {
            Debug.LogFormat("[" + NAME + "] {0}", message);
        }

        internal static void Log(string message, params object[] parameters)
        {
            string preformattedMessage = string.Format("[" + NAME + "] {0}", message);
            Debug.LogFormat(preformattedMessage, parameters);
        }
    }
}