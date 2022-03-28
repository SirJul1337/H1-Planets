using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    public class Planet
    {
        private string name;
        private double mass;
        private double diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int meanTemp;
        private int numOfMoons;
        private bool ringSys;

        public Planet(string name, double mass, double diameter, int density, double gravity, double rotationPeriod, double lengthOfDay, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, int meanTemp, int numberOfMoons, bool ringSys)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemp = meanTemp;
            NumberOfMoons = numberOfMoons;
            RingSys = ringSys;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public int Density
        {
            get { return density; }
            set { density = value; }
        }

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }


        public double RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }


        public double LengthOfDay
        {
            get { return lengthOfDay; }
            set { lengthOfDay = value; }
        }


        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }

        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        public int MeanTemp
        {
            get { return meanTemp; }
            set { meanTemp = value; }
        }


        public int NumberOfMoons
        {
            get { return numOfMoons; }
            set { numOfMoons = value; }
        }

        public  bool RingSys
        {
            get { return ringSys; }
            set { ringSys = value; }
        }











    }
}
