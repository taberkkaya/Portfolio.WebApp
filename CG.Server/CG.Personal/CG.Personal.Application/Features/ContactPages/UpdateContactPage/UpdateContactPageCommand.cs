using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.ContactPages.UpdateContactPage;

public sealed record UpdateContactPageCommand(
    string Title,
    string Description,
    string Email,
    string PhoneNumber
    ) : IRequest<Result<string>>;

public sealed class UpdateContactPageCommandHandler(
    IContactRepository contactRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork
    ) : IRequestHandler<UpdateContactPageCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateContactPageCommand request, CancellationToken cancellationToken)
    {
        var contact = await contactRepository.GetFirstAsync();
        mapper.Map(request,contact);
        contactRepository.Update(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "İletişim bilgileri başarıyla güncellendi!!";
    }
}
