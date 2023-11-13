using GFDataApi.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.Translate
{
    internal class TItem : TranslationLanguages<uint>
    {
        private static readonly int Columns = 3;

        public TItem() : base(Columns) {}

        public override async Task<bool> Load()
        {
            FileName = "T_ItemMall";
            var b = await base.Load();
            FileName = "T_Item";
            return await base.Load() && b;
        }
    }
}
