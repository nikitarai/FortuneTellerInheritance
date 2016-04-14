using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Service
    {
        
        // "virtual" allows to be overriden by child
        

        public virtual decimal Price { get; set; }

        public virtual string Name { get; set; }

        public virtual string Result { get; set; }
    }
}
