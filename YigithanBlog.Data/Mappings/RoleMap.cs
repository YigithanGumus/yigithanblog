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
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole {
                
                Id=Guid.Parse("76BA5E4A-5A9E-4E21-9EFC-1E4070E5F60F"),
                Name="Superadmin",
                NormalizedName="SUPERADMIN",
                ConcurrencyStamp=Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id=Guid.Parse("8B0A99BF-D084-4296-A098-604BDDC523CB"),
                Name="Admin",
                NormalizedName="ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id = Guid.Parse("F5540C40-8DD2-46FC-9F93-0D5E5FBB0921"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }
    }
}
