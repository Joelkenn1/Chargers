using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class LB : Player
    {
        public int Interceptions_caught = 0;
        public int Tackels = 0;
        public int Tackle_Assists = 0;
        public int Defensive_Touchdowns = 0;
        public int Fumbles_Caused = 0;
        public int Fumble_Recoveries = 0;
        public int Sacks = 0;
        public int Fantasy_Points = 0;

        public LB(int interceptions_caught, int tackels, int tackle_Assists, int defensive_Touchdowns, int fumbles_Caused, int fumble_Recoveries, int sacks, int fantasy_Points, string name, int age, int number, int height, int weight, int minutesplayed, string college)
          : base(name, age, number, height, weight, minutesplayed, college)
        {
            this.Interceptions_caught = interceptions_caught;
            this.Tackels = tackels;
            this.Tackle_Assists = tackle_Assists;
            this.Defensive_Touchdowns = defensive_Touchdowns;
            this.Fumbles_Caused = fumbles_Caused;
            this.Fumble_Recoveries = fumble_Recoveries;
            this.Sacks = sacks;
            this.Fantasy_Points = fantasy_Points;
        }
    }
}

