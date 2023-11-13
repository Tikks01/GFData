using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.BaseClasses
{
    public class TranslationItemList
    {
        private List<String> _Translations;
        private int maxTranslations;        

        public TranslationItemList(int MaxTranslations) { 
            _Translations = new List<String>(MaxTranslations);
            maxTranslations = MaxTranslations;
        }

        public bool Add(string value)
        {
            if (_Translations.Count < maxTranslations)
            {
                _Translations.Add(value);
                return true;
            }

            return false;
        }

        public string this[int index] { 
            get { 
                return GetTranslation(index)!; 
            } set { 
                SetTranslation(index, value); 
            } 
        }

        public void SetTranslation(int index, string value)
        {
            if (index >= 0 && index < maxTranslations)
            {
                _Translations[index] = value;
            }            
        }

        public string? GetTranslation(int index) {
            if (index >= 0 && index < maxTranslations && _Translations[index] != null)
            {
                return _Translations[index];
            }
            return null;
        }

        public void SetTranslation(List<String> values)
        {           
            _Translations = values;
        }

    }
}
