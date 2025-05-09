using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.UpdateAboutPage;

public sealed class UpdateAboutPageCommand : IRequest<Result<string>>
{
    public Guid Id {get;set;}
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImgUrl { get; set; } = string.Empty;
    public IFormFile? NewImg { get; set; }
    public bool isActive { get; set; }
}
