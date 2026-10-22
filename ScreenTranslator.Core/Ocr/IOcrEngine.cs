using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenTranslator.Core.Ocr
{
    public interface IOcrEngine
    {
        string Read(string imagePath);
    }
}