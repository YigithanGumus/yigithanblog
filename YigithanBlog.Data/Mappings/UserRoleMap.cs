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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId= Guid.Parse("1620EF01-506B-4C6E-8043-2BD7D57A3E5D"),
                RoleId= Guid.Parse("76BA5E4A-5A9E-4E21-9EFC-1E4070E5F60F")
            }, 
            new AppUserRole
            {
                UserId= Guid.Parse("EBAEE967-4354-45DB-858E-7268A2BCAEF5"),
                RoleId= Guid.Parse("8B0A99BF-D084-4296-A098-604BDDC523CB")
            }
            );
        }
    }
}
