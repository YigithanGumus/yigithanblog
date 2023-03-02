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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("D033F821-F516-4651-929A-F11F85DB6188"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Image
            {
               Id=Guid.Parse("0C3559B7-E1DF-4FD0-A475-6712B386D91B"),
               FileName = "images/vstest",
               FileType = "png",
               CreatedBy = "Admin Test",
               CreatedDate = DateTime.Now,
               IsDeleted = false
            });
        }
    }
}
