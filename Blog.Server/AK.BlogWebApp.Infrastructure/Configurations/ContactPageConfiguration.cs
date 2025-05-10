using AK.BlogWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AK.BlogWebApp.Infrastructure.Configurations;

internal sealed class ContactPageConfiguration : IEntityTypeConfiguration<ContactPage>
{
    public void Configure(EntityTypeBuilder<ContactPage> builder)
    {
        ContactPage contactPage = new ContactPage
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            Title = "What is Lorem Ipsum?",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
            Email = "ataberk@ataberkkaya.com",
            PhoneNumber = "+90 999 999 99 99"
        };

        builder.HasData(contactPage);
    }
}
