using System;
using System.Collections.Generic;
using System.Linq;
using CarShare.RestAPI.InputDTOs;
using CarShare.RestAPI.Resources;

namespace CarShare.RestAPI.Fakes
{
    public class FakeServiceWithNoDI
    {
        public List<Car> GetFakeCarDataBy(CarInputDTO request)
        {
            var fakeCars = GetFakeCars();

            if (request == null
                || (string.IsNullOrEmpty(request.Make)
                    && string.IsNullOrEmpty(request.Model)))
                return fakeCars;

            var cars = fakeCars.Where(c => c.Make.Equals(request.Make)
                                                        && c.Model.Equals(request.Model));
            return cars.ToList();
        }

        public void PostThe(CarInputDTO request)
        {
            // save to db would occur here--but its a fake
        }






        private static List<Car> GetFakeCars()
        {
            return new List<Car>
                       {
                           new Car { ProvidedBy = "Bob's Car Share", Year=2000, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Janice's Car Share", Year=2001, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Mavor's Car Share", Year=2002, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Abid's Car Share", Year=2003, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Barry's Car Share", Year=2004, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Allen's Car Share", Year=2005, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Carol's Car Share", Year=2006, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "Mira's Car Share", Year=2007, Make="Toyota", Model="Prius"},
                           new Car { ProvidedBy = "John's Car Share", Year=2008, Make="Toyota", Model="Prius"},

                           new Car { ProvidedBy = "Bob's Car Share", Year=2000, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Janice's Car Share", Year=2001, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Mavor's Car Share", Year=2002, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Abid's Car Share", Year=2003, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Barry's Car Share", Year=2004, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Allen's Car Share", Year=2005, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Carol's Car Share", Year=2006, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "Mira's Car Share", Year=2007, Make="Ford", Model="Focus"},
                           new Car { ProvidedBy = "John's Car Share", Year=2008, Make="Ford", Model="Focus"}
                       };
        }
    }
}