using AuthSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AuthSystem.Infra.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User { Id = Guid.Parse("64c67611-ed03-4fa7-887d-a9a46e6b7acd"), Name = "User Default", Email = "userdefault@auth.com" }
                );
            return builder;
        }
    }
}
