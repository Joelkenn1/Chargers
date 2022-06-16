using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Player
    {
        public string Name;
        public int Age;
        public int Number;
        public int Height;
        public int Weight;
        public string College;

        public Player(string name, int age, int number, int height, int weight, string college)
        {
            this.Name = name;
            this.Age = age;
            this.Number = number;
            this.Height = height;
            this.Weight = weight;
            this.College = college;
        }
        public string Playername
        {
            get { return Name; } set {Name = value; } 
        }

        public int PlayerAge
        {
            get { return Age; } set { Age = value; }
        }

        public int PlayerNumber
        {
            get { return Number; } set { Number = value; }
        }

        public int PlayerHeight
        {
            get { return Height; } set { Height = value; }
        }

        public int PlayerWeight
        {
            get { return Weight; } set { Weight = value; }
        }

        public string PlayerCollege
        {
            get { return College; } set { College = value; }
        }



    }

    }
