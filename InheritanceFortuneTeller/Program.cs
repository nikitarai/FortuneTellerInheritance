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
            //create new employee so I can call greet method
            Employee receptionist = new Employee();
           
            receptionist.Greet();
            //call menu method to give user service options
            Menu();
            
        }

        static void Menu()
        {
           // display user service options to choose from
            Console.WriteLine("C | Crystal Ball");
            Console.WriteLine("P | Palm Reading");
            Console.WriteLine("H | Horoscope");

           // Console.WriteLine("E | Exit");

            //assigning user input to a variable name
            string ans = Console.ReadLine().ToUpper();

            //conditions based on user input
            switch(ans)
            {
                case "C":
                    FortuneTeller teller = new FortuneTeller();
                    CrystalBall blueCrystal = new CrystalBall();

                    Console.WriteLine();
                    //ask for user input
                    Console.WriteLine("What's your favorite color?");
                    string color = Console.ReadLine().ToLower();
                    Console.WriteLine("Has your life changed recently? \"Y\" or \"N\"");
                    string change = Console.ReadLine().ToUpper();
                    Console.WriteLine("What inspires you to move forward?");
                    string inspire = Console.ReadLine();

                    //fortunes based on user color input
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

                    //concatanating user input and strings into one string, assigned it to string varible name
                    string newPhrase = (change + " is the key to your happiness. Channel your " + inspire + " and move past any obstacles.");

                    blueCrystal.CreatePhrases(color);
                    blueCrystal.CreatePhrases(newPhrase);


                    teller.StartService((Service)blueCrystal);

                    blueCrystal.Work();
                    blueCrystal.Show();
                    blueCrystal.StateEffectiveness();
                   
                    //ask user to go again or stop
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
                        teller.Payment((Service)blueCrystal);
                        teller.Farewell();
                    }
                    break;
                case "P":
                    teller = new FortuneTeller();
                    PalmReading oracle = new PalmReading();

                    Console.WriteLine();
                    teller.StartService((Service)oracle);

                    
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
                        teller.Payment((Service)oracle);
                        teller.Farewell();
                    }


                    break;
                case "H":
                    teller = new FortuneTeller();
                    Horoscope yearly = new Horoscope();

                    yearly.Work();
                    Console.WriteLine();
                    yearly.Show();
                    Console.WriteLine();
                    yearly.StateEffectiveness();
                    Console.WriteLine();
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
                        teller.Payment((Service) yearly);
                        teller.Farewell();
                        
                    }

                    break;
                //original menu gave option to exit
                case "E":
                    Console.WriteLine("You'll be back soon.");
                    break;
            }
        }
    }

   
}
