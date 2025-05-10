using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.CreateAboutPage;

public sealed class CreateAboutPageCommand : IRequest<Result<string>>
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IFormFile? ImgUrl { get; set; }
}