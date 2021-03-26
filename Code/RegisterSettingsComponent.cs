using System;
using System.Web.Http;
using Umbraco.Core.Composing;

namespace CarApi.Code
{
    public class RegisterSettingsComponent : IComponent
    {
        public void Initialize()
        {
            GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}