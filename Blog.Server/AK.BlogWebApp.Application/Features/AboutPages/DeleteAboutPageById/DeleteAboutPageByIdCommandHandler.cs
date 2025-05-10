using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK.BlogWebApp.Application.Services;
using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.DeleteAboutPageById
{
    public sealed class DeleteAboutPageByIdCommandHandler(
        IAboutPageRepository aboutPageRepository,
        IFileService fileService,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteAboutPageByIdCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(DeleteAboutPageByIdCommand request, CancellationToken cancellationToken)
        {
            AboutPage? aboutPage = await aboutPageRepository.GetByExpressionAsync(p => p.Id == request.Id);

            if (aboutPage is null)
            {
                return Result<string>.Failure("Hakkımda sayfası bulunamadı!");
            }

            if (aboutPage.IsActive)
            {
                return Result<string>.Failure("Hakkımda sayfası aktif gözüküyor, yeni ekleme yaptıktan sonra tekrar silmeyi deneyin!");
            }

            if (aboutPage.ImgUrl is not null)
                fileService.DeleteFile(aboutPage.ImgUrl, "AboutPageImages");

            aboutPageRepository.Delete(aboutPage);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Hakkımda sayfası başarıyla silindi!";
        }
    }
}
