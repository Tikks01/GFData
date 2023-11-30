using GFDataApi.Config;
using GFDataApi.Enums;

namespace GFDataApi.BaseClasses
{
    public class TranslationLanguages<IdType> where IdType : notnull
    {
        private readonly Dictionary<ETranslationLanguages, Translation<IdType>> _TranslationLanguages;
        protected string FileName = "";

        public TranslationLanguages(int Columns)
        {
            _TranslationLanguages = new Dictionary<ETranslationLanguages, Translation<IdType>>();

            foreach (var lang in Enum.GetValues<ETranslationLanguages>())
            {
                _TranslationLanguages.Add( lang, new Translation<IdType>(Columns) );
            }
        }        

        public Translation<IdType>? Language(ETranslationLanguages language)
        {
            _TranslationLanguages.TryGetValue(language, out var translation);
            return translation;
        }

        public virtual async Task<bool> Load()
        {
            return await Task.Run(() =>
            {
                string pathTranslate = GFConfiguration.Instance.Data.PathToTranslate;

                if (!Path.Exists(pathTranslate))
                {
                    return false;
                }

                foreach (var lang in Enum.GetValues<ETranslationLanguages>())
                {
                    string filePath = Path.Combine(pathTranslate, FileName + "_" + lang.ToString() + ".ini");

                    if (!File.Exists(filePath))
                    {
                        continue;
                    }

                    _TranslationLanguages[lang].Load(filePath);
                }

                return true;
            });
        }
    }
}
