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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Type the indicated number for each Stat leader:");
            Console.WriteLine("");
            Console.WriteLine("(1): Passing Leader");
            Console.WriteLine("(2): Rushing Leader");
            Console.WriteLine("(3): Receiving Leader");
            Console.WriteLine("(4): Sacks Leader");
            Console.WriteLine("(5): Average Fantasy Point Leader");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("To access info about each player, type 'About' and the player's initials. Ex: Leslie O' Neal (About LN)");
            Console.WriteLine("");
            Console.WriteLine("Player Info Catgories: Name|Position|Age|Jersey Number|Height|Weight|College|");
            Console.WriteLine("");
            Console.WriteLine("To access each player's stats, type the player's initials and 'Stats'. Ex: Antonio Gates (AG Stats)");
            Console.WriteLine("");
            Console.WriteLine("Position Stat Categories");
            Console.WriteLine("");
            Console.WriteLine("Quarterbacks: Passing Yards|Completion Percentage|Completions|Passing Touchdowns|Rushing Touchdowns|Interceptions|Quarterback Rating|Average Fantasy Points| ");
            Console.WriteLine("");
            Console.WriteLine("Running Backs: Rushing Attempts|Rushing Yards|Rushing Touchdowns|Receptions|Fumbles|Average Fantasy Points");
            Console.WriteLine("");
            Console.WriteLine("Wide Receivers & Tide Ends: Receptions|Yards|Yards afetr Catch|Touchdowns|Fumbles|Average Fantasy Points|");
            Console.WriteLine("");
            Console.WriteLine("Cornerbacks, Safties & Linebackers: Interceptions|Solo Tackels|Tackle Assists|Defensive Touchdowns|Fumbles Caused|Fumble Recoveries|Sacks|");
            Console.WriteLine("");
            Console.WriteLine("Defensive Linmen: Solo Tackles|Tackle Assists|Fumbles Caused|Fumble Recoveries|Sacks");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("To access the list of players any time in the program type 'list'");
            Console.WriteLine("To exit the program type 'quit'");
            Console.WriteLine("");
            QB qb1 = new QB(9350, 66, 839, 69, 8, 25, 65, 22, "Justin Herbert", "QB", "23", 10, "6 - 6", 237, "Oregon");
            {
                Console.WriteLine($"{qb1.Playername}({qb1.PlayerPosition})");

            }

            QB qb2 = new QB(63440, 64, 5277, 421, 3, 209, 77, 16, "Philip Rivers", "QB", "(retired)", 17, "6 - 5", 228, "NC State");
            {
                Console.WriteLine($"{qb2.Playername}({qb2.PlayerPosition})");
            }

            RB rb1 = new RB(3174, 13684, 145, 624, 31, 22, "LaDainian Tomlinson", "RB", "(retired)", 21, "5 - 10", 215, "TCU");
            {
                Console.WriteLine($"{rb1.Playername}({rb1.PlayerPosition})");
            }

            RB rb2 = new RB(607, 2812, 21, 282, 11, 13, "Austin Ekeler", "RB", "26", 30, "5 - 10", 200, "Western St.");
            {
                Console.WriteLine($"{rb2.Playername}({rb2.PlayerPosition})");
            }

            TE te1 = new TE(541, 6741, 13, 45, 11, 12, "Kellen Winslow", "TE", "(retired)", 80, "6 - 5", 251, "Missouri");
            {
                Console.WriteLine($"{te1.Playername}({te1.PlayerPosition})");
            }

            TE te2 = new TE(955, 11841, 12, 116, 8, 9, "Antonio Gates", "TE", "(retired)", 85, "6 - 4", 255, "Kent St.");
            {
                Console.WriteLine($"{te2.Playername}({te2.PlayerPosition})");
            }

            WR wr1 = new WR(542, 10266, 19, 85, 5, 0, "Lance Alworth", "WR", "(retired)", 19, "6 - 0", 184, "Arkansas");
            {
                Console.WriteLine($"{wr1.Playername}({wr1.PlayerPosition})");
            }

            WR wr2 = new WR(730, 8535, 12, 48, 13, 10, "Keenan Allen", "WR", "30", 13, "6 - 2", 211, "California");
            {
                Console.WriteLine($"{wr2.Playername}({wr2.PlayerPosition})");
            }

            CB cb1 = new CB(21, 631, 104, 1, 7, 10, 0, "Quentin Jammer", "CB", "(retired)", 23, "6 - 0", 204, "Texas");
            {
                Console.WriteLine($"{cb1.Playername}({cb1.PlayerPosition})");
            }

            CB cb2 = new CB(24, 362, 69, 1, 2, 4, 0, "Casey Hayward", "CB", "32", 26, "5 - 11", 192, "Vanderbilt");
            {
                Console.WriteLine($"{cb2.Playername}({cb2.PlayerPosition})");
            }

            LB lb1 = new LB(18, 1077, 325, 1, 11, 18, 59,"Junior Seau", "LB", "(retired)", 55, "6 - 3", 250, "USC");
            {
                Console.WriteLine($"{lb1.Playername}({lb1.PlayerPosition})");
            }

            LB lb2 = new LB(3, 277, 108, 0, 15, 7, 51,"Melvin Ingram", "LB", "32", 54, "6 - 2", 247, "South Carolina");
            {
                Console.WriteLine($"{lb2.Playername}({lb2.PlayerPosition})");
            }

            S s1 = new S(34, 920, 286, 2, 15, 9, 31, "Rodney Harrison", "S", "(retired)", 37, "6 - 1", 220, "Western Illinois");
            {
                Console.WriteLine($"{s1.Playername}({s1.PlayerPosition})");
            }

            S s2 = new S(5, 173, 84, 0, 3, 0, 6,"Derwin James", "S", "25", 33, "6 - 2", 215, "Florida State");
            {
                Console.WriteLine($"{s2.Playername}({s2.PlayerPosition})");
            }

            DT dt1 = new DT(98, 1, 4, 3, 13,"Jamal Williams", "DT", "(retired)", 76, "6 - 3", 348, "Oklahoma State");
            {
                Console.WriteLine($"{dt1.Playername}({dt1.PlayerPosition})");
            }

            DE de1 = new DE(78, 0, 13, 3, 58,"Joey Bosa", "DE", "26", 97, "6 - 5", 280, "Ohio");
            {
                Console.WriteLine($"{de1.Playername}({de1.PlayerPosition})");
            }

            DE de2 = new DE(67, 1, 21, 16, 133,"Leslie O'Neal", "DE", "(retired)", 91, "6 - 4", 275, "Oklahoma State");
            {
                Console.WriteLine($"{de2.Playername}({de2.PlayerPosition})");
            }
            Console.WriteLine("");



            string Question = Console.ReadLine();
            bool loop = true;
            while (loop)
            {

                if (Question == "About JH")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {qb1.Playername}, Position: {qb1.PlayerPosition}, Age: {qb1.PlayerAge}, Number: {qb1.PlayerNumber}, Height: {qb1.PlayerHeight}, Weight: {qb1.PlayerWeight}, College: {qb1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {qb1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Passing Yards: {qb1.PassYDs}, Completion Percentage: {qb1.CmpPc}, Completions : {qb1.Cmps}, Passing Touchdowns: {qb1.PassTDs}, Rushing Touchdowns: {qb1.QBRushTDS}, Interceptions: {qb1.QBInt}, QB Rating: {qb1.Rating}, Average Fantasy Points: {qb1.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About PR")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {qb2.Playername}, Position: {qb2.PlayerPosition}, Age: {qb2.PlayerAge}, Number: {qb2.PlayerNumber}, Height: {qb2.PlayerHeight}, Weight: {qb2.PlayerWeight}, College: {qb2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {qb2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Passing Yards: {qb2.PassYDs}, Completion Percentage: {qb2.CmpPc}, Completions: {qb2.Cmps}, Passing Touchdowns: {qb2.PassTDs}, Rushing Touchdowns: {qb2.QBRushTDS}, Interceptions: {qb2.QBInt}, QB Rating: {qb2.Rating}, Average Fantasy Points: {qb2.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About  LT")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {rb1.Playername}, Position: {rb1.PlayerPosition}, Age: {rb1.PlayerAge}, Number: {rb1.PlayerNumber}, Height: {rb1.PlayerHeight}, Weight: {rb1.PlayerWeight}, College: {rb1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {rb1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Rushing Attempts: {rb1.Rushatt}, Rushing Yards: {rb1.RushYds}, Rushing Touchdowns: {rb1.RushTDs}, Receptions: {rb1.Rec}, Fumbles: {rb1.Fmbs}, Fantasy Points: {rb1.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    
                }
                else if (Question == "About AE")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {rb2.Playername}, Position: {rb2.PlayerPosition}, Age: {rb2.PlayerAge}, Number: {rb2.PlayerNumber}, Height: {rb2.PlayerHeight}, Weight: {rb2.PlayerWeight}, College: {rb2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {rb2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Rushing Attempts: {rb2.Rushatt}, Rushing Yards: {rb2.RushYds}, Rushing Touchdowns: {rb2.RushTDs}, Receptions: {rb2.Rec}, Fumbles: {rb2.Fmbs}, Average Fantasy Points: {rb2.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About KW")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {te1.Playername}, Position: {te1.PlayerPosition}, Age: {te1.PlayerAge}, Number: {te1.PlayerNumber}, Height: {te1.PlayerHeight}, Weight: {te1.PlayerWeight}, College: {te1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {te1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Receptions:{te1.Rec}, Recieving Yards:{te1.Yds}, Yards after Catch :{te1.YAC}, Touchdowns :{te1.Rec}, Fumbles: {te1.Fmbs}, Average Fantasy Points: {te1.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About AG")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {te2.Playername}, Position: {te2.PlayerPosition}, Age: {te2.PlayerAge}, Number: {te2.PlayerNumber}, Height: {te2.PlayerHeight}, Weight: {te2.PlayerWeight}, College: {te2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {te2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Receptions: {te2.Rec}, Recieving Yards: {te2.Yds}, Yards after Catch: {te2.YAC}, Touchdowns: {te2.Rec}, Fumbles: {te2.Fmbs}, Average Fantasy Points: {te2.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About LA")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {wr1.Playername}, Position: {wr1.PlayerPosition}, Age: {wr1.PlayerAge}, Number: {wr1.PlayerNumber}, Height: {wr1.PlayerHeight}, Weight: {wr1.PlayerWeight}, College: {wr1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {wr1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Receptions: {wr1.Rec}, Recieving Yards: {wr1.Yds}, Yards after Catch: {wr1.YAC}, Touchdowns :{wr1.Rec}, Fumbles: {wr1.Fmbs}, Average Fantasy Points: {wr1.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About KA")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {wr2.Playername}, Position: {wr2.PlayerPosition}, Age: {wr2.PlayerAge}, Number: {wr2.PlayerNumber}, Height: {wr2.PlayerHeight}, Weight: {wr2.PlayerWeight}, College: {wr2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {wr2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Receptions: {wr2.Rec}, Recieving Yards: {wr2.Yds}, Yards after Catch: {wr2.YAC}, Touchdowns :{wr2.Rec}, Fumbles: {wr2.Fmbs}, Average Fantasy Points: {wr2.FP}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About QJ")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {cb1.Playername}, Position: {cb1.PlayerPosition}, Age: {cb1.PlayerAge}, Number: {cb1.PlayerNumber}, Height: {cb1.PlayerHeight}, Weight: {cb1.PlayerWeight}, College: {cb1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {cb1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Interceptions: {cb1.DBInt}, Tackles: {cb1.Tkls}, Tackle Assists: {cb1.TklAsst}, Defensive Touchdowns: {cb1.DefTDs}, Fumbles Caused: {cb1.FumC}, Fumbles Recovered: {cb1.FumR}, Sacks: {cb1.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About CH")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {cb2.Playername}, Position: {cb2.PlayerPosition}, Age: {cb2.PlayerAge}, Number: {cb2.PlayerNumber}, Height: {cb2.PlayerHeight}, Weight: {cb2.PlayerWeight}, College: {cb2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {cb2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Interceptions: {cb2.DBInt}, Tackles: {cb2.Tkls}, Tackle Assists :{cb2.TklAsst}, Defensive Touchdowns :{cb2.DefTDs}, Fumbles Caused: {cb2.FumC}, Fumbles Recovered: {cb2.FumR}, Sacks: {cb2.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About JS")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {lb1.Playername}, Position: {lb1.PlayerPosition}, Age: {lb1.PlayerAge}, Number: {lb1.PlayerNumber}, Height: {lb1.PlayerHeight}, Weight: {lb1.PlayerWeight}, College: {lb1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {lb1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Interceptions: {lb1.DBInt}, Tackles: {lb1.Tkls}, Tackle Assists: {lb1.TklAsst}, Defensive Touchdowns: {lb1.DefTDs}, Fumbles Caused: {lb1.FumC}, Fumbles Recovered: {lb1.FumR}, Sacks: {lb1.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About MI")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {lb2.Playername}, Position: {lb2.PlayerPosition}, Age: {lb2.PlayerAge}, Number: {lb2.PlayerNumber}, Height: {lb2.PlayerHeight}, Weight: {lb2.PlayerWeight}, College: {lb2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {lb2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Interceptions: {lb2.DBInt}, Tackles: {lb2.Tkls}, Tackle Assists: {lb2.TklAsst}, Defensive Touchdowns: {lb2.DefTDs}, Fumbles Caused: {lb2.FumC}, Fumbles Recovered: {lb2.FumR}, Sacks: {lb2.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About RH")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {s1.Playername}, Position: {s1.PlayerPosition}, Age: {s1.PlayerAge}, Number: {s1.PlayerNumber}, Height: {s1.PlayerHeight}, Weight: {s1.PlayerWeight}, College: {s1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {s1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Interceptions: {s1.DBInt}, Tackles: {s1.Tkls}, Tackle Assists: {s1.TklAsst}, Defensive Touchdowns: {s1.DefTDs}, Fumbles Caused: {s1.FumC}, Fumbles Recovered: {s1.FumR}, Sacks: {s1.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About DJ")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {s2.Playername}, Position: {s2.PlayerPosition}, Age: {s2.PlayerAge}, Number: {s2.PlayerNumber}, Height: {s2.PlayerHeight}, Weight: {s2.PlayerWeight}, College: {s2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {s2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Interceptions: {s2.DBInt}, Tackles: {s2.Tkls}, Tackle Assists: {s2.TklAsst}, Defensive Touchdowns :{s2.DefTDs}, Fumbles Caused: {s2.FumC}, Fumbles Recovered: {s2.FumR}, Sacks: {s2.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About JW")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {dt1.Playername}, Position: {dt1.PlayerPosition}, Age: {dt1.PlayerAge}, Number: {dt1.PlayerNumber}, Height: {dt1.PlayerHeight}, Weight: {dt1.PlayerWeight}, College: {dt1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {dt1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Tackles: {dt1.Tkls}, Tackle Assists: {dt1.TklAsst}, Fumbles Caused: {dt1.FumC}, Fumbles Recovered: {dt1.FumR}, Sacks: {dt1.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About JB")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {de1.Playername}, Position: {de1.PlayerPosition}, Age: {de1.PlayerAge}, Number: {de1.PlayerNumber}, Height: {de1.PlayerHeight}, Weight: {de1.PlayerWeight}, College: {de1.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {de1.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Tackles: {de1.Tkls}, Tackle Assists: {de1.TklAsst}, Fumbles Caused: {de1.FumC}, Fumbles Recovered: {de1.FumR}, Sacks: {de1.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "About LN")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Name: {de2.Playername}, Position: {de2.PlayerPosition}, Age: {de2.PlayerAge}, Number: {de2.PlayerNumber}, Height: {de2.PlayerHeight}, Weight: {de2.PlayerWeight}, College: {de2.PlayerCollege}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see {de2.Playername}'s stats?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Tackles: {de2.Tkls}, Tackle Assists : {de2.TklAsst}, Fumbles Caused: {de2.FumC}, Fumbles Recovered: {de2.FumR}, Sacks: {de2.Sks}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "JH Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Passing Yards: {qb1.PassYDs}, Completion Percentage: {qb1.CmpPc}, Completions: {qb1.Cmps}, Passing Touchdowns: {qb1.PassTDs}, Rushing Touchdowns: {qb1.QBRushTDS}, Interceptions: {qb1.QBInt}, QB Rating: {qb1.Rating}, Average Fantasy Points: {qb1.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {qb1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {qb1.Playername}, Position: {qb1.PlayerPosition}, Age: {qb1.PlayerAge}, Number: {qb1.PlayerNumber}, Height: {qb1.PlayerHeight}, Weight: {qb1.PlayerWeight}, College: {qb1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
            }
                else if (Question == "PR Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Passing Yards: {qb2.PassYDs}, Completion Percentage: {qb2.CmpPc}, Completions: {qb2.Cmps}, Passing Touchdowns: {qb2.PassTDs}, Rushing Touchdowns: {qb2.QBRushTDS}, Interceptions: {qb2.QBInt}, QB Rating: {qb2.Rating}, Average Fantasy Points: {qb2.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {qb2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {qb2.Playername}, Position: {qb2.PlayerPosition}, Age: {qb2.PlayerAge}, Number: {qb2.PlayerNumber}, Height: {qb2.PlayerHeight}, Weight: {qb2.PlayerWeight}, College: {qb2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "LT Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Rushing Attempts: {rb1.Rushatt}, Rushing Yards: {rb1.RushYds}, Rushing Touchdowns : {rb1.RushTDs}, Receptions: {rb1.Rec}, Fumbles: {rb1.Fmbs}, Average Fantasy Points: {rb1.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {rb1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {rb1.Playername}, Position: {rb1.PlayerPosition}, Age: {rb1.PlayerAge}, Number: {rb1.PlayerNumber}, Height: {rb1.PlayerHeight}, Weight: {rb1.PlayerWeight}, College: {rb1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "AE Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Rushing Attempts: {rb2.Rushatt}, Rushing Yards: {rb2.RushYds}, Rushing Touchdowns : {rb2.RushTDs}, Receptions: {rb2.Rec}, Fumbles: {rb2.Fmbs}, Average Fantasy Points: {rb2.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {rb2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {rb2.Playername}, Position: {rb2.PlayerPosition}, Age: {rb2.PlayerAge}, Number: {rb2.PlayerNumber}, Height: {rb2.PlayerHeight}, Weight: {rb2.PlayerWeight}, College: {rb2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "KW Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Receptions: {te1.Rec}, Recieving Yards: {te1.Yds}, Yards after Catch: {te1.YAC}, Touchdowns: {te1.Rec}, Fumbles: {te1.Fmbs}, Average Fantasy Points: {te1.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {te1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {te1.Playername}, Position: {te1.PlayerPosition}, Age: {te1.PlayerAge}, Number: {te1.PlayerNumber}, Height: {te1.PlayerHeight}, Weight: {te1.PlayerWeight}, College: {te1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c  != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question  == "AG Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Receptions: {te2.Rec}, Recieving Yards: {te2.Yds}, Yards after Catch: {te2.YAC}, Touchdowns: {te2.Rec}, Fumbles: {te2.Fmbs}, Average Fantasy Points: {te2.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {te2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c  == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {te2.Playername}, Position: {te2.PlayerPosition}, Age: {te2.PlayerAge}, Number: {te2.PlayerNumber}, Height: {te2.PlayerHeight}, Weight: {te2.PlayerWeight}, College: {te2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "LA Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Receptions: {wr1.Rec}, Recieving Yards: {wr1.Yds}, Yards after Catch: {wr1.YAC}, Touchdowns: {wr1.Rec}, Fumbles: {wr1.Fmbs}, Average Fantasy Points: {wr1.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {wr1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {wr1.Playername}, Position: {wr1.PlayerPosition}, Age: {wr1.PlayerAge}, Number: {wr1.PlayerNumber}, Height: {wr1.PlayerHeight}, Weight: {wr1.PlayerWeight}, College: {wr1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "KA Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Receptions: {wr2.Rec}, Recieving Yards: {wr2.Yds}, Yards after Catch: {wr2.YAC}, Touchdowns: {wr2.Rec}, Fumbles: {wr2.Fmbs}, Average Fantasy Points: {wr2.FP}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {wr2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {wr2.Playername}, Position: {wr2.PlayerPosition}, Age: {wr2.PlayerAge}, Number: {wr2.PlayerNumber}, Height: {wr2.PlayerHeight}, Weight: {wr2.PlayerWeight}, College: {wr2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "QJ Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Interceptions: {cb1.DBInt}, Tackles: {cb1.Tkls}, Tackle Assists: {cb1.TklAsst}, Defensive Touchdowns: {cb1.DefTDs}, Fumbles Caused: {cb1.FumC}, Fumbles Recovered: {cb1.FumR}, Sacks: {cb1.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {cb1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {cb1.Playername}, Position: {cb1.PlayerPosition}, Age: {cb1.PlayerAge}, Number: {cb1.PlayerNumber}, Height: {cb1.PlayerHeight}, Weight: {cb1.PlayerWeight}, College: {cb1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "CH Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Interceptions: {cb2.DBInt}, Tackles: {cb2.Tkls}, Tackle Assists: {cb2.TklAsst}, Defensive Touchdowns: {cb2.DefTDs}, Fumbles Caused: {cb2.FumC}, Fumbles Recovered: {cb2.FumR}, Sacks: {cb2.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {cb2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {cb2.Playername}, Position: {cb2.PlayerPosition}, Age: {cb2.PlayerAge}, Number: {cb2.PlayerNumber}, Height: {cb2.PlayerHeight}, Weight: {cb2.PlayerWeight}, College: {cb2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "JS Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Interceptions: {lb1.DBInt}, Tackles: {lb1.Tkls}, Tackle Assists: {lb1.TklAsst}, Defensive Touchdowns: {lb1.DefTDs}, Fumbles Caused: {lb1.FumC}, Fumbles Recovered: {lb1.FumR}, Sacks: {lb1.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {lb1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {lb1.Playername}, Position: {lb1.PlayerPosition}, Age: {lb1.PlayerAge}, Number: {lb1.PlayerNumber}, Height: {lb1.PlayerHeight}, Weight: {lb1.PlayerWeight}, College: {lb1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "MI Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Interceptions: {lb2.DBInt}, Tackles: {lb2.Tkls}, Tackle Assists: {lb2.TklAsst}, Defensive Touchdowns: {lb2.DefTDs}, Fumbles Caused: {lb2.FumC}, Fumbles Recovered: {lb2.FumR}, Sacks: {lb2.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {lb2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {lb2.Playername}, Position: {lb2.PlayerPosition}, Age: {lb2.PlayerAge}, Number: {lb2.PlayerNumber}, Height: {lb2.PlayerHeight}, Weight: {lb2.PlayerWeight}, College: {lb2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "RH Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Interceptions: {s1.DBInt}, Tackles: {s1.Tkls}, Tackle Assists: {s1.TklAsst}, Defensive Touchdowns: {s1.DefTDs}, Fumbles Caused: {s1.FumC}, Fumbles Recovered: {s1.FumR}, Sacks: {s1.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {s1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {s1.Playername}, Position: {s1.PlayerPosition}, Age: {s1.PlayerAge}, Number: {s1.PlayerNumber}, Height: {s1.PlayerHeight}, Weight: {s1.PlayerWeight}, College: {s1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "DJ Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Interceptions: {s2.DBInt}, Tackles: {s2.Tkls}, Tackle Assists: {s2.TklAsst}, Defensive Touchdowns: {s2.DefTDs}, Fumbles Caused: {s2.FumC}, Fumbles Recovered: {s2.FumR}, Sacks: {s2.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {s2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {s2.Playername}, Position: {s2.PlayerPosition}, Age: {s2.PlayerAge}, Number: {s2.PlayerNumber}, Height: {s2.PlayerHeight}, Weight: {s2.PlayerWeight}, College: {s2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "JW Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Tackles: {dt1.Tkls}, Tackle Assists: {dt1.TklAsst}, Fumbles Caused: {dt1.FumC}, Fumbles Recovered: {dt1.FumR}, Sacks: {dt1.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {dt1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {dt1.Playername}, Position: {dt1.PlayerPosition}, Age: {dt1.PlayerAge}, Number: {dt1.PlayerNumber}, Height: {dt1.PlayerHeight}, Weight: {dt1.PlayerWeight}, College: {dt1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "JB Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Tackles: {de1.Tkls}, Tackle Assists: {de1.TklAsst}, Fumbles Caused: {de1.FumC}, Fumbles Recovered: {de1.FumR}, Sacks: {de1.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {de1.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {de1.Playername}, Position: {de1.PlayerPosition}, Age: {de1.PlayerAge}, Number: {de1.PlayerNumber}, Height: {de1.PlayerHeight}, Weight: {de1.PlayerWeight}, College: {de1.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question == "LN Stats")
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Tackles: {de2.Tkls}, Tackle Assists: {de2.TklAsst}, Fumbles Caused: {de2.FumC}, Fumbles Recovered: {de2.FumR}, Sacks: {de2.Sks}");
                    Console.WriteLine("");
                    Console.WriteLine($"Would you like to see info on {de2.Playername}?  If so, Type Yes");
                    Console.WriteLine("");
                    string c = Console.ReadLine();
                    if (c.ToLower() == "yes") {
                        Console.WriteLine("");
                        Console.WriteLine($" Name: {de2.Playername}, Position: {de2.PlayerPosition}, Age: {de2.PlayerAge}, Number: {de2.PlayerNumber}, Height: {de2.PlayerHeight}, Weight: {de2.PlayerWeight}, College: {de2.PlayerCollege}");
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                    else if (c.ToLower() != "yes"){
                        Console.WriteLine("");
                        Console.WriteLine("Enter another player (*Remember to use 'About' and 'Stats' keywords):");
                        Console.WriteLine("");
                    }
                }
                else if (Question.ToLower() == "3")
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{te2.Name} is the Chargers all time receiving leader. He leads the Chargers receivers in yards({te2.Yds}), catches({te2.Rec}) and touchdowns({te2.TDs})");
                    Console.WriteLine("");
                    Console.WriteLine("Enter another number from 1-5 for more all time stats/Enter Player Name: (Type 'List' for reference).");
                    Console.WriteLine("");
                }
                else if (Question.ToLower() == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{qb2.Name} is the Chargers all time passing leader. He leads the Charger quarterbacks in yards({qb2.PassYDs}), completions({qb2.Cmps}), completion percentage({qb2.CmpPc}) and touchdowns({qb2.PassTDs})");
                    Console.WriteLine("");
                    Console.WriteLine("Enter another number from 1-5 for more all time stats/Enter Player Name: (Type 'List' for reference).");
                    Console.WriteLine("");
                }
                else if (Question.ToLower() == "4")
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{de2.Name} is the Chargers all time sacks leader. He has {de2.Sks} career sacks.");
                    Console.WriteLine("");
                    Console.WriteLine("Enter another number from 1-5 for more all time stats/Enter Player Name: (Type 'List' for reference).");
                    Console.WriteLine("");
                }
                else if (Question.ToLower() == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{rb1.Name} is the Chargers all time rushing leader. He leads Chargers running backs in yards({rb1.RushYds}) and touchdowns({rb1.RushTDs})");
                    Console.WriteLine("");
                    Console.WriteLine("Enter another number from 1-5 for more all time stats/Enter Player Name: (Type 'List' for reference).");
                    Console.WriteLine("");
                }
                else if (Question.ToLower() == "5")
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{qb1.Name} is the most reliable fantasy player of the chargers players. He averages {qb1.FP} fantasy points.");
                    Console.WriteLine("");
                    Console.WriteLine("Enter another number from 1-5 for more all time stats/Enter Player Name: (Type 'List' for reference).");
                    Console.WriteLine("");
                }
                else if (Question.ToLower() == "list" || Question == "List"){
                    Console.WriteLine("");
                    Console.WriteLine($"{qb1.Playername}({qb1.PlayerPosition})");
                    Console.WriteLine($"{qb2.Playername}({qb2.PlayerPosition})");
                    Console.WriteLine($"{rb1.Playername}({rb1.PlayerPosition})");
                    Console.WriteLine($"{rb2.Playername}({rb2.PlayerPosition})");
                    Console.WriteLine($"{te1.Playername}({te1.PlayerPosition})");
                    Console.WriteLine($"{te2.Playername}({te2.PlayerPosition})");
                    Console.WriteLine($"{wr1.Playername}({wr1.PlayerPosition})");
                    Console.WriteLine($"{wr2.Playername}({wr2.PlayerPosition})");
                    Console.WriteLine($"{cb1.Playername}({cb1.PlayerPosition})");
                    Console.WriteLine($"{cb2.Playername}({cb2.PlayerPosition})");
                    Console.WriteLine($"{lb1.Playername}({lb1.PlayerPosition})");
                    Console.WriteLine($"{lb2.Playername}({lb2.PlayerPosition})");
                    Console.WriteLine($"{s1.Playername}({s1.PlayerPosition})");
                    Console.WriteLine($"{s2.Playername}({s2.PlayerPosition})");
                    Console.WriteLine($"{dt1.Playername}({dt1.PlayerPosition})");
                    Console.WriteLine($"{de1.Playername}({de1.PlayerPosition})");
                    Console.WriteLine($"{de2.Playername}({de2.PlayerPosition})"); 
                    Console.WriteLine("");
                    
                    Console.WriteLine("(1): Passing Leader");
                    Console.WriteLine("(2): Rushing Leader");
                    Console.WriteLine("(3): Receiving Leader");
                    Console.WriteLine("(4): Sacks Leader");
                    Console.WriteLine("(5): Average Fantasy Point Leader");
                    Console.WriteLine("");
                    Console.WriteLine("Enter Player Name (*Remember to use 'About' and 'Stats' keywords):");
                    Console.WriteLine("");
                    
                }
               else if (Question == "Quit" || Question == "quit")
                {   
                    loop = false;
                    break;
                
                }
                else {
                    Console.WriteLine("");
                    Console.WriteLine("*Invalid Player/Number Input*");
                    Console.WriteLine("Make sure 'About' and 'Stats' are capitalized. *Initals must be capitalized as well. Only numbers 1-5 are accepted.");
                    Console.WriteLine("");
                }
                 Question = Console.ReadLine();
                
            }
            
             
        }
    }
}
