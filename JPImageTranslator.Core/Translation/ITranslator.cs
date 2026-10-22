using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPImageTranslator.Core.Translation
{
    public interface ITranslator
    {
        Task<string> Translate(string ocr);
    }
}