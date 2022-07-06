using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Undisputables.API
{
    public class World : MonoBehaviour
    {
        #region[API GET SET]
        #endregion
        public static string MapName { get => NetworkManager.NMC.map; } 
        #region[!!!REQUIRED API FUNCTIONS!!!]
        #endregion
        #region[CUSTOM API FUNCTIONS]
        #endregion
        public static void ClearMapClutter(string mapName) { } 
        public static void Update() { }
    }
}
