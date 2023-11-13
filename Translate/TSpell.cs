using GFDataApi.BaseClasses;
using GFDataApi.Querys.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.Translate
{
    public class TSpell : TranslationLanguages<int>
    {
        private static readonly int Columns = 3;
        public TSpell() : base(Columns) {
            FileName = "T_Spell";
        }        
    }
}
