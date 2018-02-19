using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a new list of duck objects
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){Kind = KindOfDuck.Mallard, Size = 17},
                new Duck(){Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck(){Kind = KindOfDuck.Decoy, Size = 14},
                new Duck(){Kind = KindOfDuck.Mallard, Size = 11},
                new Duck(){Kind = KindOfDuck.Muscovy, Size = 14},
                new Duck(){Kind = KindOfDuck.Decoy, Size = 13},
            };

            //sort from smallest to biggest
            ducks.Sort();

            //readkey is used to keep the console open until a key is pressed
            Console.ReadKey();
        }
    }
}
