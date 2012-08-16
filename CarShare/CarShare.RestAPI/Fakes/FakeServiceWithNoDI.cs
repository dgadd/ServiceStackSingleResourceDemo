using System;
using System.Collections.Generic;
using CarShare.RestAPI.Resources;

namespace CarShare.RestAPI.Fakes
{
    public class FakeServiceWithNoDI
    {
        public List<Car> GetFakeCarData()
        {
            return new List<Car>
                       {
                           new Car { ProvidedBy = "Bob's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Janice's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Mavor's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Abid's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Barry's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Allen's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Carol's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Mira's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "John's Car Share", Year=2007, Make="Toyota", Model="Prius"},

                           new Car { ProvidedBy = "Bob's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Janice's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Mavor's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Abid's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Barry's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Allen's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Carol's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Mira's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "John's Car Share", Year=2007, Make="Ford", Model="Focus"}
                       };
        }
    }
}