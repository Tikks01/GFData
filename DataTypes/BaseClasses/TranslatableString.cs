namespace GFDataApi.DataTypes.BaseClasses
{
    public class TranslatableString
    {
        private Dictionary<ELanguages, string> Translations = new();

        public TranslatableString()
        {
        }

        public TranslatableString(string defaultValue)
        {
            Translations[ELanguages.Chinese] = defaultValue;
        }

        public void Set(ELanguages Lang, string? value)
        {
            Translations[Lang] = value ?? string.Empty;
        }

        public string Get(ELanguages Lang)
        {
            if (!Translations.ContainsKey(Lang)) return string.Empty;

            return Translations[Lang];
        }
    }
}
