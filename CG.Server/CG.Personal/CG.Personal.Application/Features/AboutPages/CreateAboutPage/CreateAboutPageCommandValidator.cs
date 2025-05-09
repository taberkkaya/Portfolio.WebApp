using FluentValidation;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.CreateAboutPage;

public sealed class CreateAboutPageCommandValidator : AbstractValidator<CreateAboutPageCommand>
{
    public CreateAboutPageCommandValidator()
    {
        
    }
}
