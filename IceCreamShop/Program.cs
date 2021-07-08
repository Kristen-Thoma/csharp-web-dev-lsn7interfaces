using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);
            //availableFlavors.Sort(new FlavorComparer());

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            ConeComparer coneComparer = new ConeComparer();
            availableCones.Sort(coneComparer);


            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            //foreach (var flavor in availableFlavors)
            //{
            //    Console.WriteLine(flavor);
            //}

            foreach(var cone in availableCones)
            {
                Console.WriteLine(cone);
            }
        }
    }
}
