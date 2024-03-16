using GFDataApi.Utils;
using GFIniFileEditor.Utils;
using System.Text;

namespace GFDataApi.DataTypes.BaseClasses
{
    public class Translation<IdType> where IdType : notnull
    {
        private Dictionary<IdType, TranslationItemList> _Translations;
        private int _Columns;

        public TranslationItemList? this[IdType index]
        {
            get
            {
                return ById(index);
            }
        }

        public Translation(int columns)
        {
            _Columns = columns;
            _Translations = new Dictionary<IdType, TranslationItemList>();
        }
        public void Add(IdType id, List<string> translation)
        {
            _Translations.TryGetValue(id, out var list);

            if (!_Translations.ContainsKey(id))
            {
                var trans = new TranslationItemList(_Columns - 1);
                trans.SetTranslation(translation);
                _Translations.Add(id, trans);
            }
        }

        public int Count()
        {
            return _Translations.Count;
        }

        public bool Load(string Path)
        {
            CIniFile file = new CIniFile();
            Encoding enc = Encoding.Latin1;
            file.LoadTranslation(Path, _Columns, enc);

            foreach (IniLine line in file.Values)
            {
                var translate = new TranslationItemList(_Columns - 1);
                IdType? Id = default;

                int index = 0;
                while (!line.EndOfLine())
                {
                    if (line.FirstColumn())
                    {
                        Id = line.Next<IdType>();
                    }
                    else
                    {
                        translate.Add(line.Next<string>()!);
                    }

                    index++;
                }

                if (_Translations.ContainsKey(Id))
                {
                    _Translations[Id] = translate;
                }
                else
                {
                    _Translations.Add(Id!, translate);
                }
            }

            return true;
        }

        public TranslationItemList? ById(IdType index)
        {
            if (_Translations.ContainsKey(index))
            {
                return _Translations[index];
            }

            return null;
        }

        public Dictionary<IdType, TranslationItemList> Translations()
        {
            return _Translations;
        }
    }
}
