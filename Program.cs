// using System;
// using System.Collections.Generic;

// namespace intro
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             List<int> numbers = new List<int> {
//             random.Next(6),
//             random.Next(6),
//             random.Next(6),
//             random.Next(6),
//             random.Next(6),
//             random.Next(6),
//             };

//             for (int i = 0; i < numbers.Count; i++)
//             {
//                 // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
//                 Console.WriteLine(numbers[i]);
//             }
//             for (int i = 0; i < numbers.Count; i++)
//             {
//                 // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

//                 if (numbers.Contains(i))
//                 {
//                     Console.WriteLine($"This list contains {i}");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"This list does not contain {i}");
//                 }
//             }

//         }
//     }
// }



using System;
using System.Collections.Generic;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<string> rockyPlanets = new List<string>() { };
            rockyPlanets = planetList.GetRange(0, 4);

             Console.WriteLine("     ALL PLANETS");
            for (int i = 0; i < planetList.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                Console.WriteLine(planetList[i]);
            }
            Console.WriteLine("     ROCKY PLANETS");
            for (int i = 0; i < rockyPlanets.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                Console.WriteLine(rockyPlanets[i]);
            }






        }
    }
}