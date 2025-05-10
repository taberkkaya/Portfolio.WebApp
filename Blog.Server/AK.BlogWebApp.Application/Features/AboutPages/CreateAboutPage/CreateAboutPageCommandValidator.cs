using FluentValidation;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.CreateAboutPage;

public sealed class CreateAboutPageCommandValidator : AbstractValidator<CreateAboutPageCommand>
{
    public CreateAboutPageCommandValidator()
    {
        
    }
}
