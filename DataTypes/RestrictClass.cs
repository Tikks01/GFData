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

        /*public ERestrictClass AsEnum()
        {
            ERestrictClass eRestrictClass = ERestrictClass.None;

            for (int i = 0; i < _BitArray.Length; i++)
            {
                if (_BitArray[i])
                {
                    eRestrictClass |= (ERestrictClass)(1 << i);
                }
            }
            
            return eRestrictClass;
        }

        public void SetFromEnum( ERestrictClass eRestrictClass )
        {
            long i = (long)eRestrictClass;
           
            var bytes = ((BigInteger)i).ToByteArray();
            _BitArray = new BitArray(bytes);
        }*/
    }
}
