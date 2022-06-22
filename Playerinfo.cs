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
        public string Position;
        public string Age;
        public int Number;
        public string Height;
        public int Weight;
        public string College;
        public string Accolades;

        public Player(string name, string position, string age, int number, string height, int weight, string college, string accolades)
        {
            this.Name = name;
            this.Position = position;
            this.Age = age;
            this.Number = number;
            this.Height = height;
            this.Weight = weight;
            this.College = college;
            this.Accolades = accolades;
        }
        public string Playername
        {
            get { return Name; }
            set { Name = value; }
        }

        public string PlayerPosition
        {
            get { return Position; }
            set { Position = value; }
        }

        public string PlayerAge
        {
            get { return Age; }
            set { Age = value; }
        }

        public int PlayerNumber
        {
            get { return Number; }
            set { Number = value; }
        }

        public string PlayerHeight
        {
            get { return Height; }
            set { Height = value; }
        }

        public int PlayerWeight
        {
            get { return Weight; }
            set { Weight = value; }
        }

        public string PlayerCollege
        {
            get { return College; }
            set { College = value; }
        }

        public string PlayerAccolades
        {
            get { return Accolades; }
            set { Accolades = value; }
        }


    }

}
