using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Undisputables.DefNotHax;
using System.IO;
using System.Reflection;
using UnityEngine.SceneManagement;

namespace Undisputables
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    public class Main : BaseUnityPlugin
    {
        #region[Declarations]

        public const string
            MODNAME = "Undisputables",
            AUTHOR = "",
            GUID = AUTHOR + "_" + MODNAME,
            VERSION = "1.0.0.0";

        internal readonly ManualLogSource log;
        internal readonly Harmony harmony;
        internal readonly Assembly assembly;
        public readonly string modFolder;

        #endregion
        
        public Main()
        {
            log = Logger;
            harmony = new Harmony(GUID);
            assembly = Assembly.GetExecutingAssembly();
            modFolder = Path.GetDirectoryName(assembly.Location);
        }

        public void Start()
        {
            harmony.PatchAll(assembly);
        }

        public void Update()
        { 
            if (SceneManager.GetActiveScene().name != "Home")
            {
                API.World.Update();
                API.GameManagerCustom.Update();
                GameManagerCustom.Update();
                LocalPlayer.Update();
            } 
            NetworkManager.Update();
        }
    }
}
