using MultiplayerShooterKit;
using UnityEngine;
namespace Undisputables.API
{
  public class Players : MonoBehaviour
  {
    #region[API GET SET]
    #endregion
     
    public static Player LocalPlayer { get => GameManager.instance.localPlayer; }
    public static int Ammo { get => LocalPlayer.ammo; set => LocalPlayer.ammo = value; }
    public static int Deaths { get => LocalPlayer.deaths; set => LocalPlayer.deaths = value; }
    public static float FireRate { get => LocalPlayer.fireRate; set => LocalPlayer.fireRate = value; }
    public static int Grade { get => LocalPlayer.grade; set => LocalPlayer.grade = value; }
    public static float GravityScale { get => LocalPlayer.gravityScale; set => LocalPlayer.gravityScale = value; }
    public static int Grenades { get => LocalPlayer.grenades; set => LocalPlayer.grenades = value; }
    public static bool Grounded { get => LocalPlayer.grounded; set => LocalPlayer.grounded = value; }
    public static int Health { get => LocalPlayer.health; set => LocalPlayer.health = value; }
    public static bool IsBot { get => LocalPlayer.isBot; set => LocalPlayer.isBot = value; }
    public static bool IsDead { get => LocalPlayer.isDead; set => LocalPlayer.isDead = value; }
    public static float JumpHeight { get => LocalPlayer.jumpHeight; set => LocalPlayer.jumpHeight = value; }
    public static int Kills { get => LocalPlayer.kills; set => LocalPlayer.kills = value; }
    public static int Mags { get => LocalPlayer.mags; set => LocalPlayer.mags = value; }
    public static int MaxHealth { get => LocalPlayer.maxHealth; set => LocalPlayer.maxHealth = value; }
    public static float MoveAirMultiply { get => LocalPlayer.moveAirMultiply; set => LocalPlayer.moveAirMultiply = value; }
    public static float MoveSpeedMultiply { get => LocalPlayer.moveSpeedMultiply; set => LocalPlayer.moveSpeedMultiply = value; }
    public static string MyName { get => LocalPlayer.myName; set => LocalPlayer.myName = value; }
    public static float NextFire { get => LocalPlayer.nextFire; set => LocalPlayer.nextFire = value; }
    public static float ReloadSpeedScale { get => LocalPlayer.reloadSpeedMultiply; set => LocalPlayer.reloadSpeedMultiply = value; }
    public static float RespawnTime { get => LocalPlayer.respawnTime; set => LocalPlayer.respawnTime = value; }
    public static int Shield { get => LocalPlayer.shield; set => LocalPlayer.shield = value; }
    public static int TeamIndex { get => LocalPlayer.teamIndex; set => LocalPlayer.teamIndex = value; }
    public static float ThrowGrenadeSpeedScale { get => LocalPlayer.throwGrenadeSpeedMultiply; set => LocalPlayer.throwGrenadeSpeedMultiply = value; }

    #region[ DEFAULT API FUNCTIONS ]
    #endregion 

    #region[CUSTOM API FUNCTIONS]
    #endregion
    public static void DoAction(int i) { LocalPlayer.DoActionEvent(i); }
    public static void ThrowGrenade() { LocalPlayer.DoActionEvent(2); }
    public static void ResetAmmo() { LocalPlayer.DoActionEvent(3); }
  }
}