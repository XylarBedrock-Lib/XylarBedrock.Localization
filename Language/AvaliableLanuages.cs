using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XylarBedrock.Localization.Language
{
    public static class AvaliableLanuages
    {
        public static List<string> GetAll()
        {
            return new List<string>()
            {
                "en-US",
                "en-UD",
                "es-ES",
                "fr-FR",
                "fi-FI",
                "it-IT",
                "ms-MY",
                "pl-PL",
                "pt-BR",
                "pt-PT",
                "ru-RU",
                "tr-TR",
                "uk-UA",
                "zh-CN",
                "zh-TW"
            };
        }
    }
}

