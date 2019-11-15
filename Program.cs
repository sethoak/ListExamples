using System;
using System.Collections.Generic;

namespace Csharp_List_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Saturn");
            planetList.Add("Jupiter");
        }
        List<string> lastTwo = new List<string>() { "Pluto", "Neptune" };

        lastTwo.AddRange(planetList);

        Console.WriteLine("\nAddRange(planetList)");
    }
}