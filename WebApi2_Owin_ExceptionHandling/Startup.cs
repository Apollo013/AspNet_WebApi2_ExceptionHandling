using Microsoft.Owin;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApi2_Owin_ExceptionHandling.Startup))]

namespace WebApi2_Owin_ExceptionHandling
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            ConfigureRouting(config);

            ConfigureJsonMessageFormat(config);

            app.UseWebApi(config);
        }

        private static void ConfigureRouting(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }

        private static void ConfigureJsonMessageFormat(HttpConfiguration config)
        {
            var jsonFormat = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormat.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonFormat.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }
    }

}
