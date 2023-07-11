using MultiplayerShooterKit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
// I THINK WE DONE!!!!!!!!!
namespace Undisputables.API
{
    public class Weapon : MonoBehaviour
    {
        #region[API GET SET]
        #endregion 


        public static MultiplayerShooterKit.Weapon MyWeapon { get => LocalPlayer.LP.myWeapon; } 
        public static float Aim { get => MyWeapon.properties.aim; set => SetAim(value); }
        public static int Ammo { get => MyWeapon.properties.ammo; set => SetAmmo(value); }
        public static float BulletMobility { get => MyWeapon.properties.ammo; set => SetBulletMobility(value); }
        public static float Damage { get => MyWeapon.properties.ammo; set => SetDamage(value); }
        public static float FireRate { get => MyWeapon.properties.ammo; set => SetFireRate(value); }
        public static int Mags { get => MyWeapon.properties.ammo; set => SetMags(value); }
        public static float Mobility { get => MyWeapon.properties.ammo; set => SetMobilty(value); }
        public static float Range { get => MyWeapon.properties.ammo; set => SetRange(value); }
        
        #region[!!!REQUIRED API FUNCTIONS!!!]
        #endregion
        public static void SetAim(float value) { MyWeapon.properties.aim = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetAmmo(int value) { MyWeapon.properties.ammo = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetBulletMobility(float value) { MyWeapon.properties.bullet_mobility = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetDamage(float value) { MyWeapon.properties.damage = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetFireRate(float value) { MyWeapon.properties.fireRate = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetMags(int value) { MyWeapon.properties.mags = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetMobilty(float value) { MyWeapon.properties.mobility = value; MyWeapon.Apply(LocalPlayer.LP); }
        public static void SetRange(float value) { MyWeapon.properties.range = value; MyWeapon.Apply(LocalPlayer.LP); }
        #region[CUSTOM API FUNCTIONS]
        #endregion 
        public static void UpdateWeapon(float aim, int ammo, float bulletMobility, float damage, float fireRate, int mags, float mobility, float range)
        {
            Aim = aim; Ammo = ammo; BulletMobility = bulletMobility; Damage = damage; FireRate = fireRate; Mags = mags; Mobility = mobility; Range = range;
            MyWeapon.Apply(LocalPlayer.LP);
        }









       


































    }
}
