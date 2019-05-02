using Autofac;
using Autofac.Integration.WebApi;
using OmniComMediaPlanner.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace OmniComMediaPlanner.App_Start
{
    public class AutofacConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.
            builder.RegisterType<CountryController>().WithParameter("bl", (new Process.CountryProcess(new Repository.DAL.Country()))).InstancePerRequest();// (new Process.CountryProcess(new Repository.DAL.Country()))).InstancePerRequest();

            builder.RegisterType<ClientController>().WithParameter("bl",new Process.ClientProcess(new Repository.DAL.Client())).InstancePerRequest();
            builder.RegisterType<MediaChannelController>().WithParameter("bl",new Process.MediaChannelProcess(new Repository.DAL.MediaChannel())).InstancePerRequest();
            builder.RegisterType<SupplierController>().WithParameter("bl",new Process.SupplierProcess(new Repository.DAL.Supplier())).InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}