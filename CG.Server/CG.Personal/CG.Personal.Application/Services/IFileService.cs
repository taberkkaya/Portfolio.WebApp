using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace CG.Personal.Application.Services;

public interface IFileService
{
    Task<string> UploadFile(IFormFile file, string folderName);
    bool DeleteFile(string fileName, string folderName);

}
