using AK.BlogWebApp.Application.Features.BlogCategories.CreateBlogCategory;
using AK.BlogWebApp.Application.Features.BlogCategories.DeleteBlogCategoryById;
using AK.BlogWebApp.Application.Features.BlogCategories.GetAllBlogCategories;
using AK.BlogWebApp.Application.Features.BlogCategories.HardDeleteBlogCategoryById;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers
{
    public class BlogCategoryController : ApiController
    {
        public BlogCategoryController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);   
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteBlogCategoryByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> HardDelete(HardDeleteBlogCategoryByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(GetAllBlogCategoriesQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllBlogCategoriesQuery(), cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
