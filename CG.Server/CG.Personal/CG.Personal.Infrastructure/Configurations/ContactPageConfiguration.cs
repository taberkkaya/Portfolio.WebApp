using CG.Personal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Personal.Infrastructure.Configurations;

internal sealed class ContactPageConfiguration : IEntityTypeConfiguration<ContactPage>
{
    public void Configure(EntityTypeBuilder<ContactPage> builder)
    {
        ContactPage contactPage = new ContactPage
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            Title = "Contact Me",
            Description = "This is a brief description about how to contact me.",
            Email = "cihan@gokpinar.com",
            PhoneNumber = "+90 999 999 99 99"
        };

        builder.HasData(contactPage);
    }
}
