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
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId= Guid.Parse("FF63279D-1D1D-4EE4-B38F-7F450B789AA4"),
                RoleId = Guid.Parse("86D36FF9-7BF6-4150-AF28-EBC0D6CA09F6")
            },
            new AppUserRole
            {
                UserId= Guid.Parse("C70EEA03-49A4-4328-9AF3-CC199300B4BE"),
                RoleId= Guid.Parse("50FEF4DA-C876-4A50-BD56-B544A792695D")
            });
        }
    }
}
