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
        public int Targets = 0;
        public int Fumbles = 0;
        public int Fantasy_Points = 0;
        public WR(int catches, int yards, int yards_after_catch, int touchdowns, int targets, int fumbles, int fantasy_Points, string name, int age, int number, int height, int weight, int minutesplayed, string college)
        : base(name, age, number, height, weight, minutesplayed, college)
        {
            this.Catches = catches;
            this.Yards = yards;
            this.Yards_After_Catch = yards_after_catch;
            this.Touchdowns = touchdowns;
            this.Targets = targets;
            this.Fumbles = fumbles;
            this.Fantasy_Points = fantasy_Points;
        }
    }
    
}


