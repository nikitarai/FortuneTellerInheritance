using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InheritanceFortuneTeller
{
    class PalmReading : Magic
    {
        private Random palm = new Random();

        //properties
        protected List<string> Phrase1 { get; set; } = new List<string>();

        public override string Name { get; set; } = "Palm Reading";

        protected void CreatePhrases()
        {
            Phrase1.Add("Your heart is a place to draw true happiness.");
            Phrase1.Add("It takes more than good memory to have good memories.");
            Phrase1.Add("Your everlasting patience will be rewarded sooner or later.");
            Phrase1.Add("One who admires you greatly is hidden before your eyes.");
        }

        public override void Work()
        {
            //base.work() calls for parent work to happen before child's work
            base.Work();
            //now let's call a method that will get a result for palm reading
            Console.WriteLine("Place your hand over your mousepad. Close your eyes and count to 5.");
           
            //delays result printing to the console for 7 seconds
            Thread.Sleep(7000);
            this.Result = GetPhrase();

        }

       

        internal void CreatePhrases(string phrase)
        {
            Phrase1.Add(phrase);
        }

        private string GetPhrase()
        {
            //local variable
            int randomNumber = palm.Next(Phrase1.Count);
            // method element at gets the index of
            return Phrase1.ElementAt(randomNumber);
        }

        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public PalmReading()
        {
            this.Price = 60.00M;
            this.PercentEffective = 85;
            this.BlackMagic = false;
            this.ExpertiseRequired = "moderate";
            //I want to call my initializer for phrases.
            CreatePhrases();
            
        }
    }
}
