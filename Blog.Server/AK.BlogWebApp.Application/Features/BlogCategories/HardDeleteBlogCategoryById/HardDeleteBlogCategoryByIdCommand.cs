using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.BlogCategories.HardDeleteBlogCategoryById;

public sealed record HardDeleteBlogCategoryByIdCommand(Guid Id) : IRequest<Result<string>>;

