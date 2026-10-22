using JPImageTranslator.Core;
using JPImageTranslator.Core.Ocr;
using JPImageTranslator.Core.Translation;

using var ocr = new RapidOcrEngine(
    det: "./Models/ch_PP-OCRv4_det_mobile.onnx",
    cls: "./Models/ch_ppocr_mobile_v2.0_cls_mobile.onnx",
    rec: "./Models/japan_PP-OCRv4_rec_mobile.onnx",
    keys: "./Models/japan_dict.txt"
);

if (args.Length == 0 || string.IsNullOrWhiteSpace(args[0]))
{
    Console.WriteLine("No se ha ingresado una ruta de archivo");
    return;
}
string imagePath = args[0];

if (!File.Exists(imagePath))
{
    Console.WriteLine("El archivo no existe");
    return;
}

string ocrResult = await ocr.Read(imagePath);

if (string.IsNullOrWhiteSpace(ocrResult))
{
    Console.WriteLine("Error de lectura");
}
Console.WriteLine($"Texto a traducir: {ocrResult}\n");
var translator = new Translator();
if (!string.IsNullOrWhiteSpace(ocrResult))
{
    var translation = await translator.Translate(ocrResult);
    Console.WriteLine($"Traduccion: {translation}\n");
}