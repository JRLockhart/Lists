using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{

    //use enum to keep track of what sort of ducks are in the collection
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }

    //impliment ICoparable clae to sort based on duck size
    class Duck: IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        //sort from smallest to biggest
        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
            {
                return 1;
            }else if (this.Size < duckToCompare.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        //override toString for debug purposes
        public override string ToString()
        {
            return "A " + Size + " inch " + Kind.ToString(); 
        }
    }
}
