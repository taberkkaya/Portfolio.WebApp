using AK.BlogWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AK.BlogWebApp.Infrastructure.Configurations;

internal sealed class HomePageConfiguration : IEntityTypeConfiguration<HomePage>
{
    public void Configure(EntityTypeBuilder<HomePage> builder)
    {
        HomePage homePage = new HomePage
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            HeaderTitle = "What is Lorem Ipsum?",
            HeaderContent = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
            MainTitle = "What is Lorem Ipsum?",
            MainContent = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        builder.HasData(homePage);
    }
}
