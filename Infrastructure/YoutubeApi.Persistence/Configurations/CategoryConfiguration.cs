using Microsoft.EntityFrameworkCore;
using Bogus;
using YoutubeApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YoutubeApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                ParentId = 0,
                Name = "Electronics",
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            Category category2 = new()
            {
                Id = 2,
                ParentId = 0,
                Name = "Moda",
                Priorty = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            Category parent1 = new()
            {
                Id = 3,
                ParentId = 1,
                Name = "Bilgisayar",
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            Category parent2 = new()
            {
                Id = 4,
                ParentId = 2,
                Name = "Kadın",
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };
            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}
