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
        public static Button SelectButton;
        public static Button PlayButton; 
        public static void Update() 
        {
            if (SceneManager.GetActiveScene().name == "Home")
            {
                var music = GameObject.Find("DontDestroyManagers/OverlayCanvas/SettingsPopup/Window/MusicToggle").GetComponent<Toggle>();
                if (music.isOn == true)
                {
                    music.isOn = false;
                }
                if (PlayButton == null)
                {
                    SelectButton = GameObject.Find("Canvas/MainMenu/Select").GetComponent<Button>();
                    PlayButton = GameObject.Find("Canvas/MainMenu/Play").GetComponent<Button>();
                } 
                else if (PlayButton != null && Input.GetKeyDown(KeyCode.Space))
                {
                    ItemsManager.instance.SetShowedAvatar();
                    ItemsManager.instance.SetShowedItem();
                    ItemsManager.instance.SetShowedWeapon(); 
                    PlayButton.onClick.Invoke();
                }
            } 
        }
    }
}
