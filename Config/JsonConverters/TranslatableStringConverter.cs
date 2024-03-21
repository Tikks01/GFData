using GFDataApi.DataTypes;
using GFDataApi.DataTypes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GFDataApi.Config.JsonConverters
{
    internal class TranslatableStringConverter : JsonConverter<TranslatableString>
    {
        public override TranslatableString? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException("Expected StartArray token");

            TranslatableString ts = new();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    return ts;

                if (reader.TokenType != JsonTokenType.String)
                    throw new JsonException("Expected String token");

                // Read key
                ELanguages key = Enum.Parse<ELanguages>(reader.GetString());

                // Read value
                reader.Read();
                if (reader.TokenType != JsonTokenType.String)
                    throw new JsonException("Expected String token");

                string? value = reader.GetString();
                ts.Set(key, value ?? string.Empty);
            }

            throw new JsonException("Invalid JSON format");
        }

        public override void Write(Utf8JsonWriter writer, TranslatableString value, JsonSerializerOptions options)
        {
            //writer.WriteStartObject();
            //writer.WriteStringValue(value.Get(ELanguages.Chinese));
            writer.WriteStartArray();

            foreach (ELanguages item in Enum.GetValues(typeof(ELanguages)))
            {
                writer.WriteStartObject();
                writer.WriteNumber("Language", (int)item);
                writer.WriteString("Value", value.Get(item));
                writer.WriteEndObject();
            }

            writer.WriteEndArray();
            //writer.WriteEndObject();
        }
    }
}
