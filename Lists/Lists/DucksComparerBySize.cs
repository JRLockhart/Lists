using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{

    //specifies the type of object it can sort
    class DucksComparerBySize : IComparer<Duck>
    {

        //return an int and pass two parameters to be sorted
        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size)
                return -1;
            if (x.Size > y.Size)
                return 1;
            return 0;
        }
       
    }
}
