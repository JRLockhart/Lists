using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    //base class bird
    class Bird
    {
        //basic property
        public string Name { get; set; }

        //fly method to be overridden by various bird types
        public virtual void Fly()
        {
            Console.WriteLine("Flap, Flap");
        }

        //the tostring method will make it easy to see which class is which
        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }
}
