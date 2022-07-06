using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotHaxPwomise.DefNotHax
{
    public class NetworkManager
    {
        public static void Update()
        {
            if (API.NetworkManager.NMC.maxPlayers < 11)
            {
                API.NetworkManager.NMC.maxPlayers = 64; 
                API.NetworkManager.NMC.findingMatchTime = 10;
                API.NetworkManager.NMC.waitingForPlayersTime = 20;
            }
        }
    }
}
