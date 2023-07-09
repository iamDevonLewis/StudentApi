using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.DTO;
using StudentAPI.Models;
using StudentAPI.Repository;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("angularApp")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentRepository.GetStudents();

            //AutoMapper
            return Ok(_mapper.Map<List<StudentDto>>(students));

            //    var studentDto = new List<StudentDto>();

            //    foreach(var student in students)
            //    {
            //        studentDto.Add(new StudentDto()
            //        {
            //            Id = student.Id,
            //            FirstName = student.FirstName,
            //            LastName = student.LastName,
            //            Email = student.Email,
            //            PhoneNumber = student.PhoneNumber,
            //            ImageUrl = student.ImageUrl,
            //            DateOfBirth = student.DateOfBirth,
            //            GenderId = student.GenderId,
            //            Gender = new Gender()
            //            {
            //                Id = student.Gender.Id,
            //                Description = student.Gender.Description
            //            },
            //            Address = new Address()
            //            {
            //                Id = student.Address.Id,
            //                Street = student.Address.Street,
            //                City = student.Address.City,
            //                State = student.Address.State
            //            }

            //        });
            //    }

            //    return Ok(studentDto);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetStudent([FromRoute] Guid id)
        {
            var student = await _studentRepository.GetStudent(id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Student>(student));
        }

    }
}
