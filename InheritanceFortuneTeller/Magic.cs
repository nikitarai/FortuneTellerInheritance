using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Magic:Service
    {
        public virtual bool BlackMagic { get; set; }

        //how about another property that gives us the effectiveness of this magical item?
        public virtual int PercentEffective { get; set; }

        //let's make sure all of them have a name! "override forces child to change it"
        public override string Name { get; set; }

        //let's throw in the level of expertise the fortune teller needs to use this item
        protected virtual string ExpertiseRequired { get; set; }

        //How about a  work -- "make it go now" method?
        public virtual void Work()
        {
            Console.WriteLine();
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }
        //What about a Show method for sharing the results -- showing the magical object to the user?
        public virtual void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Oh, my. The {0} told me, yes, your future.", this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine();
            Console.WriteLine("In case you're wondering, this method is {0} percent effective.", this.PercentEffective);
        }

    }
}
