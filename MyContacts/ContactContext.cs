
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyContacts.Models;

namespace MyContacts
{
    public class ContactContext : IdentityDbContext<IdentityUser>

    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Famille" },
                new Category { CategoryId = 2, Name = "Ami" },
                new Category { CategoryId = 3, Name = "Travail" }
            );

            modelBuilder.Entity<Contact>().HasData(
    new Contact
    {
        ContactId = 1,
        FirstName = "Faye",
        LastName = "Richard",
        PhoneNumber = "775678798",
        Email = "fayerichard@gmail.com",
        CategoryId = 1
    },
    new Contact
    {
        ContactId = 2,
        FirstName = "Nzale",
        LastName = "Prisca",
        PhoneNumber = "789024123",
        Email = "nzaleprisca@gmail.com",
        CategoryId = 1
    },
    new Contact
    {
        ContactId = 3,
        FirstName = "Sarr",
        LastName = "Marie Jules",
        PhoneNumber = "123-456-7890",
        Email = "sarrjules@gmail.com",
        CategoryId = 2
    }
);
            base.OnModelCreating(modelBuilder);
        }
    }
}
