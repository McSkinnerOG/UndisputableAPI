using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Undisputables.DefNotHax
{
    public class SettingsManager : MonoBehaviour
    { 
        public static bool musicfix = false;
        public static Button SelectButton;
        public static Button PlayButton;
        public static UIMain UIMain; 




        public static void PlayButtonListenerAdd()
        {
            if (ItemsManager.instance.GetShowedWeaponItem().unlocked == true) { ItemsManager.instance.SetShowedWeapon(); Debug.LogError("WEAPON DONE"); }
            if (ItemsManager.instance.GetShowedAvatarItem().unlocked == true)  { ItemsManager.instance.SetShowedAvatar(); Debug.LogError("PLAYER DONE"); }
            if (ItemsManager.instance.GetShowedGrenadeItem().unlocked == true)
            { ItemsManager.instance.playerBot.grenadePrefabName = ItemsManager.instance.GetShowedGrenadeItem().name; Debug.LogError("GRENADE DONE"); }
            UIMain.StartMatch(false, false);
        }
        public static AudioClip ee;
        public static void Update()
        {
            

            if (SceneManager.GetActiveScene().name == "Home")
            {
                if (PlayButton == null)
                {
                    SelectButton = GameObject.Find("Canvas/MainMenu/Select").GetComponent<Button>();
                    PlayButton = GameObject.Find("Canvas/MainMenu/Play").GetComponent<Button>();
                    UIMain = FindObjectOfType<UIMain>();
                }
                if (PlayButton != null)
                {
                    if (musicfix == true)
                    {
                        AudioManager.instance.musicSource.Stop();
                        AudioManager.instance.musicSource.enabled = false; 
                        AudioManager.instance.musicSource = null; 
                        if (API.SettingsManager.MusicToggle.isOn == true) { API.SettingsManager.MusicToggle.isOn = false; } 
                        musicfix = false;
                    }
                }
                if (EventSystem.current != null)
                {
                    if (EventSystem.current.currentSelectedGameObject != null)
                    {
                        if (EventSystem.current.currentSelectedGameObject.name == "Play" && EventSystem.current.currentSelectedGameObject.activeSelf == true)
                        { EventSystem.current.currentSelectedGameObject.SetActive(false); PlayButtonListenerAdd(); }
                        if (EventSystem.current.currentSelectedGameObject.name == "Ok" && EventSystem.current.currentSelectedGameObject.activeSelf == true)
                        { 
                            GameObject.Find("Canvas/ItemUpdatedPopup").SetActive(false);
                            AudioManager.instance.musicSource.clip = null;
                        }
                    }
                } 
            } 
        } 
    }
}
