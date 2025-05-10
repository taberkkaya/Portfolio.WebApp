using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Documents.CreateDocument;

public sealed class CreateDocumentCommand : IRequest<Result<string>>
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IFormFile? CoverImgUrl { get; set; }
    public IFormFile? DocumentUrl { get; set; }
    public Guid DocumentCategoryId { get; set; }
    public bool IsFeatured { get; set; }
}



