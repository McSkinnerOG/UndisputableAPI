using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Undisputables.DefNotHax
{
    public class AIMBOTTAG : MonoBehaviour
    {
        public int TAG_ID;
        public bool IS_DEAD { get => this.gameObject.GetComponent<PlayerBot>().isDead; }


    }
}
