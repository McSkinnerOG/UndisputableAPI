using MultiplayerShooterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace NotHaxPwomise.API
{
    public class GameManagerCustom
    {
        #region[API GET SET]
        #endregion 
        public static GameManager GameManager { get => GameManager.instance; }
        public static float aimSensitivity { get => GameManager.aimSensibility; set => SetAimSensitivity(value); }
        public static float aimZoom { get => GameManager.aimZoom; set => SetAimZoom(value); }
        public static Color enemyColor { get => GameManager.enemyColor; set => SetEnemyColor(value); }
        public static Color friendColor { get => GameManager.friendColor; set => SetFriendlyColor(value); }
        public static bool friendlyFire { get => GameManager.friendlyFire; set => SetFriendlyFire(value); }
        public static GameMode gameMode { get => GameManager.gameMode; set => SetGameMode(value); }
        public static GameStatus gameStatus { get => GameManager.gameStatus; set => SetGameStatus(value); }
        public static bool holdToAim { get => GameManager.holdToAim; set => SetHoldToAim(value); }
        public static int looserTeamRewardCoins { get => GameManager.looserTeamRewardCoins; set => SetLooserTeamReward(value); }
        public static GameObject MapCamera { get => GameManager.mapCamera; set => SetMapCamera(value); }
        public static int matchTime { get => GameManager.matchTime; set => SetMatchTime(value); }
        public static int maxScore { get => GameManager.maxScore; set => SetMaxScore(value); }
        public static float normalZoom { get => GameManager.normalZoom; set => SetNormalZoom(value); }
        public static int readyTime { get => GameManager.readyTime; set => SetReadyTime(value); }
        public static int respawnTime { get => GameManager.respawnTime; set => SetRespawnTime(value); }
        public static int rewardCoins { get => GameManager.rewardCoins; set => SetRewardCoins(value); }
        public static float shootSensitivity { get => GameManager.shootSensibility; set => SetShootSensitivity(value); }
        public static int showKillScoreTime { get => GameManager.showKillScoreTime; set => SetShowKillScoreTime(value); }
        public static LayerMask spawnMask { get => GameManager.spawnMask; set => SetSpawnMask(value); }
        public static Team[] Teams { get => GameManager.teams; set => SetTeams(value); }
        public static int winnerTeamRewardCoins { get => GameManager.winnerTeamRewardCoins; set => SetWinnerTeamRewardCoins(value); }
        #region[!!!REQUIRED API FUNCTIONS!!!]
        #endregion
        public static void SetAimSensitivity(float value) { GameManager.aimSensibility = value; }
        public static void SetAimZoom(float value) { GameManager.aimSensibility = value; }
        public static void SetEnemyColor(Color value) { GameManager.enemyColor = value; }
        public static void SetFriendlyColor(Color value) { GameManager.friendColor = value; }
        public static void SetFriendlyFire(bool value) { GameManager.friendlyFire = value; }
        public static void SetGameMode(GameMode value) { GameManager.gameMode = value; }
        public static void SetGameStatus(GameStatus value) { GameManager.gameStatus = value; }
        public static void SetHoldToAim(bool value) { GameManager.holdToAim = value; }
        public static void SetLooserTeamReward(int value) { GameManager.looserTeamRewardCoins = value; }
        public static void SetMapCamera(GameObject value) { GameManager.mapCamera = value; }
        public static void SetMatchTime(int value) { GameManager.matchTime = value; }
        public static void SetMaxScore(int value) { GameManager.maxScore = value; }
        public static void SetNormalZoom(float value) { GameManager.normalZoom = value; }
        public static void SetReadyTime(int value) { GameManager.readyTime = value; }
        public static void SetRespawnTime(int value) { GameManager.respawnTime = value; }
        public static void SetRewardCoins(int value) { GameManager.rewardCoins = value; }
        public static void SetShootSensitivity(float value) { GameManager.shootSensibility = value; }
        public static void SetShowKillScoreTime(int value) { GameManager.showKillScoreTime = value; }
        public static void SetSpawnMask(int value) { GameManager.spawnMask = value; }
        public static void SetTeams(Team[] value) { GameManager.teams = value; }
        public static void SetWinnerTeamRewardCoins(int value) { GameManager.winnerTeamRewardCoins = value; }
        #region[CUSTOM API FUNCTIONS]
        #endregion
        public void MoveTeamSpawnpoints(int teamID, Vector3 spawn1, Vector3 spawn2, Vector3 spawn3, Vector3 spawn4)
        {
            Teams[teamID].spawns[0].position = spawn1;
            Teams[teamID].spawns[1].position = spawn2;
            Teams[teamID].spawns[2].position = spawn3;
            Teams[teamID].spawns[3].position = spawn4;
        }
        public void MoveSingleSpawnpoint(int teamID, int spawnID, Vector3 spawn1)
        { Teams[teamID].spawns[spawnID].position = spawn1; }

        public void SetTeamNames(string team1, string team2) { Teams[0].name = team1; Teams[1].name = team2; }
        public void SetTeamColors(Color team1, Color team2) { Teams[0].color = team1; Teams[1].color = team2; }
        public static void Update()
        {

        }
    }
}