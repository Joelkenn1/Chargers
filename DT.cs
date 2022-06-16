using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class DT : Player
    {
        public int Tackels = 0;
        public int Tackle_Assists = 0;
        public int Fumbles_Caused = 0;
        public int Fumble_Recoveries = 0;
        public int Sacks = 0;
        public int Fantasy_Points = 0;

        public DT(int tackels, int tackle_Assists, int fumbles_Caused, int fumble_Recoveries, int sacks, int fantasy_Points, string name, string position, int age, int number, string height, int weight, string college)
            : base(name, position, age, number, height, weight, college)
        {

            this.Tackels = tackels;
            this.Tackle_Assists = tackle_Assists;
            this.Fumbles_Caused = fumbles_Caused;
            this.Fumble_Recoveries = fumble_Recoveries;
            this.Sacks = sacks;
            this.Fantasy_Points = fantasy_Points;
        }
    }
}
