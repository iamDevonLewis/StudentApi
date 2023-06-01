using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.DTO;
using StudentAPI.Models;
using StudentAPI.Repository;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult GetAllStudents()
        {
            var students = _studentRepository.GetStudents();

            var studentDto = new List<StudentDto>();

            foreach(var student in students)
            {
                studentDto.Add(new StudentDto()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    PhoneNumber = student.PhoneNumber,
                    ImageUrl = student.ImageUrl,
                    DateOfBirth = student.DateOfBirth,
                    GenderId = student.GenderId,
                    Gender = new Gender()
                    {
                        Id = student.Gender.Id,
                        Description = student.Gender.Description
                    },
                    Address = new Address()
                    {
                        Id = student.Address.Id,
                        Street = student.Address.Street,
                        City = student.Address.City,
                        State = student.Address.State
                    }

                });
            }

            return Ok(studentDto);
        }
    }
}
