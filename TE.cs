using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TE : Player
    {
        public int Catches = 0;
        public int Yards = 0;
        public int Yards_After_Catch = 0;
        public int Touchdowns = 0;
        public int Fumbles = 0;
        public int Fantasy_Points = 0;

        public TE(int catches, int yards, int yards_after_catch, int touchdowns, int fumbles, int fantasy_Points, string name,  string position, int age, int number, string height, int weight, string college)
        : base(name, position, age, number, height, weight, college)
        {
            this.Catches = catches;
            this.Yards = yards;
            this.Yards_After_Catch = yards_after_catch;
            this.Touchdowns = touchdowns;
            this.Fumbles = fumbles;
            this.Fantasy_Points = fantasy_Points;
        }
        public int Rec{
            get{return Catches;}
            set{Catches = value;}
        }
        public int Yds{
            get{return Yards;}
            set{Yards = value;}
        }
        public int YAC{
            get{return Yards_After_Catch;}
            set{Yards_After_Catch = value;}
        }
        public int TDs{
            get{return Touchdowns;}
            set{Touchdowns = value;}
        }
        public int Fmbs{
            get{return Fumbles;}
            set{Fumbles = value;}
        }
        public int FP{
            get{return Fantasy_Points;}
            set{Fantasy_Points = value;}
        }
        
        
        
    }

}
