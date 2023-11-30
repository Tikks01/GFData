using GFDataApi.DataTypes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GFDataApi.JsonConverters
{
    public class EnchantCommandsJsonConverter : JsonConverter<EnchantCommands>
    {
        public override EnchantCommands? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) { throw new JsonException("Expected start of array"); }

            EnchantCommands cmds = new EnchantCommands();

            int i = 0;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray) {
                    break;
                }

                if (reader.TokenType != JsonTokenType.StartObject)
                {
                    throw new JsonException("Expected start of object");
                }

                if (i > cmds.Max())
                {
                    throw new JsonException($"Array contains more than {cmds.Max()} EnchantCommands");
                }

                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndObject)
                    {
                        break;
                    }

                    if (reader.TokenType != JsonTokenType.PropertyName)
                    {
                        throw new JsonException("Expected property name");
                    }

                    string propertyName = reader.GetString();

                    reader.Read();

                    switch (propertyName)
                    {
                        case "Id":
                            cmds.GetEnchant(i).Id = reader.GetUInt32();
                            break;
                        case "Param1":
                            cmds.GetEnchant(i).Param1 = reader.GetDouble();
                            break;
                        case "Param2":
                            cmds.GetEnchant(i).Param2 = reader.GetDouble();
                            break;
                        case "Param3":
                            cmds.GetEnchant(i).Param3 = reader.GetDouble();
                            break;
                        case "Param4":
                            cmds.GetEnchant(i).Param4 = reader.GetDouble();
                            break;
                        case "Param5":
                            cmds.GetEnchant(i).Param5 = reader.GetDouble();
                            break;
                        case "Param6":
                            cmds.GetEnchant(i).Param6 = reader.GetDouble();
                            break;
                        default:
                            throw new JsonException($"Unexpected property: {propertyName}");
                    }
                }

                i++;
            }

            return cmds;
        }        
        public override void Write(Utf8JsonWriter writer, EnchantCommands value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Max(); i++)
            {
                writer.WriteStartObject();
                writer.WriteNumber("Id", value.GetEnchant(i).Id);
                writer.WriteNumber("Param1", value.GetEnchant(i).Param1);
                writer.WriteNumber("Param2", value.GetEnchant(i).Param2);
                writer.WriteNumber("Param3", value.GetEnchant(i).Param3);
                writer.WriteNumber("Param4", value.GetEnchant(i).Param4);
                writer.WriteNumber("Param5", value.GetEnchant(i).Param5);
                writer.WriteNumber("Param6", value.GetEnchant(i).Param6);
                writer.WriteEndObject();
            }                        
            writer.WriteEndArray();
        }
    }
}
