using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // three basic arrays
            int[] numbersArray = {0,1,2,3,4,5,6,7,8,9};
            string[] namesArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] thirdArray = new bool[10];
            bool test = true;
            for (var i = 0; i < thirdArray.Length; i++)
            {
                thirdArray[i] = test;
                test = !test;
            }

            // list of flavors
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Coco");
            flavors.Add("Chocolate Chip");
            flavors.Add("Chocolate Milk");
            flavors.Add("Double Chocolate");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // user info dictionary
            Dictionary<string,string> user = new Dictionary<string, string>();
            foreach (string name in namesArray)
            {
                user.Add(name, null);
            }

            Random rand = new Random();
            foreach (var entry in namesArray)
            // can't manipulate a dictionary while iterating through it, so iterate through the other list instead
            {
                user[entry] = flavors[rand.Next(flavors.Count)];
            }

            foreach (var entry in user)
            {
                Console.WriteLine("{0}  likes  {1} ice cream", entry.Key, entry.Value);
            }
        }
    }
}
