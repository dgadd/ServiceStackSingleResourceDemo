using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarShare.RestAPI.Host;
using NUnit.Framework;
using ServiceStack.WebHost.Endpoints;

namespace CarShare.RestAPI.Tests.Unit
{
    [TestFixture]
    public class CarShareAppHostTests
    {
        [Test]
        public void Is_Instance_Of_AppHostBase()
        {
            var sut = new CarShareAppHost();
            Assert.IsInstanceOf(typeof(AppHostBase), sut);
        }
    }
}
