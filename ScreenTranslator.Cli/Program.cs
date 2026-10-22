using ScreenTranslator.Core;
using ScreenTranslator.Core.Ocr;

using var ocr = new RapidOcrEngine(
    det: "./Models/ch_PP-OCRv4_det_mobile.onnx",
    cls: "./Models/ch_ppocr_mobile_v2.0_cls_mobile.onnx",
    rec: "./Models/japan_PP-OCRv4_rec_mobile.onnx",
    keys: "./Models/japan_dict.txt"
);

Console.WriteLine(ocr.Read(args[0]));