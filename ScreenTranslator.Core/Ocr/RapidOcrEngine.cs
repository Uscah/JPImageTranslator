using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidOcrNet;

namespace ScreenTranslator.Core.Ocr
{
    public class RapidOcrEngine : IOcrEngine, IDisposable
    {
        private readonly RapidOcr _ocr = new();
        public RapidOcrEngine(string det, string cls, string rec, string keys)
        {
            _ocr.InitModels(detPath: det, clsPath: cls, recPath: rec, keysPath: keys);
        }
        public string Read(string imagePath) => _ocr.Detect(imagePath, RapidOcrOptions.Default).StrRes;
        public void Dispose() => _ocr.Dispose();
        
    }
}