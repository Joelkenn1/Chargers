using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class QB : Player
    {
        public int Yards = 0;
        public int CompletionPercentage = 0;
        public int Completions = 0;
        public int PassingTDs = 0;
        public int RushingTDs = 0;
        public int Interceptions_thrown = 0;
        public int QB_rating = 0;
        public int Fantasy_Points = 0;

        public QB(int yards, int completionPercentage, int completions, int passingTDs, int rushingTDs, int interceptions_thrown, int qB_rating, int fantasy_Points, string name, string position, string age, int number, string height, int weight, string college, string accolades)
            : base(name, position, age, number, height, weight, college, accolades)
        {
            this.Yards = yards;
            this.CompletionPercentage = completionPercentage;
            this.Completions = completions;
            this.PassingTDs = passingTDs;
            this.RushingTDs = rushingTDs;
            this.Interceptions_thrown = interceptions_thrown;
            this.QB_rating = qB_rating;
            this.Fantasy_Points = fantasy_Points;
        }
        public int PassYDs
        {
            get { return Yards; }
            set { Yards = value; }
        }

        public int CmpPc
        {
            get { return CompletionPercentage; }
            set { CompletionPercentage = value; }
        }
        public int Cmps
        {
            get { return Completions; }
            set { Completions = value; }
        }
        public int PassTDs
        {
            get { return PassingTDs; }
            set { PassingTDs = value; }
        }
        public int QBRushTDS
        {
            get { return RushingTDs; }
            set { RushingTDs = value; }
        }
        public int QBInt
        {
            get { return Interceptions_thrown; }
            set { Interceptions_thrown = value; }
        }
        public int Rating
        {
            get { return QB_rating; }
            set { QB_rating = value; }
        }
        public int FP
        {
            get { return Fantasy_Points; }
            set { Fantasy_Points = value; }
        }








    }

}
