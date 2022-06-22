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

        public RB(int rushing_attempts, int rushing_yards, int rushing_tds, int receptions, int fumbles, int fantasy_Points, string name, string position, string age, int number, string height, int weight, string college, string accolades)
        : base(name, position, age, number, height, weight, college, accolades)
        {
            this.Rushing_Attempts = rushing_attempts;
            this.Rushing_Yards = rushing_yards;
            this.Rushing_TDs = rushing_tds;
            this.Receptions = receptions;
            this.Fumbles = fumbles;
            this.Fantasy_Points = fantasy_Points;
        }
        public int Rushatt
        {
            get { return Rushing_Attempts; }
            set { Rushing_Attempts = value; }
        }
        public int RushYds
        {
            get { return Rushing_Yards; }
            set { Rushing_Yards = value; }
        }
        public int RushTDs
        {
            get { return Rushing_TDs; }
            set { Rushing_TDs = value; }
        }
        public int Rec
        {
            get { return Receptions; }
            set { Receptions = value; }
        }

        public int Fmbs
        {
            get { return Fumbles; }
            set { Fumbles = value; }
        }
        public int FP
        {
            get { return Fantasy_Points; }
            set { Fantasy_Points = value; }
        }
    }
}
