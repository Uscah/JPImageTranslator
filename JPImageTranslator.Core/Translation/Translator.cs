using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GTranslate.Translators;

namespace JPImageTranslator.Core.Translation
{
    public class Translator : ITranslator
    {
        public async Task<string> Translate(string ocr)
        {
            var translator = new GoogleTranslator();
            //change "es" to "en" for english translation
            var translation = await translator.TranslateAsync(ocr, "es");
            return translation.Translation;
        }
    }
}