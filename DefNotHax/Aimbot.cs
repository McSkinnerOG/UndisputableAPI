using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using UnityEngine;
namespace Undisputables.DefNotHax
{
    public class Aimbot : MonoBehaviour
    {
        public static bool esp = false;
        public static bool aimbot = false;
        public static int player = 0;
        public static int TAG_ID = 0;
        public static PlayerBot[] EnemyList;
        public static AIMBOTTAG[] AimTags;
        public static AIMBOTTAG aimtarget;
        public static Transform HeadBone;
        public static GameObject Cam { get => GameObject.Find("SmoothCamera"); }
        public static void BadAimbotAttemptXD()
        {
            if (Undisputables.API.LocalPlayer.LP.isDead == false)
            {
                if (TPSCameraController.instance.TPSCameraDistance > 0) { TPSCameraController.instance.TPSCameraDistance = 0; }
                EnemyList = FindObjectsOfType<PlayerBot>(); // Find all Players "All Players are Always PlayerBot components"
                var cam1 = GameObject.Find("Managers/TPSCamera/Camera"); // Use Absolute path to Camera GameObject
                if (cam1 != null)
                {
                    foreach (PlayerBot p in EnemyList) // loop through each player
                    {
                        var pGO = p.gameObject;
                        if (pGO.GetComponent<AIMBOTTAG>() == null && p.teamIndex != API.LocalPlayer.LP.teamIndex) // if the player does not have a "AIMBOTTAG"
                        {
                            pGO.AddComponent<AIMBOTTAG>(); // then we add a new AIMBOTTAG to the Player currently active in the loop
                            aimtarget = pGO.GetComponent<AIMBOTTAG>(); // set a variable for it for easy referancing
                            aimtarget.TAG_ID = player; // set the TAG_ID to player variable 
                            player++; // increment the player variable by one each time so we dont get 2 AIMBOTTAG's that have the same ID
                        }
                    }
                    AimTags = FindObjectsOfType<AIMBOTTAG>(); // Find all our AIMBOTTAGS  
                    var dead = AimTags[TAG_ID].gameObject.GetComponent<PlayerBot>().isDead;
                    var trns = AimTags[TAG_ID].gameObject.transform.Find("AvatarPos").GetChild(0).GetChild(0).Find("Bip001 Pelvis").GetChild(2).GetChild(2).GetChild(0);
                    if (trns.name.ToLowerInvariant().Contains("head")) { HeadBone = trns; }
                    if (dead == true)
                    {
                        TAG_ID++; if (TAG_ID > AimTags.Length - 1) { TAG_ID = 0; }
                    }
                    else if (dead != true)
                    {
                        cam1.transform.LookAt(HeadBone.position); // Make the Camera look at the selected target position we just made with the Vector3
                    }
                }
            }
        }
        public static void ESP()
        {
            if (API.LocalPlayer.LP.isDead == false)
            {
                EnemyList = FindObjectsOfType<PlayerBot>();
                if (Cam.GetComponent<NDraw.Drawer>() == null) { Cam.AddComponent<NDraw.Drawer>(); }
                foreach (PlayerBot p in EnemyList)
                {
                    if (p.teamIndex != API.LocalPlayer.LP.teamIndex && p.isDead != true)
                    {
                        NDraw.Draw.World.SetColor(Color.red);
                        var pos = new Vector3(p.gameObject.transform.position.x, p.gameObject.transform.position.y + 1, p.gameObject.transform.position.z);
                        NDraw.Draw.World.Line(API.LocalPlayer.LP.gameObject.transform.position, pos);
                        NDraw.Draw.World.SetColor(Color.magenta);
                        NDraw.Draw.World.Cube(pos, new Vector3(1, 2.7f, 1), p.gameObject.transform.forward, p.gameObject.transform.up);
                    }
                }
            }
        }
        public static void Update()
        {
            if (Input.GetKeyDown(KeyCode.Y)) { esp = !esp; }
            if (Input.GetKeyDown(KeyCode.O)) { aimbot = !aimbot; }
            if (esp) { ESP(); }
            if (aimbot)
            {
                BadAimbotAttemptXD();
                if (TPSCameraController.instance.TPSCameraDistance > 0) { TPSCameraController.instance.TPSCameraDistance = 0; }
                if (API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(1).gameObject.activeSelf == true) { API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(1).gameObject.SetActive(false); }
                if (API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(2).gameObject.activeSelf == true) { API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(2).gameObject.SetActive(false); }
                if (API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).GetChild(2).GetChild(0).GetChild(0).gameObject.activeSelf == true) { API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(false); }
            }
            if (aimbot == false)
            {
                if (TPSCameraController.instance.TPSCameraDistance < 2.48f) { TPSCameraController.instance.TPSCameraDistance = 2.48f; }
                if (API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(1).gameObject.activeSelf == false) { API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(1).gameObject.SetActive(true); }
                if (API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(2).gameObject.activeSelf == false) { API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(2).gameObject.SetActive(true); }
                if (API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).GetChild(2).GetChild(0).GetChild(0).gameObject.activeSelf == false) { API.LocalPlayer.LP.gameObject.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(true); }
            }
            if (Input.GetKeyDown(KeyCode.Q)) { TAG_ID--; if (TAG_ID <= -1) { TAG_ID = 0; } }
            if (Input.GetKeyDown(KeyCode.E)) { TAG_ID++; if (TAG_ID > AimTags.Length - 1) { TAG_ID = 0; } }
        }
    }
}
