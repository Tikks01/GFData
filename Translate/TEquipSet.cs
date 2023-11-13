using GFDataApi.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.Translate
{  
    public class TEquipSet : TranslationLanguages<uint>
    {
        private static readonly int Columns = 2;
        public TEquipSet() : base(Columns) {
            FileName = "T_EquipSet";
        }
    }
}
