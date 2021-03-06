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


        public LB(int interceptions_caught, int tackels, int tackle_Assists, int defensive_Touchdowns, int fumbles_Caused, int fumble_Recoveries, int sacks, string name, string position, string age, int number, string height, int weight, string college, string accolades)
          : base(name, position, age, number, height, weight, college, accolades)
        {
            this.Interceptions_caught = interceptions_caught;
            this.Tackels = tackels;
            this.Tackle_Assists = tackle_Assists;
            this.Defensive_Touchdowns = defensive_Touchdowns;
            this.Fumbles_Caused = fumbles_Caused;
            this.Fumble_Recoveries = fumble_Recoveries;
            this.Sacks = sacks;

        }
        public int DBInt
        {
            get { return Interceptions_caught; }
            set { Interceptions_caught = value; }
        }
        public int Tkls
        {
            get { return Tackels; }
            set { Tackels = value; }
        }
        public int TklAsst
        {
            get { return Tackle_Assists; }
            set { Tackle_Assists = value; }
        }
        public int DefTDs
        {
            get { return Defensive_Touchdowns; }
            set { Defensive_Touchdowns = value; }
        }
        public int FumC
        {
            get { return Fumbles_Caused; }
            set { Fumbles_Caused = value; }
        }
        public int FumR
        {
            get { return Fumble_Recoveries; }
            set { Fumble_Recoveries = value; }
        }
        public int Sks
        {
            get { return Sacks; }
            set { Sacks = value; }
        }
    }
}
