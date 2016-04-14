 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("The Fortunate Boutique");
            Console.WriteLine("C | Crystal Ball");
            Console.WriteLine("P | Palm Reading");
            Console.WriteLine("E | Exit");
            string ans = Console.ReadLine().ToUpper();

            switch(ans)
            {
                case "C":
                    FortuneTeller river = new FortuneTeller();
                    CrystalBall blueCrystal = new CrystalBall();

                    Console.WriteLine();
                    river.Greet();
                    Console.WriteLine("What's your favorite color?");
                    string color = Console.ReadLine().ToLower();
                    Console.WriteLine("Has your life changed recently? \"Y\" or \"N\"");
                    string change = Console.ReadLine().ToUpper();
                    Console.WriteLine("What inspires you to move forward?");
                    string inspire = Console.ReadLine();

                    if (color == "red")
                    {
                        color = "You have to build your willpower.";
                    }

                    else if (color == "blue")
                    {
                        color = "You must learn a new way to think before you can master a new way to be.";
                    }

                    else if (color == "green")
                    {
                        color = "Life is short. Insecurity is a waste of time.";
                    }
                    else if (color == "black")
                    {
                        color = "No is a complete sentence. Use it more!";
                    }

                    else if (color == "yellow")
                    {
                        color = "No one is coming to save you. This life of yours is 100% your responsibility.";
                    }

                    else
                    {
                        color = "You're the problem. Not the solution.";
                    }

                    if (change == "Y")
                    {
                        change = "Letting go ";
                    }

                    else if (change == "N")
                    {
                        change = "Doing something new ";
                    }

                    string newPhrase = (change + " is the key to your happiness. Channel your " + inspire + " and move past any obstacles.");

                    blueCrystal.CreatePhrases(color);
                    blueCrystal.CreatePhrases(newPhrase);


                    river.StartService((Service)blueCrystal);

                    blueCrystal.Work();
                    blueCrystal.Show();
                    blueCrystal.StateEffectiveness();
                   

                    Console.WriteLine("Would you like another service? \"Y\" or \"N\".");
                    string serv = Console.ReadLine().ToUpper();

                    if (serv == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Menu();
                    }
                    else if (serv == "N")
                    {
                        river.Farewell();
                    }
                    break;
                case "P":
                    FortuneTeller magdalene = new FortuneTeller();
                    PalmReading oracle = new PalmReading();

                    magdalene.Greet();
                    magdalene.StartService((Service)oracle);

                    Console.WriteLine("Press enter to begin.");
                    string enter = Console.ReadLine();

                    oracle.Work();
                    oracle.Show();
                    oracle.StateEffectiveness();

                    

                    Console.WriteLine("Would you like another service? \"Y\" or \"N\".");
                    serv = Console.ReadLine().ToUpper();

                    if (serv == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Menu();
                    }
                    else if (serv == "N")
                    {
                        magdalene.Farewell();
                    }


                    break;
                case "E":
                    Console.WriteLine("You'll be back soon.");
                    break;
            }
        }
    }

   
}
