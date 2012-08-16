using System.Collections.Generic;
using CarShare.RestAPI.HttpCommands;
using CarShare.RestAPI.InputDTOs;
using CarShare.RestAPI.Resources;
using NUnit.Framework;
using ServiceStack.ServiceInterface;

namespace CarShare.RestAPI.Tests.Unit
{
    [TestFixture]
    public class CarHttpCommandsTests
    {
        [Test]
        public void Is_Instance_Of_RestServiceBase_CarInputDto()
        {
            var sut = new CarHttpCommands();
            Assert.IsInstanceOf(typeof(RestServiceBase<CarInputDTO>), sut);
        }

        [Test]
        public void OnGetMethod_Receives_Make_And_Model_CarInputDto_Data_And_Returns_Matching_Cars_From_Fake_Data()
        {
            var sut = new CarHttpCommands();
            var cars = (List<Car>)sut.OnGet(new CarInputDTO
            {
                Make = "Toyota",
                Model = "Prius"
            });

            Assert.AreEqual(9, cars.Count, "9 cars should be returned from fake data.");
        }

        [Test]
        public void OnGetMethod_No_Specified_Inputs_Returns_All_Cars_From_Fake_Data()
        {
            var sut = new CarHttpCommands();
            var cars = (List<Car>)sut.OnGet(new CarInputDTO
            {
            });

            Assert.AreEqual(18, cars.Count, "All 18 cars should be returned from fake data.");
        }

    }
}