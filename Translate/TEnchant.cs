using GFDataApi.BaseClasses;

namespace GFDataApi.Translate
{
    internal class TEnchant : TranslationLanguages<int>
    {
        private static readonly int Columns = 5;
        public TEnchant() : base(Columns) {
            FileName = "T_Enchant";
        }                       
    }
}
