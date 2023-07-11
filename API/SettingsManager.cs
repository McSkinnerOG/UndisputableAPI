using MultiplayerShooterKit;
using UnityEngine;
using UnityEngine.UI;

namespace Undisputables.API
{
  public class SettingsManager
  {
    public static bool musicfix = true;
    public static SettingManager Settings { get => SettingManager.Instance; }
    public static Dropdown GraphicsDropdown { get => Settings.graphicsDrop; }
    public static Dropdown ResolutionDropdown { get => Settings.resolutionDrop; }
    public static Toggle MusicToggle { get => Settings.musicToggle; }
    public static Button QuitButton { get => Settings.quitButton; }
    public static Slider SesitivitySlider { get => Settings.sensibilitySlider; }
    public static Slider VolumeSlider { get => Settings.volumeSlider; }
    public static GameObject QuitPopupPanel { get => Settings.quitPopup; }
    public static GameObject SettingsPopupPanel { get => Settings.settingPopup; }
    public static int TargetFramerate { get => Settings.targetFrameRates; set => Settings.targetFrameRates = value; } 
    public static bool SettingsPanelActive { get => SettingsPopupPanel.activeSelf; set => SettingsPopupPanel.SetActive(value); } 
    public static bool QuitPanelActive { get => QuitPopupPanel.activeSelf; set => QuitPopupPanel.SetActive(value); }  
  }
}
