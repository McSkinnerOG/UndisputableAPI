using UnityEngine; 
namespace Undisputables.API
{
  public class Weapon : MonoBehaviour
  {
    #region[API GET SET]
    #endregion 
    public static MultiplayerShooterKit.Weapon MyWeapon 
    { 
      get { return Players.LocalPlayer.myWeapon; } 
    }
    public static float Aim
    {
      get { return MyWeapon.properties.aim; }
      set { MyWeapon.properties.aim = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static int Ammo
    {
      get { return MyWeapon.properties.ammo; }
      set { MyWeapon.properties.ammo = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static float BulletMobility
    {
      get { return MyWeapon.properties.bullet_mobility; }
      set { MyWeapon.properties.bullet_mobility = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static float Damage
    {
      get { return MyWeapon.properties.damage; }
      set { MyWeapon.properties.damage = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static float FireRate
    {
      get { return MyWeapon.properties.fireRate; }
      set { MyWeapon.properties.fireRate = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static int Mags
    {
      get { return MyWeapon.properties.mags; }
      set { MyWeapon.properties.mags = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static float Mobility
    {
      get { return MyWeapon.properties.mobility; }
      set { MyWeapon.properties.mobility = value; MyWeapon.Apply(Players.LocalPlayer); }
    }
    public static float Range
    {
      get { return MyWeapon.properties.range; }
      set { MyWeapon.properties.range = value; MyWeapon.Apply(Players.LocalPlayer); }
    }

    #region[!!!REQUIRED API FUNCTIONS!!!]
    #endregion 
    #region[CUSTOM API FUNCTIONS]
    #endregion
    public static void UpdateWeapon(float aim, int ammo, float bulletMobility, float damage, float fireRate, int mags, float mobility, float range)
    {
      Aim = aim; Ammo = ammo; BulletMobility = bulletMobility; Damage = damage; FireRate = fireRate; Mags = mags; Mobility = mobility; Range = range;
      MyWeapon.Apply(Players.LocalPlayer);
    }












































  }
}
