using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents();

    }
}
