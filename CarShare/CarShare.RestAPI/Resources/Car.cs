using System;

namespace CarShare.RestAPI.Resources
{
    public class Car
    {
        public string ProvidedBy { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
    }
}