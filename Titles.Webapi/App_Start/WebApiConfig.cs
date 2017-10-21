﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

namespace Titles.Webapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            json.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            json.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
        }
    }
}
