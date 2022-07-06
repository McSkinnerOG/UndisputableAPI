using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MultiplayerShooterKit;
namespace Undisputables.API
{
    public class LocalPlayer : MonoBehaviour
    {
        #region[API GET SET]
        #endregion
        public static Player LP { get => GameManager.instance.localPlayer; } // < THIS DOES THE SAME AS BELOW THATS COMMENTED OUT
        //public static void GetLP()
        //{
        //    var pbList = FindObjectsOfType<PlayerBot>();
        //    foreach (PlayerBot p in pbList)
        //    { if (p.IsLocalPlayer() == true) { LP = p; } }
        //}
        // OR THESE
        //public static Player Localplayer;
        //public static void GetLP_Instance() { Localplayer = GameManager.instance.localPlayer; }
        //public static void GetLPFindObj() { var obj = FindObjectOfType<GameManager>(); Localplayer = obj.localPlayer; }
        public static int Ammo { get => LP.ammo; set => SetAmmo(value); } 
        public static int Deaths { get => LP.deaths; set => SetDeath(value); } 
        public static float FireRate { get => LP.fireRate; set => SetFireRate(value); }
        public static int Grade { get => LP.grade; set => SetGrade(value); }
        public static float GravityScale { get => LP.gravityScale; set => SetGravityScale(value); } 
        public static int Grenades { get => LP.grenades; set => SetGrenades(value); } 
        public static bool Grounded { get => LP.grounded; set => SetGrounded(value); } 
        public static int Health { get => LP.health; set => SetHealth(value); } 
        public static bool IsBot { get => LP.isBot; set => SetIsBot(value); }
        public static bool IsDead { get => LP.isDead; set => SetIsDead(value); }
        public static float JumpHeight { get => LP.jumpHeight; set => SetJumpHeight(value); }
        public static int Kills { get => LP.kills; set => SetKills(value); }
        public static int Mags { get => LP.mags; set => SetMags(value); }
        public static int MaxHealth { get => LP.maxHealth; set => SetMaxHealth(value); }
        public static float MoveAirMultiply { get => LP.moveAirMultiply; set => SetMoveAirScale(value); }
        public static float MoveSpeedMultiply { get => LP.ammo; set => SetMoveSpeedScale(value); }
        public static string MyName { get => LP.myName; set => SetMyName(value); }
        public static float NextFire { get => LP.nextFire; set => SetNextFire(value); } 
        public static float ReloadSpeedScale { get => LP.reloadSpeedMultiply; set => SetReloadSpeedScale(value); } 
        public static float RespawnTime { get => LP.respawnTime; set => SetRespawnTime(value); }
        public static int Shield { get => LP.shield; set => SetShield(value); }
        public static int TeamIndex { get => LP.teamIndex; set => SetTeam(value); }
        public static float ThrowGrenadeSpeedScale { get => LP.throwGrenadeSpeedMultiply; set => SetGrenadeSpeedScale(value); }
 
        #region[!!!REQUIRED API FUNCTIONS!!!]
        #endregion
        public static void SetAmmo(int amount) { LP.ammo = amount; }
        public static void SetDeath(int amount) { LP.deaths = amount; }
        public static void SetFireRate(float amount) { LP.fireRate = amount; }
        public static void SetGrade(int amount) { LP.grade = amount; }
        public static void SetGravityScale(float amount) { LP.gravityScale = amount; }
        public static void SetGrenades(int amount) { LP.grenades = amount; }
        public static void SetGrounded(bool amount) { LP.grounded = amount; }
        public static void SetHealth(int amount) { LP.health = amount; }
        public static void SetIsBot(bool amount) { LP.isBot = amount; }
        public static void SetIsDead(bool amount) { LP.isDead = amount; }
        public static void SetJumpHeight(float amount) { LP.jumpHeight = amount; }
        public static void SetKills(int amount) { LP.kills = amount; }
        public static void SetMags(int amount) { LP.mags = amount; }
        public static void SetMaxHealth(int amount) { LP.maxHealth = amount; }
        public static void SetMoveAirScale(float amount) { LP.moveAirMultiply = amount; }
        public static void SetMoveSpeed(float amount) { LP.moveSpeed = amount; }
        public static void SetMoveSpeedScale(float amount) { LP.moveSpeedMultiply = amount; }
        public static void SetMyName(string amount) { LP.myName = amount; }
        public static void SetNextFire(float amount) { LP.nextFire = amount; }
        public static void SetReloadSpeedScale(float amount) { LP.reloadSpeedMultiply = amount; }
        public static void SetRespawnTime(float amount) { LP.respawnTime = amount; }
        public static void SetShield(int amount) { LP.shield = amount; }
        public static void SetTeam(int amount) { LP.teamIndex = amount; }
        public static void SetGrenadeSpeedScale(float amount) { LP.throwGrenadeSpeedMultiply = amount; } 
        
        #region[CUSTOM API FUNCTIONS]
        #endregion
        public static void DoAction(int i) { LP.DoActionEvent(i); } 
        public static void ThrowGrenade() { LP.DoActionEvent(2); }
        public static void ResetAmmo() { LP.DoActionEvent(3); }
    } 
} 