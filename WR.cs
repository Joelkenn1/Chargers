using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class WR : Player
    {
        public int Catches = 0;
        public int Yards = 0;
        public int Yards_After_Catch = 0;
        public int Touchdowns = 0;
        public int Fumbles = 0;
        public int Fantasy_Points = 0;

        public WR(int catches, int yards, int yards_after_catch, int touchdowns, int fumbles, int fantasy_Points, string name,  string position, int age, int number, string height, int weight, string college)
        : base(name, position, age, number, height, weight, college)
        {
            this.Catches = catches;
            this.Yards = yards;
            this.Yards_After_Catch = yards_after_catch;
            this.Touchdowns = touchdowns;
            this.Fumbles = fumbles;
            this.Fantasy_Points = fantasy_Points;
        }
    }

}

