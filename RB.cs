using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class RB : Player
    {
        public int Rushing_Attempts = 0;
        public int Rushing_Yards = 0;
        public int Rushing_TDs = 0;
        public int Receptions = 0;
        public int Fumbles = 0;
        public int Fantasy_Points = 0;

        public RB(int rushing_attempts, int rushing_yards, int rushing_tds, int receptions, int fumbles, int fantasy_Points, string name, string position, int age, int number, string height, int weight, string college)
        : base(name, position, age, number, height, weight, college)
        {
            this.Rushing_Attempts = rushing_attempts;
            this.Rushing_Yards = rushing_yards;
            this.Rushing_TDs = rushing_tds;
            this.Receptions = receptions;
            this.Fumbles = fumbles;
            this.Fantasy_Points = fantasy_Points;
        }
    }
}
