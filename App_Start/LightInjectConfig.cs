using AutoMapper;
using LightInject;
using System.Collections.Generic;

namespace CarApi.App_Start
{
    public static class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new AutoMapperProfile()}));

            container.Register(c => config.CreateMapper());
        }
    }
}