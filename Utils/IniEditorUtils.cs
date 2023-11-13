using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace GFDataApi.Utils
{
    public class IniEditorUtils
    {
        public static object? getPropertieValue(string stringValue, Type propertyType)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                if (propertyType == typeof(string))
                {
                    return string.Empty;
                }

                return Activator.CreateInstance(propertyType);
            }

            if (IsNumericType(propertyType))
            {
                return ParseNumericType(propertyType, stringValue);
            }

            if (propertyType.IsEnum)
            {
                return ParseEnum(propertyType, stringValue);
            }

            if (propertyType == typeof(string))
            {
                return ParseStringType(stringValue);
            }

            throw new NotImplementedException(propertyType.Name);
        }

        static bool IsNumericType(Type type)
        {
            return type == typeof(int) || type == typeof(float) || type == typeof(double) ||
                   type == typeof(long) || type == typeof(uint) || type == typeof(short) ||
                   type == typeof(ushort) || type == typeof(ulong);
        }

        private static object ParseEnum(Type propertyType, string stringValue)
        {
            if (Enum.GetUnderlyingType(propertyType) == typeof(long))
            {
                long longValue = Convert.ToInt64(stringValue, 16);
                return Enum.ToObject(propertyType, longValue);
            }

            if (Enum.TryParse(propertyType, stringValue, out object? enumValue))
            {
                return enumValue;
            }

            throw new NotImplementedException(propertyType.Name + " " + stringValue);
        }

        private static object? ParseNumericType(Type propertyType, string stringValue)
        {
            if (TypeDescriptor.GetConverter(propertyType).IsValid(stringValue))
            {
                return Convert.ChangeType(stringValue, propertyType);
            }

            return default;
            //throw new Exception(propertyType.Name + ' ' + stringValue); //return default;
        }

        private static object ParseStringType(string stringValue)
        {
            return stringValue.Replace("{U+000D}{U+000A}", "\r\n");
        }

        public static bool ShouldIncludeValue(PropertyInfo prop, IniFileTarget target)
        {
            if (target == IniFileTarget.Both)
                return true;

            var attributes = prop.GetCustomAttributes(true);

            foreach (var attribute in attributes)
            {
                if (attribute is IniFile iniAttrib)
                {
                    return iniAttrib.Target == IniFileTarget.Both || iniAttrib.Target == target;
                }
            }

            return true;
        }

        public static string? GetStringValue(object? value, Type valueType)
        {
            if (value == null)
                return string.Empty;

            if (value is Enum)
            {
                return Convert.ToInt64(value).ToString();
            }

            if ((IsNumericType(valueType) || valueType.IsEnum) && Convert.ToInt64(value) == 0)
                return string.Empty;

            return value.ToString();
        }

        public static string ConvertBitsetToHexString(BitArray bitset)
        {
            /*if (bitset.Length != 128)
            {
                throw new ArgumentException("Bitset length must be 128.");
            }*/

            char[] hexChars = "0123456789ABCDEF".ToCharArray();
            char[] hexString = new char[bitset.Length];
            int hexStringIndex = 0;

            for (int i = bitset.Length - 1; i >= 0; i -= 4)
            {
                int nibble = 0;

                for (int j = 0; j < 4; j++)
                {
                    nibble <<= 1;
                    if (bitset[i - j])
                    {
                        nibble |= 1;
                    }
                }

                hexString[hexStringIndex++] = hexChars[nibble];
            }            
            return new string(hexString).TrimStart('0').TrimEnd('\0');
        }
    }
}
