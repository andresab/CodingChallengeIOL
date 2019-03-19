using CodingChallenge.Data.Enums;
using System.Linq;

namespace CodingChallenge.Data.Services
{
    public static class TranslatorService
    {
        public static Idioma Idioma { get; set; }

        public static string Translate(string key, params object[] values)
        {
            var text = string.Empty;
            switch (Idioma)
            {
                case Idioma.ENG:
                    text = Resources.ENG.ResourceManager.GetString(key);
                    break;
                case Idioma.ESP:
                    text = Resources.ESP.ResourceManager.GetString(key);
                    break;
                default:
                    text = Resources.ESP.ResourceManager.GetString(key);
                    break;
            }
            return values?.Any() ?? false ? string.Format(text, values) : text;
        }

        public static string Pluralize(string name, int cantidad)
        {
            var text = Translate(name);
            return cantidad > 1 ? $"{text}s" : text;
        }
    }
}
