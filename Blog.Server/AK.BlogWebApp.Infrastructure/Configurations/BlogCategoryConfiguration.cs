﻿using AK.BlogWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AK.BlogWebApp.Infrastructure.Configurations;

internal class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
{
    public void Configure(EntityTypeBuilder<BlogCategory> builder)
    {

        BlogCategory blogCategory1 = new BlogCategory
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            Title = "What is Lorem Ipsum?",
            CreatedDate = DateTime.Now
        };

        BlogCategory blogCategory2 = new BlogCategory
        {
            Id = Guid.Parse("0B6C5C91-9D48-4E9B-8B5D-FED05BE56A73"),
            Title = "What is Lorem Ipsum?",
            CreatedDate = DateTime.Now
        };

        BlogCategory blogCategory3 = new BlogCategory
        {
            Id = Guid.Parse("6DEF4F3D-93B9-4C24-97E1-143499F2955F"),
            Title = "What is Lorem Ipsum?",
            CreatedDate = DateTime.Now
        };

        BlogCategory blogCategory4 = new BlogCategory
        {
            Id = Guid.Parse("D7A19C6C-0D9F-4D10-9207-CFC9C8499A32"),
            Title = "What is Lorem Ipsum?",
            CreatedDate = DateTime.Now
        };

        builder.HasData(blogCategory1, blogCategory2, blogCategory3, blogCategory4);
    }
}
