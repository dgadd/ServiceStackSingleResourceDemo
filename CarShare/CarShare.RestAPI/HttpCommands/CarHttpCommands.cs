using System;
using System.Collections.Generic;
using System.Linq;
using CarShare.RestAPI.Fakes;
using CarShare.RestAPI.InputDTOs;
using CarShare.RestAPI.Resources;
using ServiceStack.ServiceInterface;

namespace CarShare.RestAPI.HttpCommands
{
    public class CarHttpCommands : RestServiceBase<CarInputDTO>
    {
        public override object OnGet(CarInputDTO request)
        {
            List<Car> fakeCars = new FakeServiceWithNoDI().GetFakeCarData();
            IEnumerable<Car> cars = fakeCars.Where(c => c.Make.Equals(request.Make) && c.Model.Equals(request.Model));
            return cars.ToList();
        }

        public override object OnPut(CarInputDTO request)
        {
            throw new NotImplementedException();
        }

        public override object OnPost(CarInputDTO request)
        {
            throw new NotImplementedException();
        }

        public override object OnDelete(CarInputDTO request)
        {
            throw new NotImplementedException();
        }
    }
}