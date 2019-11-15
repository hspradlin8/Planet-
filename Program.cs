using System;
using System.Collections.Generic;

namespace planets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanet = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanet);

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> RockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");
        }
    }
}