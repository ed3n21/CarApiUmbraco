using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace CarApi.Code
{
    public class CustomComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<RegisterSettingsComponent>();
        }
    }
}