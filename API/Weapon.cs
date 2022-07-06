using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I THINK WE DONE!!!!!!!!!
namespace Undisputables.API
{
    public class Weapon
    {
        #region[API GET SET]
        #endregion 
        public static float Aim { get => LocalPlayer.LP.myWeapon.properties.aim; set => SetAim(value); }
        public static int Ammo { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetAmmo(value); }
        public static float BulletMobility { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetBulletMobility(value); }
        public static float Damage { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetDamage(value); }
        public static float FireRate { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetFireRate(value); }
        public static int Mags { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetMags(value); }
        public static float Mobility { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetMobilty(value); }
        public static float Range { get => LocalPlayer.LP.myWeapon.properties.ammo; set => SetRange(value); }
        #region[!!!REQUIRED API FUNCTIONS!!!]
        #endregion 
        public static void SetAim(float value) { LocalPlayer.LP.myWeapon.properties.aim = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetAmmo(int value) { LocalPlayer.LP.myWeapon.properties.ammo = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetBulletMobility(float value) { LocalPlayer.LP.myWeapon.properties.bullet_mobility = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetDamage(float value) { LocalPlayer.LP.myWeapon.properties.damage = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetFireRate(float value) { LocalPlayer.LP.myWeapon.properties.fireRate = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetMags(int value) { LocalPlayer.LP.myWeapon.properties.mags = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetMobilty(float value) { LocalPlayer.LP.myWeapon.properties.mobility = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        public static void SetRange(float value) { LocalPlayer.LP.myWeapon.properties.range = value; LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP); }
        #region[CUSTOM API FUNCTIONS]
        #endregion 
        public static void UpdateWeapon(float aim, int ammo, float bulletMobility, float damage, float fireRate, int mags, float mobility, float range)
        {
            Aim = aim; Ammo = ammo; BulletMobility = bulletMobility; Damage = damage; FireRate = fireRate; Mags = mags; Mobility = mobility; Range = range;
            LocalPlayer.LP.myWeapon.Apply(LocalPlayer.LP);
        }
    }
}
