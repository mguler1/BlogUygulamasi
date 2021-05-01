using BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using BlogUygulaması.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Context
{
   public class BlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=MEHDI\GULER;database=BlogUygulamasi;integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
