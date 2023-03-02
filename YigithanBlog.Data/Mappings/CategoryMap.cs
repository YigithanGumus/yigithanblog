using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigithanBlog.Entity.Entities;

namespace YigithanBlog.Data.Mappings
{
    internal class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("6225C7A6-DD70-4CC4-AEC4-C7B7612CDE27"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
               
                    Id = Guid.Parse("BD4AF5A5-7950-453D-96DD-EFDD253D9E22"),
                    Name = "Visual Studio 2022",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
               
            });
        }
    }
}
