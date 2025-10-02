// File: BeebopNovuMinimal.Android/Infrastructure/Services/AndroidFileService.cs
using BeebopNovuMinimal.Domain.Interfaces;
using System;
using System.IO;

namespace BeebopNovuMinimal.Android.Infrastructure.Services
{
    public class AndroidFileService : IPlatformFileService
    {
        public string GetAppDataPath()
        {
            // Example: use Android's personal folder
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        public void SaveFile(string filename, string content)
        {
            var path = Path.Combine(GetAppDataPath(), filename);
            File.WriteAllText(path, content);
        }

        public string ReadFile(string filename)
        {
            var path = Path.Combine(GetAppDataPath(), filename);
            return File.Exists(path) ? File.ReadAllText(path) : string.Empty;
        }
    }
}
