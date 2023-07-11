using MultiplayerShooterKit;
using UnityEngine;
namespace Undisputables.API
{
  public class NetworkManager : MonoBehaviour
  {
    #region[API GET SET]
    #endregion
    public static NetworkManagerCustom NMC { get => NetworkManagerCustom.instance; }
    public static GameObject NetPlayerObj { get => NMC.playerPrefabs[0]; }
    public static PlayerBot NetPlayer { get => NetPlayerObj.GetComponent<PlayerBot>(); }
    public static TransformSynchronizer TransformSync { get => NetPlayerObj.GetComponent<TransformSynchronizer>(); }
    public static bool AllowRoomJoinAfterStart { get => NMC.allowRoomJoinAfterStart; set { NMC.allowRoomJoinAfterStart = value; } }
    public static int FindMatchTime { get => NMC.findingMatchTime; set { NMC.findingMatchTime = value; } }
    public static bool SyncScale { get => TransformSync.m_SynchronizeScale; set { TransformSync.m_SynchronizeScale = value; } } 
    public static string MapName { get => NMC.map; }
    public static int MaxPlayers { get => NMC.maxPlayers; set { NMC.maxPlayers = value; } }
    public static int TimeOut { get => NMC.timeOut; set { NMC.timeOut = value; } }
    public static int WaitForPlayers { get => NMC.waitingForPlayersTime; set { NMC.waitingForPlayersTime = value; } }
    #region[!!!REQUIRED API FUNCTIONS!!!]
    #endregion 
    #region[CUSTOM API FUNCTIONS]
    #endregion
  }
}
