﻿using System.Web.Http;
using System.Web.Http.Cors;

namespace Battleships.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
