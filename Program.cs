using System;
using System.Collections.Generic;

namespace Csharp_List_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars", "Venus" };
            planetList.Add("Saturn");
            planetList.Add("Jupiter");

            List<string> lastTwo = new List<string>() { "Planet 9", "Neptune" };

            planetList.AddRange(lastTwo);

            Console.WriteLine("\nAddRange(planetList)");

            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanetsList = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

        }
    }
}