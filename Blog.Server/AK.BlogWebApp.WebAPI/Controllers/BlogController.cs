    using AK.BlogWebApp.Application.Features.Blogs.CreateBlog;
using AK.BlogWebApp.Application.Features.Blogs.DeleteBlogById;
using AK.BlogWebApp.Application.Features.Blogs.GetAllBlogs;
using AK.BlogWebApp.Application.Features.Blogs.GetAllBlogsByCategory;
using AK.BlogWebApp.Application.Features.Blogs.GetBlogById;
using AK.BlogWebApp.Application.Features.Blogs.UpdateBlog;
using AK.BlogWebApp.Application.Features.Documents.CreateDocument;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers
{
    public class BlogController : ApiController
    {
        public BlogController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllBlogs(GetAllBlogsQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllBlogsByCategory(GetAllBlogsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetBlogById(GetBlogByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request,cancellationToken);
            return StatusCode(response.StatusCode,response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteBlogByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromForm] UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

    }
}
