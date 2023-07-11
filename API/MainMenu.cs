using HarmonyLib;
using MultiplayerShooterKit;
using UnityEngine;

namespace Undisputables.API
{
  public class MainMenu : MonoBehaviour
  {
    [HarmonyPatch(typeof(UIMain), "StartMatch")]
    public class StartMatch_Patch
    {
      public static bool Prefix(UIMain __instance, bool private_match, bool private_create)
      {
        if (ItemsManager.instance.GetShowedWeaponItem().unlocked == true) { ItemsManager.instance.SetShowedWeapon(); Debug.LogError("WEAPON DONE"); }
        if (ItemsManager.instance.GetShowedAvatarItem().unlocked == true) { ItemsManager.instance.SetShowedAvatar(); Debug.LogError("PLAYER DONE"); }
        if (ItemsManager.instance.GetShowedGrenadeItem().unlocked == true) { ItemsManager.instance.playerBot.grenadePrefabName = ItemsManager.instance.GetShowedGrenadeItem().name; Debug.LogError("GRENADE DONE"); }
        string name = ItemsManager.GetInstance().Regions.items[__instance.regionDropDown.value].name;
        __instance.loadingWindow.SetActive(true);
        NetworkManagerCustom.StartMatch(private_match, private_create, __instance.privateMatchNameInput.text, name);
        __instance.StartCoroutine(__instance.HandleTimeout());
        return false;
      }
    }

    [HarmonyPatch(typeof(AudioManager), "PlayMenuMusic")]
    public class PlayMenuMusic_Patch
    {
      public static bool Prefix(AudioManager __instance, int index)
      {
        if (SettingsManager.musicfix == false)
        { 
          return true;
        }
        else 
        {
          AudioManager.instance.musicSource.Stop();
          SettingsManager.MusicToggle.isOn = false;
          return false;
        } 
      }
    } 
    [HarmonyPatch(typeof(UIMain), "HideSplashScreen")]
    public static class UIMain_Patch
    {
      static bool Prefix()
      {
        if (SettingsManager.musicfix == true)
        {
          SettingsManager.MusicToggle.isOn = false; 
          AudioManager.instance.musicSource.Stop();
        }
        GameObject.Find("Canvas/SplashScreen").SetActive(false);
        InputManager.GetInstance().lockCursor = false;
        return false;
      }
    }
  }
}
