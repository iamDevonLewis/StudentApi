using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth {get; set; }
        [ForeignKey("Gender")]
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        [ForeignKey("Address")]
        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }
        
    }
}
