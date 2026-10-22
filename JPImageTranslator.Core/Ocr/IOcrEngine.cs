using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPImageTranslator.Core.Ocr
{
    public interface IOcrEngine
    {
        Task<string> Read(string imagePath);
    }
}