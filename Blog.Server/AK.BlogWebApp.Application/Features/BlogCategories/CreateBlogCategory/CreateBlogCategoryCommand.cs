using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using Microsoft.VisualBasic;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.BlogCategories.CreateBlogCategory;

public sealed class CreateBlogCategoryCommand : IRequest<Result<string>>
{
    public string Title { get; set; } = string.Empty;
}
