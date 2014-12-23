using System;
using System.Web.Http;
using Kompliant.AppStart;
using Kompliant.Models;

namespace Kompliant
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Data.Entity.Database.SetInitializer(new KompliantContextInitializer());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}