using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Pages
{
    public class JsonNetResult : JsonResult
    {
        public Newtonsoft.Json.JsonSerializerSettings SerializerSettings { get; set; }

        public Formatting Formatting { get; set; }

        public JsonNetResult()
        {
            SerializerSettings = new JsonSerializerSettings();
        }
        public JsonNetResult(object obj)
        {
            SerializerSettings = new JsonSerializerSettings();
            Data = obj;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType =
                !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json    ";
            if (ContentEncoding != null)
                response.ContentEncoding = ContentEncoding;
            if (Data != null)
            {
                JsonTextWriter writer = new JsonTextWriter(response.Output)
                {
                    Formatting = Formatting
                };
                JsonSerializer serializer = JsonSerializer.Create(SerializerSettings);
                serializer.Serialize(writer, Data); writer.Flush();
            }
        }
    }
}