using AK.BlogWebApp.Application.Features.DocumentCategories.CreateDocumentCategory;
using AK.BlogWebApp.Application.Features.DocumentCategories.DeleteDocumentCategory;
using AK.BlogWebApp.Application.Features.DocumentCategories.GetAllDocumentCategories;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers
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
