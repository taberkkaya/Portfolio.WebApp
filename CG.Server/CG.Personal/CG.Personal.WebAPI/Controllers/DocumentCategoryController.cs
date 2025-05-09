using CG.Personal.Application.Features.DocumentCategories.CreateDocumentCategory;
using CG.Personal.Application.Features.DocumentCategories.DeleteDocumentCategory;
using CG.Personal.Application.Features.DocumentCategories.GetAllDocumentCategories;
using CG.Personal.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CG.Personal.WebAPI.Controllers
{
    public class DocumentCategoryController : ApiController
    {
        public DocumentCategoryController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDocumentCategoryCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDocumentCategoryCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(GetAllDocumentCategoriesQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllDocumentCategoriesQuery(), cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

    }
}
