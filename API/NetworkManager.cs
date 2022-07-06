﻿using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace NotHaxPwomise.API
{
    public class NetworkManager : MonoBehaviour
    {
        #region[API GET SET]
        #endregion 
        public static NetworkManagerCustom NMC { get => NetworkManagerCustom.instance; }
        public static bool allowRoomJoinAfterStart { get => NMC.allowRoomJoinAfterStart; set => SetAllowJoinAfterStart(value); }
        public static int findMatchTime { get => NMC.findingMatchTime; set => SetFindMatchTime(value); }
        public static string map { get => NMC.map; }
        public static int maxPlayers { get => NMC.maxPlayers; set => SetMaxPlayers(value); }
        public static int timeOut { get => NMC.maxPlayers; set => SetTimeOut(value); }
        public static int waitForPlayers { get => NMC.maxPlayers; set => SetWaitForPlayers(value); }
        #region[!!!REQUIRED API FUNCTIONS!!!]
        #endregion
        public static void SetAllowJoinAfterStart(bool value) { allowRoomJoinAfterStart = value; }
        public static void SetFindMatchTime(int value) { findMatchTime = value; }
        public static void SetMaxPlayers(int value) { maxPlayers = value; }
        public static void SetTimeOut(int value) { timeOut = value; }
        public static void SetWaitForPlayers(int value) { waitForPlayers = value; }
        #region[CUSTOM API FUNCTIONS]
        #endregion 
        
    }
}