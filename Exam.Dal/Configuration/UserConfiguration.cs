using Exam.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Dal.Configuration
{
    class UserConfiguration: BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name);
            builder.Property(p => p.Age);
            builder.Property(p => p.Email);
            builder.Property(p => p.Password);

            builder
                .HasMany(b => b.Blogs)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.User);

            builder.HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Muhamed Halkic",
                    Age = 25,
                    Email = "muhamed@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed1 Halkic",
                    Age = 25,
                    Email = "muhamed1@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed2 Halkic",
                    Age = 25,
                    Email = "muhamed2@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed3 Halkic",
                    Age = 25,
                    Email = "muhamed3@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed4 Halkic",
                    Age = 25,
                    Email = "muhamed4@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed5 Halkic",
                    Age = 25,
                    Email = "muhamed5@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed6 Halkic",
                    Age = 25,
                    Email = "muhamed6@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed7 Halkic",
                    Age = 25,
                    Email = "muhamed7@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed8 Halkic",
                    Age = 25,
                    Email = "muhamed8@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed9 Halkic",
                    Age = 25,
                    Email = "muhamed9@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed11 Halkic",
                    Age = 25,
                    Email = "muhamed11@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 1,
                    Name = "Muhamed12 Halkic",
                    Age = 25,
                    Email = "muhamed12@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 13,
                    Name = "Muhamed13 Halkic",
                    Age = 25,
                    Email = "muhamed13@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 14,
                    Name = "Muhamed14 Halkic",
                    Age = 25,
                    Email = "muhamed14@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                },
                new User
                {
                    Id = 15,
                    Name = "Muhamed15 Halkic",
                    Age = 25,
                    Email = "muhamed15@hotmail.com",
                    Password = "1234",
                    CreatedBy = "Muhamed Halkic"
                }
            });
        }
    }
}
