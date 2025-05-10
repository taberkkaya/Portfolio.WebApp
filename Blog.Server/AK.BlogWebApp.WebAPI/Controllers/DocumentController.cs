
using AK.BlogWebApp.Application.Features.Documents.CreateDocument;
using AK.BlogWebApp.Application.Features.Documents.DeleteDocumentById;
using AK.BlogWebApp.Application.Features.Documents.GetAllDocuments;
using AK.BlogWebApp.Application.Features.Documents.GetAllDocumentsByCategory;
using AK.BlogWebApp.Application.Features.Documents.GetDocumentById;
using AK.BlogWebApp.Application.Features.Documents.UpdateDocuments;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers
{
    public class DocumentController : ApiController
    {
        public DocumentController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllDocuments(GetAllDocumentsQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetDocumentById(GetDocumentByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllDocumentsByCategory(GetAllDocumentsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request,cancellationToken);
            return StatusCode(response.StatusCode,response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDocumentByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromForm]UpdateDocumentCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

    }
}
