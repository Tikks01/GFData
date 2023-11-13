using GFDataApi.DataTypes;
using GFDataApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.Utils
{
    public class IniLineMaker
    {
        StringBuilder _SB;
        public IniLineMaker() { 
            _SB = new StringBuilder();
        }

        public void Put(string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _SB.Append(value);
            }

            _SB.Append('|');
        }

        public void Put(int value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(uint value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(long value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(ulong value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(short value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(ushort value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(byte value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }        

        public void Put(sbyte value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString().TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(float value)
        {
            if (value != 0)
            {
                _SB.Append(value.ToString(System.Globalization.CultureInfo.InvariantCulture).TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put<EnumType>(Enum value) where EnumType : Enum
        {

            object val = Convert.ChangeType(value, typeof(int));                       

            if (val != null) {
                _SB.Append(val?.ToString()?.TrimStart('0'));
            }

            _SB.Append('|');
        }

        public void Put(double value, bool DisplayZeros = false)
        {            
            if (DisplayZeros || value != 0)
            {
                var str = value.ToString(System.Globalization.CultureInfo.InvariantCulture);
                if (str.Count(f => f == '0') > 1)
                    str = str.TrimStart('0');
                _SB.Append(str);
            }

            _SB.Append('|');
        }        

        public void Put(ERestrictClass value)
        {
            var str = ((ulong)value).ToString();

            if (str.Length > 12)
            {
                _SB.Append(string.Format("{0:X}", value).TrimStart('0'));
            } else
            {
                _SB.Append(str.TrimStart('0'));
            }
                    
            //_SB.Append( string.Format("{0:X}", value).TrimStart('0') );
            _SB.Append('|');
        }

        public void Put(RestrictClass value)
        {
            _SB.Append(value.ToString());
            _SB.Append('|');
        }

        public void Put(SumAddAttrs value)
        {
            _SB.Append(value.ToString());
            _SB.Append("|");
        }

        public string GetString()
        {
            return _SB.ToString();
        }
    }
}
