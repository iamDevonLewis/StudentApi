using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetStudents()
        {
            var students = _context.Students.Include(x => x.Gender).Include(e => e.Address).ToList();
            return students;
        }
    }
}
