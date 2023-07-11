using MultiplayerShooterKit;
using UnityEngine;
namespace Undisputables.DefNotHax
{
  public class AIMBOTTAG : MonoBehaviour
  {
    public int TAG_ID;
    public bool IS_DEAD { get => this.gameObject.GetComponent<PlayerBot>().isDead; }


  }
}
