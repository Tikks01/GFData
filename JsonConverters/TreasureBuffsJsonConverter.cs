using GFDataApi.DataTypes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GFDataApi.JsonConverters
{
    public class TreasureBuffsJsonConverter : JsonConverter<TreasureBuffs>
    {
        public override TreasureBuffs? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Array Expected: TreasureBuffs");
            }

            TreasureBuffs buffs = new TreasureBuffs();

            for (int i = 0; i < buffs.Count(); i++)
            {
                buffs.Set(i, reader.GetInt32());
            }

            return buffs;
        }
        public override void Write(Utf8JsonWriter writer, TreasureBuffs value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            for (int i = 0; i < value.Count(); i++)
            {
                writer.WriteNumberValue(value.Get(i));
            }
            
            writer.WriteEndArray();
        }
    }
}
