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

    class Duck
    {
        public int Size;
        public KindOfDuck Kind;
    }
}
