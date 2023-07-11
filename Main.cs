using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Undisputables.DefNotHax;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Undisputables
{
  [BepInPlugin(GUID, MODNAME, VERSION)]
  public class Main : BaseUnityPlugin
  {
    #region[Declarations] 
    public const string MODNAME = "Undisputables", AUTHOR = "", GUID = AUTHOR + "_" + MODNAME, VERSION = "1.0.0.0"; 
    public static ManualLogSource log;
    public static Harmony harmony;
    public static Assembly assembly;
    public static string modFolder; 
    #endregion 
    public Main()
    { 
      harmony = new Harmony(GUID);
      assembly = Assembly.GetExecutingAssembly();
      modFolder = Path.GetDirectoryName(assembly.Location);
    } 
    public void Start()
    {
      harmony.PatchAll();
      using (Process p = Process.GetCurrentProcess()) p.PriorityClass = ProcessPriorityClass.High; 
    }
    public static string audioName = "hit1.wav";
    public static AudioSource audioSource;
    public static AudioClip audioClip;
    public string soundPath = "file://" + Application.streamingAssetsPath + "/Sound/";
    public static bool customSFX = false; 
    public IEnumerator LoadAudio()
    {
      WWW request = GetAudioFromFile(soundPath, audioName);
      yield return request;
      audioClip = request.GetAudioClip();
      audioClip.name = audioName;
      API.Weapon.MyWeapon.bulletPrefab.hitSFX = audioClip;
      API.Weapon.MyWeapon.bulletPrefab.shotSFX = audioClip;
      API.Weapon.MyWeapon.bulletPrefab.bloodSFX = audioClip;
    }
    private WWW GetAudioFromFile(string path, string filename)
    {
      string audioToLoad = string.Format(path + "{0}", filename);
      WWW request = new WWW(audioToLoad);
      return request;
    }
    private void PlayAudioFile()
    {
      audioSource.clip = audioClip;
      audioSource.Play();
      audioSource.loop = false;
    }
    public void Update()
    {
      if (SceneManager.GetActiveScene().name != "Home")
      { 
        API.GameManagerCustom.Update(); 
        LocalPlayer.Update();
        Aimbot.Update();
        if (Input.GetKeyDown(KeyCode.P)) { StartCoroutine(LoadAudio()); }
      } 
    }
  }
}
