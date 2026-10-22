using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidOcrNet;

namespace JPImageTranslator.Core.Ocr
{
    public class RapidOcrEngine : IOcrEngine, IDisposable
    {
        private readonly RapidOcr _ocr = new();
        public RapidOcrEngine(string det, string cls, string rec, string keys)
        {
            _ocr.InitModels(detPath: det, clsPath: cls, recPath: rec, keysPath: keys);
        }
        public async Task<string> Read(string imagePath)
        {
            var result = await _ocr.DetectAsync(imagePath, RapidOcrOptions.Default);
            return result.StrRes;
        } 
        public void Dispose() => _ocr.Dispose();
        
    }
}