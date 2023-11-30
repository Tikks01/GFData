using GFDataApi.Enums;
using GFDataApi.Utils;
using System.Collections;
using System.Numerics;

namespace GFDataApi.DataTypes
{
    public class RestrictClass
    {
        private BitArray _BitArray = new BitArray(128);
        public RestrictClass() { }
        public void LoadFromHexString( string hexString )
        {
            if ( string.IsNullOrEmpty( hexString ) )
            {
                _BitArray = new BitArray(128);
                return;
            }

            var i = Int128.Parse( hexString, System.Globalization.NumberStyles.HexNumber );
            var bytes = ((BigInteger)i).ToByteArray();

            _BitArray = new BitArray(bytes);
        }
        public override string ToString()
        {
            return IniEditorUtils.ConvertBitsetToHexString( _BitArray );
        }

        public long AsLong()
        {
            byte[] b = new byte[128];

            _BitArray.CopyTo(b, 0);

            long l = BitConverter.ToInt64(b);

            return l;
        }
        public void LoadFromLong( long value )
        {
            var bytes = ((BigInteger)value).ToByteArray();

            _BitArray = new BitArray(bytes);
        }
    }
}
