using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using Ninject.Mvc3;
using NHWebConsole;

namespace website
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        /*
        #region NHibernate stuff
        /// <summary>
        /// Create the Nhibernate Sessionfactory
        /// </summary>
        public static ISessionFactory SessionFactory = CreateSessionFactory();
        public MvcApplication()
        {
            this.BeginRequest += new EventHandler(MvcApplicationBeginRequest);
            this.EndRequest += new EventHandler(MvcApplicationEndRequest);
        }

        private static void MvcApplicationEndRequest(object sender, EventArgs e)
        {
            CurrentSessionContext.Unbind(SessionFactory).Dispose();
        }

        private static void MvcApplicationBeginRequest(object sender, EventArgs e)
        {
            CurrentSessionContext.Bind(SessionFactory.OpenSession());
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var cfg = new Configuration().Configure(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nhibernate.config"));
            return cfg.BuildSessionFactory();

        }
        #endregion
        */
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //ignore elmah route: http://code.google.com/p/elmah/wiki/MVC
            routes.IgnoreRoute("elmah.axd");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Parameter defaults
                new string [] {"Website.Controllers"} 
            );

        }

        private static void ConfigureNHWebConsole()
        {
            /*var cfg = BuildNHibernateConfiguration();
            var sessionFactory = cfg.BuildSessionFactory();
            NHWebConsoleSetup.OpenSession = () => sessionFactory.OpenSession();
            NHWebConsoleSetup.Configuration = () => cfg;*/
        }

        protected void Application_Start()
        {
            AppStart_NinjectMVC3.Start();

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}