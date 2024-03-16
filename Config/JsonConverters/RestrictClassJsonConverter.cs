using GFDataApi.DataTypes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GFDataApi.Config.JsonConverters
{
    public class RestrictClassJsonConverter : JsonConverter<RestrictClass>
    {
        public override RestrictClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var result = new RestrictClass();
            result.LoadFromLong(reader.GetInt64());
            return result;
        }

        public override void Write(Utf8JsonWriter writer, RestrictClass value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.AsLong());
        }
    }
}
