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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Asp.net Core Deneme Makalesi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount = 15,
                CategoryId= Guid.Parse("6225C7A6-DD70-4CC4-AEC4-C7B7612CDE27"),
                ImageId=Guid.Parse("D033F821-F516-4651-929A-F11F85DB6188"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId= Guid.Parse("FF63279D-1D1D-4EE4-B38F-7F450B789AA4")

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Asp.net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount = 15,
                CategoryId = Guid.Parse("BD4AF5A5-7950-453D-96DD-EFDD253D9E22"),
                ImageId=Guid.Parse("0C3559B7-E1DF-4FD0-A475-6712B386D91B"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId= Guid.Parse("C70EEA03-49A4-4328-9AF3-CC199300B4BE")
            }
            
            
            );
            
        }
    }
}
