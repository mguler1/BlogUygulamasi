using BlogUygulaması.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.categoryBlogs).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
