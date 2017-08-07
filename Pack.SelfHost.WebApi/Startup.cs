using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Pack.SelfHost.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.EnableCors();
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
            config.Formatters.Add(new BsonMediaTypeFormatter());

            config.Routes.MapHttpRoute(
                name: "ListColor",
                routeTemplate: "ListColor",
                defaults: new {
                    Controller = "Color",
                    Action = "ListColor"
                });

            config.Routes.MapHttpRoute(
                name: "InsertColor",
                routeTemplate: "InsertColor/{color}/{translate}",
                defaults: new
                {
                    Controller = "Color",
                    Action = "InsertColor"
                });

            config.Routes.MapHttpRoute(
                name: "UpdateColor",
                routeTemplate: "UpdateColor/{color}/{translate}",
                defaults: new
                {
                    Controller = "Color",
                    Action = "UpdateColor"
                });

            config.Routes.MapHttpRoute(
                name: "DeleteColor",
                routeTemplate: "DeleteColor/{color}",
                defaults: new
                {
                    Controller = "Color",
                    Action = "DeleteColor"
                });

            app.UseWebApi(config);
        }
    }
}
