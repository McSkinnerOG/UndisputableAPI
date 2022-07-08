using System;
using MultiplayerShooterKit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Undisputables.API
{
    public class SettingsManager
    {
        public static SettingManager SM { get => SettingManager.Instance; }
        public static Dropdown GraphicsDropdown { get => SM.graphicsDrop; }
        public static Dropdown ResolutionDropdown { get => SM.resolutionDrop; }
        public static Toggle MusicToggle { get => SM.musicToggle; }
        public static Button QuitButton { get => SM.quitButton; } 
        public static Slider SesitivitySlider { get => SM.sensibilitySlider; }
        public static Slider VolumeSlider { get => SM.volumeSlider; }
        public static GameObject QuitPopupPanel { get => SM.quitPopup; }
        public static GameObject SettingsPopupPanel { get => SM.settingPopup; }
        public static int TargetFramerate { get => SM.targetFrameRates; set => SetTargetFramerate(value); }
        public static void SetTargetFramerate(int value) { SM.targetFrameRates = value; }



        public static bool SettingsPanelActive { get => SettingsPopupPanel.activeSelf; }
        public static void SetSettingsPanelActive(bool value) { SettingsPopupPanel.SetActive(value); }

        public static bool QuitPanelActive { get => QuitPopupPanel.activeSelf; }
        public static void SetQuitPanelActive(bool value) { QuitPopupPanel.SetActive(value); }

    }
}
