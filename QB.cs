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
        public decimal CompletionPercentage = 0;
        public int Completions = 0;
        public int PassingTDs = 0;
        public int RushingTDs = 0;
        public int Interceptions_thrown = 0;
        public decimal QB_rating = 0;
        public int Fantasy_Points = 0;

        public QB(int yards, decimal completionPercentage, int completions, int passingTDs, int rushingTDs, int interceptions_thrown, decimal qB_rating, int fantasy_Points, string name, int age, int number, int height, int weight, int minutesplayed, string college)
            : base(name, age, number, height, weight, minutesplayed, college)
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

    }

}
