using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Undisputables.API;
using MultiplayerShooterKit;
using UndisputablesAPI.DefNotHax;

namespace Undisputables.DefNotHax
{
    public class LocalPlayer : MonoBehaviour
    {
        public static bool bhopActive = false;
        public static bool godActive = false;
        public static bool ragdollActive = false;
        public static bool infAmmo = false;
        public static bool noGrav = false;
        public static bool esp = false;
        public static bool aimbot = false;
        public static void Update()
        {
            if (Input.GetKeyDown(KeyCode.U)) { ragdollActive = !ragdollActive; }
            if (Input.GetKeyDown(KeyCode.G)) { godActive = !godActive; }
            if (Input.GetKeyDown(KeyCode.B)) { bhopActive = !bhopActive; }
            if (Input.GetKeyDown(KeyCode.J)) { infAmmo = !infAmmo; }
            if (Input.GetKeyDown(KeyCode.K)) { noGrav = !noGrav; }
            if (Input.GetKeyDown(KeyCode.Y)) { esp = !esp; }
            if (Input.GetKeyDown(KeyCode.O)) { aimbot = !aimbot; }
            if (Input.GetKeyDown(KeyCode.P)) { API.Weapon.UpdateWeapon(2f, 9999999, 1f, 10f, 0.0001f, 9999999, 1.0824f, 9999999f); }
            if (bhopActive) { BHOP(); } else if (bhopActive == false) {  API.LocalPlayer.LP.moveAirMultiply = 0.6f; }
            if (godActive) { GodMode(); }
            if (infAmmo) { InfAmmo(); }
            if (noGrav) { NoGravity(); } else if (noGrav == false) { API.LocalPlayer.LP.gravityScale = 3; }
            if (esp) { ESP(); }
            if (aimbot) { BadAimbotAttemptXD(); }
            if (Input.GetKeyDown(KeyCode.LeftArrow)) { player--; if (player <= -1) { player = 0; } }
            if (Input.GetKeyDown(KeyCode.RightArrow)) { player++; }
        } 
        public static int player = 0;
        public static PlayerBot[] targets; 
        public static void BadAimbotAttemptXD()
        {
            targets = FindObjectsOfType<PlayerBot>();
            var cam1 = GameObject.Find("Managers/TPSCamera/Camera");
            if (cam1 != null)
            {
                if (cam1.GetComponent<Aimbot>() != null)
                {
                    cam1.transform.LookAt(targets[player].gameObject.transform.position);
                }
                else { cam1.AddComponent<Aimbot>(); }
            } 
        }
        public static GameObject Cam { get => GameObject.Find("SmoothCamera"); }
        public static void ESP()
        {
            targets = FindObjectsOfType<PlayerBot>();
            if (Cam.GetComponent<NDraw.Drawer>() == null) { Cam.AddComponent<NDraw.Drawer>(); }
            foreach (PlayerBot p in targets)
            {
                NDraw.Draw.World.Line(API.LocalPlayer.LP.gameObject.transform.position, p.gameObject.transform.position);
            } 
        }

        public static void InfAmmo()
        {
            if (API.LocalPlayer.Ammo < 999999) { API.LocalPlayer.Ammo = 999999; }
        }
        public static void BHOP()
        {
            if (API.LocalPlayer.LP.moveAirMultiply < 1) { API.LocalPlayer.LP.moveAirMultiply = 2; } // Do a check so we dont write a value when we dont need to
            if (API.LocalPlayer.LP.grounded == true) { API.LocalPlayer.LP.jump_action = true; }
        }

        public static void GodMode()
        {
            API.LocalPlayer.LP.maxHealth = 999999; // Set Players MaxHealth to spastic int value
            API.LocalPlayer.LP.health = API.LocalPlayer.LP.maxHealth; // Write health = maxHealth = GodMode; 
        }
        public static void NoGravity() { API.LocalPlayer.LP.gravityScale = -0.0001f; }
    }
}
