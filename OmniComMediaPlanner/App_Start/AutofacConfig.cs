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
            builder.RegisterInstance(new CountryController(new Process.CountryProcess(new Repository.DAL.Country())));

            builder.RegisterInstance(new ClientController(new Process.ClientProcess(new Repository.DAL.Client())));
            builder.RegisterInstance(new MediaChannelController(new Process.MediaChannelProcess(new Repository.DAL.MediaChannel())));
            builder.RegisterInstance(new SupplierController(new Process.SupplierProcess(new Repository.DAL.Supplier())));

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