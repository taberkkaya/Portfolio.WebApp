using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.ContactPages.GetContactPage;

public sealed class GetContactPageCommandHandler(
    IContactRepository contactRepository
    ) : IRequestHandler<GetContactPageCommand, Result<ContactPage>>
{
    public async Task<Result<ContactPage>> Handle(GetContactPageCommand request, CancellationToken cancellationToken)
    {
        var contact = await contactRepository.GetFirstAsync();
        return contact;
    }
}
