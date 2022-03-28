﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Planet Merkur = new Planet("Merkur",0.330,4879,5427,3.7,1407.6,4222.6,57.9,88.0,47.4,167,0,false);
            Planet Venus = new Planet("Venus",4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            Planet Earth = new Planet("Earth",5.97,12756,5514,9.8,23.9,24.0,149.6,365.2,29.8,15,1,false);
            Planet Mars = new Planet("Mars",0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet Jupiter = new Planet("Jupiter",1898,142984,1326,23.1,9.9,9.9,778.6,4331,13.1,-110,67,true);
            Planet Saturn = new Planet("Saturn",568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
            Planet Uranus = new Planet("Uranus",86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
            Planet Neptune = new Planet("Neptune",102,49528,1638,11.0,16.1,16.1,4495.1,59.8,5.4,-200,14,true);
            Planet Pluto = new Planet("Pluto",0.0146,2370,2095,0.7,-153.3,153.3,5906.4,90.56,4.7,-225,5,false);
            List<Planet> planetsList = new List<Planet>();

            planetsList.Add(Merkur);
            planetsList.Add(Earth);
            planetsList.Add(Mars);
            planetsList.Add(Jupiter);
            planetsList.Add(Saturn);
            planetsList.Add(Uranus);
            planetsList.Add(Neptune);
            planetsList.Add(Pluto);


            foreach (Planet planet in planetsList)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine("\nNow we add Venus at index 1");
            planetsList.Insert(1,Venus);

            Console.WriteLine("\nNow we remove Pluto");
            planetsList.Remove(Pluto);

            foreach (Planet planet in planetsList)
            {
                Console.WriteLine(planet.Name);
            }


            Console.WriteLine("\nNow we add pluto back");
            planetsList.Add(Pluto);
            foreach (Planet planet in planetsList)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine("\nCount of planets");
            Console.WriteLine(planetsList.Count);


            Console.WriteLine("\nAll planets with mean temperatures below 0");
            List<Planet> tempBelowZero = planetsList.Where(planet => planet.MeanTemp > 0).ToList();
            foreach(Planet planet in tempBelowZero)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine("\nAll planets with a diameter above 10000km and below 50000km");
            List<Planet> diameter10k50k = planetsList.Where(planet => planet.Diameter >= 10000 && planet.Diameter <= 50000).ToList();
            foreach (Planet planet in diameter10k50k)
            {
                Console.WriteLine(planet.Name);
            }


            planetsList.Clear();

        }
    }
}
