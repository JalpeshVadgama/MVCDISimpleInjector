using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVCDISimpleInjector.Models;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace MVCDISimpleInjector
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Code for registering our repository class and DI
            var container = new Container();
            container.Register<ICustomerRepository, CustomerRepository>();

            // This two extension method from integration package
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            DependencyResolver.SetResolver(
                new SimpleInjectorDependencyResolver(container));
        }
    }
}
