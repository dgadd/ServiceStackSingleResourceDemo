using System;
using System.Reflection;
using CarShare.RestAPI.InputDTOs;
using Funq;
using ServiceStack.Text;
using ServiceStack.WebHost.Endpoints;

namespace CarShare.RestAPI.Host
{
    public class CarShareAppHost : AppHostBase
    {
        public CarShareAppHost(): base("CarShare REST API", typeof(CarShareAppHost).Assembly)
        {
            JsConfig.EmitCamelCaseNames = true;
            JsConfig.ExcludeTypeInfo = false;
        }

        public override void Configure(Container container)
        {
            RegisterRESTpaths();
        }

        private void RegisterRESTpaths()
        {
            Routes
                .Add<CarInputDTO>("/v1/cars");
        }
    }
}