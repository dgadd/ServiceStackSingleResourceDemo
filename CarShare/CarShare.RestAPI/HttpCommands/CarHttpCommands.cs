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
            return new FakeServiceWithNoDI().GetFakeCarDataBy(request);
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