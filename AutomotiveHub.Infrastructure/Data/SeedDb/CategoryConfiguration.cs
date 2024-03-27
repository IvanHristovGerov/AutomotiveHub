using AutomotiveHub.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomotiveHub.Infrastructure.Data.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            return new List<Category>()
            {
                 new Category()
                {
                    Id = 1,
                    Name = "Sports car"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Sedan"
                },
                new Category()
                {
                    Id = 3,
                    Name = "SUV"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Estate"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Hatchback"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Convertible"
                },
                new Category()
                {
                    Id=7,
                    Name = "Van"
                }
             

            };
        }
    }
}
