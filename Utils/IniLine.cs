using System.Globalization;

namespace GFDataApi.Utils
{
    public class IniLine
    {
        string[] Columns;
        private int CurrentColumn = 0;
        public string CompleteString { get; private set; }
        public IniLine(string line) {
            CompleteString = line;
            Columns = line.Split('|');
            typeConverters = new();

            initilizeConverters();
        }

        public bool EndOfLine(bool isTranslation = false)
        {                            
            return !(CurrentColumn < Columns.Length - 1);            

            //return !(CurrentColumn < Columns.Length);
        }        

        public bool FirstColumn()
        {
            return CurrentColumn == 0;
        }

        private Dictionary<Type, Func<object>> typeConverters;        

        private void initilizeConverters()
        {
            typeConverters.Add(typeof(int), () => {
                if (int.TryParse(Columns[CurrentColumn], out int outValue))
                {                    
                    return outValue;
                }

                return 0;
            });

            typeConverters.Add(typeof(uint), () =>
            {
                if (uint.TryParse(Columns[CurrentColumn], out uint outValue))
                {
                    return outValue;
                }

                return 0u;
            });

            typeConverters.Add(typeof(byte), () =>
            {
                if (byte.TryParse(Columns[CurrentColumn], out byte outValue))
                {
                    return outValue;
                }

                return (byte)0;
            });

            typeConverters.Add(typeof(sbyte), () =>
            {
                if (sbyte.TryParse(Columns[CurrentColumn], out sbyte outValue))
                {
                    return outValue;
                }

                return (sbyte)0;
            });

            typeConverters.Add(typeof(short), () =>
            {
                if (short.TryParse(Columns[CurrentColumn], out short outValue))
                {                    
                    return outValue;
                }

                return (short)0;
            });

            typeConverters.Add(typeof(ushort), () =>
            {
                if (ushort.TryParse(Columns[CurrentColumn], out ushort outValue))
                {
                    return outValue;
                }

                return (ushort)0;
            });

            typeConverters.Add(typeof(long), () =>
            {
                if (Columns[CurrentColumn] == string.Empty)
                {
                    return 0L;
                }


                if (long.TryParse(Columns[CurrentColumn], out long outValue))
                {
                    return outValue;
                }

                var fromHex = Convert.ToUInt64(Columns[CurrentColumn], 16);

                if (fromHex != 0)
                {
                    return fromHex;
                }

                return 0L;
            });

            typeConverters.Add(typeof(ulong), () =>
            {
                if (Columns[CurrentColumn] == string.Empty)
                {
                    return 0UL;
                }


                if (ulong.TryParse(Columns[CurrentColumn], out ulong outValue))
                {
                    return outValue;
                }

                var fromHex = Convert.ToUInt64(Columns[CurrentColumn], 16);

                if (fromHex != 0)
                {
                    return fromHex;
                }

                return 0UL;
            });

            typeConverters.Add(typeof(string), () =>
            {
                string value = Columns[CurrentColumn].Replace("{U+000D}{U+000A}", "\r\n");
                return value;
            });

            typeConverters.Add(typeof(float), () =>
            {
                if (float.TryParse(Columns[CurrentColumn], CultureInfo.InvariantCulture.NumberFormat, out float outValue))
                {
                    return outValue;
                }

                return 0f;
            });

            typeConverters.Add(typeof(double), () =>
            {
                if (double.TryParse(Columns[CurrentColumn], CultureInfo.InvariantCulture.NumberFormat, out double outValue))
                {
                    return outValue;
                }

                return 0D;
            });            
        }


        public T? Next<T>()
        {
            T? value = default;
            if (typeConverters.TryGetValue(typeof(T), out var converter))
            {                
                value = (T)converter();                
            }
            
            if (typeof(T).IsEnum)
            {
                value = convertEnum<T>();
            }

            CurrentColumn++;
            return value;
        }

        public int Next(string value)
        {
            if (int.TryParse(Columns[CurrentColumn], out int outValue))
            {               
                return outValue;
            }

            return 0;
        }

        private T? convertEnum<T>()
        {            
            string value = Columns[CurrentColumn];
            if (Enum.TryParse(typeof(T), value, out object? outValue)) {
                return (T)outValue;
            }

            return default;
        } 
    }
}
