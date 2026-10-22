# JPImageTranslator

> Una herramienta de consola en C# ligera y rápida para traducir texto japones en imágenes o capturas de pantalla.

## Características

- **Traducción rápida:** Procesa imágenes en japones y extrae/traduce el contenido directamente desde la consola utilizando **Google Translate**.
- **Desarrollado en C# (.NET):** Ligero, eficiente y fácil de ejecutar.

---

## Tecnologias utilizadas

- C# .NET 10
- RapidOcrNet
- Google Translate API

---

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versión 10.x).

---

## Instalación y Configuración

1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/Uscah/JPImageTranslator.git
   cd JPImageTranslator
   ```
2. **Instalar paquetes:**
   ```bash
   dotnet restore
   ```
3. **Ejecutar:**
   ```bash
   cd JPImageTranslator.Cli
   dotnet run -- ruta-de-imagen
   ```
