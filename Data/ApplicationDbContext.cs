using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Gender>().HasData(
                new Gender
                {
                    Id = Guid.Parse("15fe46d3-7de1-43bd-ba1a-a81ab6e56105"),
                    Description = "Male"  
                },
                new Gender
                {
                    Id = Guid.Parse("8fc6727e-6882-4c86-a5b1-f7ca2e326857"),
                    Description = "Female"
                });

            //Address
            modelBuilder.Entity<Address>().HasData(
               new Address
               {
                   Id = Guid.Parse("6094c3de-6b72-4927-afb3-9a89d0bcbfa8"),
                   City = "Saint Louis",
                   State = "Missouri",
                   Street = "23 Halls Ferry",
                   StudentId = Guid.Parse("2e30682f-3937-4d87-bfab-6aae235d9123")
               },

               new Address
               {
                   Id = Guid.Parse("17eb6454-b9b0-4c8b-a764-ede233f098a1"),
                   City = "Saint Louis",
                   State = "Missouri",
                   Street = "51 Hazelwood",
                   StudentId = Guid.Parse("2b107f52-c7b5-4879-a233-bf8805341f58")
               });

            //student
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = Guid.Parse("2b107f52-c7b5-4879-a233-bf8805341f58"),
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "john@yahoo.com",
                    PhoneNumber = 411,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Jay-Z_%40_Shawn_%27Jay-Z%27_Carter_Foundation_Carnival_%28crop_2%29.jpg/1200px-Jay-Z_%40_Shawn_%27Jay-Z%27_Carter_Foundation_Carnival_%28crop_2%29.jpg",
                    DateOfBirth = new DateTime(1990, 02, 23),
                    AddressId = Guid.Parse("17eb6454-b9b0-4c8b-a764-ede233f098a1"),
                    GenderId = Guid.Parse("15fe46d3-7de1-43bd-ba1a-a81ab6e56105")
                },
                new Student
                {
                    Id = Guid.Parse("2e30682f-3937-4d87-bfab-6aae235d9123"),
                    FirstName = "Whitney",
                    LastName = "Houston",
                    Email = "whitney@yahoo.com",
                    PhoneNumber = 511,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/52/Whitney_Houston_%28cropped3%29.JPEG",        
                    DateOfBirth = new DateTime(2000, 01, 02),
                    GenderId = Guid.Parse("8fc6727e-6882-4c86-a5b1-f7ca2e326857"),
                    AddressId = Guid.Parse("6094c3de-6b72-4927-afb3-9a89d0bcbfa8")

                });
        }
    }


}
