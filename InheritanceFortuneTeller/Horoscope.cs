using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Horoscope:Astrology
    {
        // named service
        public override string Name { get; set; } = "Horoscope";
        
        
        public override void Work()
        {
            base.Work();

            //ask for user input
            Console.WriteLine();
            Console.WriteLine("What month were you born? Enter \"MM\".");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("What day were you born? Enter \"DD\".");
            int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("What year were you born? \"YY\".");
            //int year = int.Parse(Console.ReadLine());

            string zodiac = "";

            // conditionals to determine and assign zodiac sign

            if (month == 01 )
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19)
                {
                    zodiac = "Capricorn";
                }

                if (day == 20 || day == 21 || day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day == 31)
                {
                    zodiac = "Aquarius";
                }
            }

            if (month == 02)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18)
                {
                    zodiac = "Aquarius";
                }

                if ( day == 19 ||day == 20 || day == 21 || day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29)
                {
                    zodiac = "Pisces";
                }
            }

            if (month == 03)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20)
                {
                    zodiac = "Pisces";
                }

                if (day == 21 || day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day == 31)
                {
                    zodiac = "Aries";
                }
            }

            if (month == 04)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19)
                {
                    zodiac = "Aries";
                }

                if (day == 20 || day == 21 || day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30)
                {
                    zodiac = "Taurus";
                }
            }

            if (month == 05)
            {
               if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20)
                {
                    zodiac = "Taurus";
                }

                if  (day == 21 || day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day == 31)
                {
                    zodiac = "Gemini";
                }
            }

            if (month == 06)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20)

                {
                    zodiac = "Gemini";
                }

                if (day == 21 || day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30)

                {
                    zodiac = "Cancer";
                }
            }

            if (month == 07)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20 || day == 21 || day == 22)
                {
                    zodiac = "Cancer";
                }

                if (day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day ==31)
                {
                    zodiac = "Leo";
                }
            }

            if (month == 08)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20 || day == 21 || day == 22)
                {
                    zodiac = "Leo";
                }

                if (day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day == 31)
                {
                    zodiac = "Virgo";
                }
            }

            if (month == 09)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20 || day == 21 || day == 22)
                {
                    zodiac = "Virgo";
                }

                if (day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 )
                {
                    zodiac = "Libra";
                }
            }

            if (month == 10)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20 || day == 21 || day == 22)
                {
                    zodiac = "Libra";
                }

                if (day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day == 31)
                {
                    zodiac = "Scorpio";
                }
            }

            if (month == 11)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20 || day == 21)
                {
                    zodiac = "Scorpio";
                }

                if (day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30)
                {
                    zodiac = "Sagittarius";
                }
            }

            if (month == 12)
            {
                if (day == 01 || day == 02 || day == 03 || day == 04 || day == 05 || day == 06 || day == 07 || day == 08 || day == 09 || day == 10 || day == 11 || day == 12 || day == 13 || day == 14 || day == 15 || day == 16 || day == 17 || day == 18 || day == 19 || day == 20 || day == 21)
                {
                    zodiac = "Sagittarius";
                }

                if (day == 22 || day == 23 || day == 24 || day == 25 || day == 26 || day == 27 || day == 28 || day == 29 || day == 30 || day == 31)
                {
                    zodiac = "Capricorn";
                }
            }
            Console.WriteLine();
            Console.WriteLine("You are a {0}.",zodiac);
            
            this.Result = GetYearHoro(zodiac);
        }

      

        protected string GetYearHoro(string zodiac)
        {
            string yearHoro = "";
            
            //switch case to assign zodiac to paragraph
            switch(zodiac)
            {
                case "Capricorn":
                    
                    yearHoro= "This year, accomplish more than you can imagine, Capricorn, simply by sticking to your favorite mode of doing things: with slow steady efforts. It won't involve anything flashy or earth-shaking. Nor will you become a dull robot! ";
                    break;
                case "Scorpio":
                   
                    yearHoro ="2016 is your year to demolish any barriers that have been holding you back, Scorpio! With clear thinking and sheer force of will, you can accomplish what your heart desires and what your head knows you need.";
                    break;
                case "Aquarius":
                    yearHoro = "You're a rising star in 2016, Aquarius, when all hard work is acknowledged and rewarded. Most of your work will be mental, and you will never lack for brilliant ideas, many of them seeming inconsequential at the time.";
                    break;
                case "Pisces":
                    yearHoro = "2016 is a power year, Pisces, and most of what you do will happen out in public, in plain view, and probably with the help and cooperation of others. ";
                    break;
                case "Aries":
                    yearHoro = "2016 is prime time for you to take charge of your public image and excel at the work of your choice, Aries! It will need effort, but you're up to the challenge. With the Moon, Mars, Saturn, and Uranus all in Fire signs as your year begins, you have more energy and staying power than most.";
                    break;
                case "Taurus":
                    yearHoro = "2016 is the year for big, important changes, Taurus. You can reinvent yourself from the ground up if you so choose. ";
                    break;
                case "Gemini":
                    yearHoro = "You're a rising star in 2016, Gemini, but it will keep constant effort to avoid slipping back down. Are you up for this? Of course you are!";
                    break;
                case "Cancer":
                    yearHoro = "2016 is your kind of year, Cancer, when you can turn on that moonlit charm of yours and make sure that the people in your life are the ones you want most! ";
                    break;
                case "Leo":
                    yearHoro = "Let the world see more of the true you in 2016, Leo! Work hard at what you love and have more fun doing it. More people will enjoy working with you, and then your social life could be busier, too. ";
                    break;
                case "Virgo":
                    yearHoro = "2016 is brimming with bright new ideas, abundance, and charm, Virgo. Yes, I'm talking about you! They will be practical ideas, too, that you can put to good use and make progress in the work place, and connect with people who are both reasonable and pleasant. That's how people see you, too.";
                    break;
                case "Libra":
                    yearHoro = "2016 is your lucky year, Libra, in more ways than one. Your tact and social skills will be in high demand and this will bring great satisfaction and happiness. ";
                    break;
                case "Sagittarius":
                    yearHoro = "2016 is your year, Sagittarius, to cultivate talents and skills that take you far and fast. You may not be given all the situations and opportunities that you choose right off the bat, but you'll have more than enough resources and creativity to make the best use of everything that comes your way.";
                    break;
            }
            

            return yearHoro;
        }

        

        public Horoscope()
        {
            this.Price = 25.00M;
            this.PercentEffective = 45;
            //this.BlackMagic = false;
            this.ExpertiseRequired = "beginner";
            //I want to call my initializer for phrases.
            //CreatePhrases();
        }

    }
}
