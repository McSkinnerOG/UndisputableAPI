using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Undisputables.API;
namespace Undisputables.DefNotHax
{
    public class LocalPlayer
    {
        public static bool bhopActive = false;
        public static bool godActive = false;
        public static bool ragdollActive = false;
        public static bool infAmmo = false;
        public static bool noGrav = false;
        public static void Update()
        {
            if (Input.GetKeyDown(KeyCode.U)) { ragdollActive = !ragdollActive; }
            if (Input.GetKeyDown(KeyCode.G)) { godActive = !godActive; }
            if (Input.GetKeyDown(KeyCode.B)) { bhopActive = !bhopActive; }
            if (Input.GetKeyDown(KeyCode.J)) { infAmmo = !infAmmo; }
            if (Input.GetKeyDown(KeyCode.K)) { noGrav = !noGrav; }
            if (Input.GetKeyDown(KeyCode.P)) { API.Weapon.UpdateWeapon(2f, 9999999, 1f, 10f, 0.0001f, 9999999, 1.0824f, 9999999f); }
            if (bhopActive) { BHOP(); } else if (bhopActive == false) {  API.LocalPlayer.LP.moveAirMultiply = 0.6f; }
            if (godActive) { GodMode(); }
            if (infAmmo) { InfAmmo(); }
            if (noGrav) { NoGravity(); } else if (noGrav == false) { API.LocalPlayer.LP.gravityScale = 3; }
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
