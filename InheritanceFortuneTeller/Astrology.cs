using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Astrology:Service
    {
        //properties
        public virtual int PercentEffective { get; set; }

        public override string Name { get; set; } 

        protected virtual string ExpertiseRequired { get; set; }

        //methods

            
        public virtual void Work()
        {
            Console.WriteLine();
            Console.WriteLine("I'll have someone look at your {0}.", this.Name);
        }

        public virtual void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Your {0} told me, ", this.Name);
            Console.WriteLine(this.Result);
        }

        public virtual void StateEffectiveness()
        {
            Console.WriteLine();
            Console.WriteLine("This method is {0} percent effective.", this.PercentEffective);
        }
    }

    
}
