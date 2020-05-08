using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuildExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description eShopSolution" });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    LanguageId = "vi-VN",
                    Name = "Áo nam",
                    SeoTitle = "sản phẩm áo thời trang nam",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Áo nam mới và đẹp"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    LanguageId = "en-US",
                    Name = "Men shirt",
                    SeoTitle = "This is product for men",
                    SeoAlias = "Men-Shirt",
                    SeoDescription = "Men Shirt beautiful and new"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ"
                    ,
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang women"
                },
                 new CategoryTranslation()
                 {
                     Id = 4,
                     CategoryId = 2,
                     Name = "Women Shirt",
                     LanguageId = "en-US",
                     SeoAlias = "women-shirt",
                     SeoDescription = "The shirt products for women",
                     SeoTitle = "The shirt products for women"
                 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    OriginalPrice = 200000,
                    Price = 400000,
                    DateCreated = DateTime.Now,
                    Stock = 0,
                    ViewCount = 0,
                });

            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Áo sơ mi nam trắng Việt Tiến",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                     SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                     SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                     Details = "Áo sơ mi nam trắng Việt Tiến",
                     Description = "Áo sơ mi nam trắng Việt Tiến"
                 },
                 new ProductTranslation()
                 {
                     Id = 2,
                     ProductId = 1,
                     Name = "Viet Tien Men T-Shirt",
                     LanguageId = "en-US",
                     SeoAlias = "viet-tien-men-t-shirt",
                     SeoDescription = "Viet Tien Men T-Shirt",
                     SeoTitle = "Viet Tien Men T-Shirt",
                     Details = "Viet Tien Men T-Shirt",
                     Description = "Viet Tien Men T-Shirt"
                 });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { 
                    ProductId = 1,
                    CategoryId = 1 
                }
                );



            // any guid
            var roleId = new Guid("4D48A7A7-10BD-4345-A447-E9FD8C98FD4B");
            var adminId = new Guid("BAD3F12C-DA61-44E6-86E7-F67FC4ADD9E1");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "thanhtung29.05.98@gmail.com",
                NormalizedEmail = "thanhtung29.05.98@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "29051998"),
                SecurityStamp = string.Empty,
                FirstName = "Dinh",
                LastName = "Tung",
                DOB = new DateTime(2020, 04, 26)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });



        }


    }
}
