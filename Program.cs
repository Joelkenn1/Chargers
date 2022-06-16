using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("All-time Chargers Players:");


            QB qb1 = new QB(9350, 66, 839, 69, 8, 25, 65, 22, "Justin Herbert", "QB", 23, 10, "6 - 6", 237, "Oregon");
            {
                Console.WriteLine($"{qb1.Playername}({qb1.PlayerPosition})");

            }

            QB qb2 = new QB(63440, 64, 5277, 421, 3, 209, 77, 16, "Philip Rivers", "QB", 29, 17, "6 - 5", 228, "NC State");
            {
                Console.WriteLine($"{qb2.Playername}({qb2.PlayerPosition})");
            }

            RB rb1 = new RB(3174, 13684, 145, 624, 31, 22, "LaDainian Tomlinson", "RB", 27, 21, "5 - 10", 215, "TCU");
            {
                Console.WriteLine($"{rb1.Playername}({rb1.PlayerPosition})");
            }

            RB rb2 = new RB(607, 2812, 21, 282, 11, 13, "Austin Ekeler", "RB", 26, 30, "5 - 10", 200, "Western St.");
            {
                Console.WriteLine($"{rb2.Playername}({rb2.PlayerPosition})");
            }

            TE te1 = new TE(541, 6741, 13, 45, 11, 12, "Kellen Winslow", "TE", 23, 80, "6 - 5", 251, "Missouri");
            {
                Console.WriteLine($"{te1.Playername}({te1.PlayerPosition})");
            }

            TE te2 = new TE(246, 2925, 12, 30, 2, 6, "Hunter Henry", "TE", 27, 86, "6 - 5", 250, "Arkansas");
            {
                Console.WriteLine($"{te2.Playername}({te2.PlayerPosition})");
            }

            WR wr1 = new WR(542, 10266, 19, 85, 5, 0, "Lance Alworth", "WR", 26, 19, "6 - 0", 184, "Arkansas");
            {
                Console.WriteLine($"{wr1.Playername}({wr1.PlayerPosition})");
            }

            WR wr2 = new WR(730, 8535, 12, 48, 13, 10, "Keenan Allen", "WR", 30, 13, "6 - 2", 211, "California");
            {
                Console.WriteLine($"{wr2.Playername}({wr2.PlayerPosition})");
            }

            CB cb1 = new CB(21, 631, 104, 1, 7, 10, 0, 0, "Quentin Jammer", "CB", 27, 23, "6 - 0", 204, "Texas");
            {
                Console.WriteLine($"{cb1.Playername}({cb1.PlayerPosition})");
            }

            CB cb2 = new CB(24, 362, 69, 1, 2, 4, 0, 0, "Casey Hayward", "CB", 32, 26, "5 - 11", 192, "Vanderbilt");
            {
                Console.WriteLine($"{cb2.Playername}({cb2.PlayerPosition})");
            }

            LB lb1 = new LB(18, 1077, 325, 1, 11, 18, 59, 0, "Junior Seau", "LB", 24, 55, "6 - 3", 250, "USC");
            {
                Console.WriteLine($"{lb1.Playername}({lb1.PlayerPosition})");
            }

            LB lb2 = new LB(3, 277, 108, 0, 15, 7, 51, 0, "Melvin Ingram", "LB", 32, 54, "6 - 2", 247, "South Carolina");
            {
                Console.WriteLine($"{lb2.Playername}({lb2.PlayerPosition})");
            }

            S s1 = new S(34, 920, 286, 2, 15, 9, 31, 0, "Rodney Harrison", "S", 29, 37, "6 - 1", 220, "Western Illinois");
            {
                Console.WriteLine($"{s1.Playername}({s1.PlayerPosition})");
            }

            S s2 = new S(5, 173, 84, 0, 3, 0, 6, 0, "Derwin James", "S", 25, 33, "6 - 2", 215, "Florida State");
            {
                Console.WriteLine($"{s2.Playername}({s2.PlayerPosition})");
            }

            DT dt1 = new DT(98, 1, 4, 3, 13, 0, "Jamal Williams", "DT", 29, 76, "6 - 3", 348, "Oklahoma State");
            {
                Console.WriteLine($"{dt1.Playername}({dt1.PlayerPosition})");
            }

            DE de1 = new DE(78, 0, 13, 3, 58, 0, "Joey Bosa", "DE", 26, 97, "6 - 5", 280, "Ohio");
            {
                Console.WriteLine($"{de1.Playername}({de1.PlayerPosition})");
            }

            DE de2 = new DE(67, 1, 21, 16, 133, 0, "Leslie O'Neal", "DE", 31, 91, "6 - 4", 275, "Oklahoma State");
            {
                Console.WriteLine($"{de2.Playername}({de2.PlayerPosition})");
            }



            string Question = Console.ReadLine();
            bool loop = true;
            while (loop)
            {

                if (Question == "About Justin Herbert")
                {
                    Console.WriteLine($" Name:{qb1.Playername}, Position:{qb1.PlayerPosition}, Age:{qb1.PlayerAge}, Number:{qb1.PlayerNumber}, Height: {qb1.PlayerHeight}, Weight: {qb1.PlayerWeight}, College: {qb1.PlayerCollege}");
                    
                }
                else if (Question == "About Philip Rivers")
                {
                    Console.WriteLine($" Name:{qb2.Playername}, Position:{qb2.PlayerPosition}, Age:{qb2.PlayerAge}, Number:{qb2.PlayerNumber}, Height: {qb2.PlayerHeight}, Weight: {qb2.PlayerWeight}, College: {qb2.PlayerCollege}");
                     
                }
                else if (Question == "About LaDainian Tomlinson")
                {
                    Console.WriteLine($" Name:{rb1.Playername}, Position:{rb1.PlayerPosition}, Age:{rb1.PlayerAge}, Number:{rb1.PlayerNumber}, Height: {rb1.PlayerHeight}, Weight: {rb1.PlayerWeight}, College: {rb1.PlayerCollege}");
                     
                    
                }
                else if (Question == "About Austin Ekeler")
                {
                    Console.WriteLine($" Name:{rb2.Playername}, Position:{rb2.PlayerPosition}, Age:{rb2.PlayerAge}, Number:{rb2.PlayerNumber}, Height: {rb2.PlayerHeight}, Weight: {rb2.PlayerWeight}, College: {rb2.PlayerCollege}");
                     
                }
                else if (Question == "About Kellen Winslow")
                {
                    Console.WriteLine($" Name:{te1.Playername}, Position:{te1.PlayerPosition}, Age:{te1.PlayerAge}, Number:{te1.PlayerNumber}, Height: {te1.PlayerHeight}, Weight: {te1.PlayerWeight}, College: {te1.PlayerCollege}");
                     
                }
                else if (Question == "About Hunter Henry")
                {
                    Console.WriteLine($" Name:{te2.Playername}, Position:{te2.PlayerPosition}, Age:{te2.PlayerAge}, Number:{te2.PlayerNumber}, Height: {te2.PlayerHeight}, Weight: {te2.PlayerWeight}, College: {te2.PlayerCollege}");
                     
                }
                else if (Question == "About Lance Alworth")
                {
                    Console.WriteLine($" Name:{wr1.Playername}, Position:{wr1.PlayerPosition}, Age:{wr1.PlayerAge}, Number:{wr1.PlayerNumber}, Height: {wr1.PlayerHeight}, Weight: {wr1.PlayerWeight}, College: {wr1.PlayerCollege}");
                     
                }
                else if (Question == "About Keenan Allen")
                {
                    Console.WriteLine($" Name:{wr2.Playername}, Position:{wr2.PlayerPosition}, Age:{wr2.PlayerAge}, Number:{wr2.PlayerNumber}, Height: {wr2.PlayerHeight}, Weight: {wr2.PlayerWeight}, College: {wr2.PlayerCollege}");
                     
                }
                else if (Question == "About Quentin Jammer")
                {
                    Console.WriteLine($" Name:{cb1.Playername}, Position:{cb1.PlayerPosition}, Age:{cb1.PlayerAge}, Number:{cb1.PlayerNumber}, Height: {cb1.PlayerHeight}, Weight: {cb1.PlayerWeight}, College: {cb1.PlayerCollege}");
                     
                }
                else if (Question == "About Casey Hayward")
                {
                    Console.WriteLine($" Name:{cb2.Playername}, Position:{cb2.PlayerPosition}, Age:{cb2.PlayerAge}, Number:{cb2.PlayerNumber}, Height: {cb2.PlayerHeight}, Weight: {cb2.PlayerWeight}, College: {cb2.PlayerCollege}");
                     
                }
                else if (Question == "About Junior Seau")
                {
                    Console.WriteLine($" Name:{lb1.Playername}, Position:{lb1.PlayerPosition}, Age:{lb1.PlayerAge}, Number:{lb1.PlayerNumber}, Height: {lb1.PlayerHeight}, Weight: {lb1.PlayerWeight}, College: {lb1.PlayerCollege}");
                     
                }
                else if (Question == "About Melvin Ingram")
                {
                    Console.WriteLine($" Name:{lb2.Playername}, Position:{lb2.PlayerPosition}, Age:{lb2.PlayerAge}, Number:{lb2.PlayerNumber}, Height: {lb2.PlayerHeight}, Weight: {lb2.PlayerWeight}, College: {lb2.PlayerCollege}");
                     
                }
                else if (Question == "About Rodney Harrison")
                {
                    Console.WriteLine($" Name:{s1.Playername}, Position:{s1.PlayerPosition}, Age:{s1.PlayerAge}, Number:{s1.PlayerNumber}, Height: {s1.PlayerHeight}, Weight: {s1.PlayerWeight}, College: {s1.PlayerCollege}");
                     
                }
                else if (Question == "About Derwin James")
                {
                    Console.WriteLine($" Name:{s2.Playername}, Position:{s2.PlayerPosition}, Age:{s2.PlayerAge}, Number:{s2.PlayerNumber}, Height: {s2.PlayerHeight}, Weight: {s2.PlayerWeight}, College: {s2.PlayerCollege}");
                     
                }
                else if (Question == "About Jamal Williams")
                {
                    Console.WriteLine($" Name:{dt1.Playername}, Position:{dt1.PlayerPosition}, Age:{dt1.PlayerAge}, Number:{dt1.PlayerNumber}, Height: {dt1.PlayerHeight}, Weight: {dt1.PlayerWeight}, College: {dt1.PlayerCollege}");
                      
                }
                else if (Question == "About Joey Bosa")
                {
                    Console.WriteLine($" Name:{de1.Playername}, Position:{de1.PlayerPosition}, Age:{de1.PlayerAge}, Number:{de1.PlayerNumber}, Height: {de1.PlayerHeight}, Weight: {de1.PlayerWeight}, College: {de1.PlayerCollege}");
                      
                }
                else if (Question == "About Leslie O' Neal")
                {
                    Console.WriteLine($" Name:{de2.Playername}, Position:{de2.PlayerPosition}, Age:{de2.PlayerAge}, Number:{de2.PlayerNumber}, Height: {de2.PlayerHeight}, Weight: {de2.PlayerWeight}, College: {de2.PlayerCollege}");
                }


                if (Question.ToLower() == "quit")
                {
                    loop = false;
                }
                Question = Console.ReadLine();
                
            }
            
             
        }
    }
}
