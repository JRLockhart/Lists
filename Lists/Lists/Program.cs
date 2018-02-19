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

            //sort from smallest to biggest and print value
            ducks.Sort();
            PrintDucks(ducks);

            //using a different way to sort the ducks
            DucksComparerBySize sizeComparer = new DucksComparerBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);

            //compare by the enum type Kind 
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            //readkey is used to keep the console open until a key is pressed
            Console.ReadKey();
        }

        //loop through all the duck objects and print the values as a string
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            }
            Console.WriteLine("End of ducks!\n");
        }
    }
}

