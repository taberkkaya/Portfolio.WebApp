using System.Globalization;
using CG.Personal.Application.Services;
using Microsoft.AspNetCore.Http;

namespace CG.Personal.Infrastructure.Services
{
    internal sealed class FileService : IFileService
    {
        public bool DeleteFile(string fileName, string folderName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", folderName, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }

            return false;
        }

        public async Task<string> UploadFile(IFormFile file, string folderName)
        {
            var extension = Path.GetExtension(file.FileName);
            var originalName = Path.GetFileNameWithoutExtension(file.FileName);

            // Temiz ve güvenli dosya adı
            var safeName = string.Concat(originalName
                .Where(c => !Path.GetInvalidFileNameChars().Contains(c)))
                .Replace(" ", "_");

            // Aynı ada sahip dosya varsa tekrar eklenmesin diye timestamp
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture);

            var fileName = $"{safeName}_{timestamp}{extension}";
            var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", folderName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var fullPath = Path.Combine(directoryPath, fileName);

            using var stream = new FileStream(fullPath, FileMode.Create);
            await file.CopyToAsync(stream);

            return fileName;
        }
    }
}
