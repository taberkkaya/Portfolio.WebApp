using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.UpdateDocuments;

public sealed class UpdateDocumentCommand : IRequest<Result<string>>
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? CoverImgUrl { get; set; }
    public IFormFile? NewImgUrl { get; set; }
    public string? DocumentUrl { get; set; }
    public IFormFile? NewDocument { get; set; }
    public Guid DocumentCategoryId { get; set; }
    public bool IsFeatured { get; set; }
}
