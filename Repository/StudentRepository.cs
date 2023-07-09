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

        public async Task<List<Student>> GetStudents()
        {
            var students = await _context.Students.Include(x => x.Gender).Include(e => e.Address).ToListAsync();
            return students;
        }

        public async Task<Student> GetStudent(Guid id)
        {
            var student = await _context.Students.Include(x => x.Gender).Include(e => e.Address).FirstOrDefaultAsync(x => x.Id == id);
            return student;
        }

    }
}
