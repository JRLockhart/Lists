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

            //upcast bird to ducks
            IEnumerable<Bird> upcastDucks = ducks;

            //add the content of list birds to list of ducks
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(ducks);
            birds.Add(new Penguin() { Name = "George" });

            //loop through birds and print contents
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            Console.WriteLine("");

            //print value before sort
            PrintDucks(ducks);

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
                Console.WriteLine(duck);
            }
            Console.WriteLine("End of ducks!\n");
        }
    }
}

