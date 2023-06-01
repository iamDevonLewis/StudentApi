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
            var students = _context.Students.ToList();
            return students;
        }
    }
}
