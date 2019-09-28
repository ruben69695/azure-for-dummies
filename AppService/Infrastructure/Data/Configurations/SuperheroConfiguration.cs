using AppService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppService.Infrastructure.Data.Configurations
{
    public class SuperheroConfiguration : IEntityTypeConfiguration<Superhero>
    {
        public void Configure(EntityTypeBuilder<Superhero> builder)
        {
            // Primary key
            builder.HasKey(superhero => superhero.Id);

            // Name Property
            builder.Property(superhero => superhero.Name)
                .IsRequired(true);

            // Description Property
            builder.Property(superhero => superhero.Description)
                .IsRequired();

            // Image Url Property
            builder.Property(superhero => superhero.ImageUrl)
                .IsRequired();
        }
    }
}