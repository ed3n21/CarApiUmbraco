using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace CarApi.Swagger
{
    public class UmbracoSwaggerFilter : IDocumentFilter
    {
        // Prevents from displaying uncustom umbraco APIs in Swagger UI
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths = swaggerDoc
                .paths
                .Where(x => x.Key.StartsWith("/api"))
                .ToDictionary(e => e.Key, e => e.Value);
        }
    }
}