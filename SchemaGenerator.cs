using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemaApp
{
    public class SchemaGenerator
    {
        private static readonly JSchemaGenerator jSchemaGenerator = new();
        private static readonly string _uri = "https://json-schema.org/draft/2019-09/schema";

        public static JSchema Generate<T>(string description) where T : class, new()
        {

            jSchemaGenerator.GenerationProviders.Add(new StringEnumGenerationProvider());
            var schemas = jSchemaGenerator.Generate(typeof(T));

            schemas.SchemaVersion = new Uri(_uri);
            schemas.Description = description;

            return schemas;
        }
    }

}
