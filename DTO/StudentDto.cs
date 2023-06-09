﻿using StudentAPI.Models;

namespace StudentAPI.DTO
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        public Guid? AddressId { get; set; }
        public Address Address { get; set; }
    }
}
