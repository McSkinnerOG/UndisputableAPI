using HarmonyLib;
using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Undisputables.API
{
    public class MainMenu : MonoBehaviour
    {
        public static bool MusicBool = false;
        [HarmonyPatch(typeof(UIMain), "HideSplashScreen")] 
        public static class UIMain_Patch
        {
            static bool Prefix()
            {
                AudioManager.GetInstance().musicSource.enabled = false; 
                GameObject.Find("Canvas/SplashScreen").SetActive(false); 
                InputManager.GetInstance().lockCursor = false;
                return false;
            }
        } 
    }
}
