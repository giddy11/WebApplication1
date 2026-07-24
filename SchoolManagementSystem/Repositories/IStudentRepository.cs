using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IEnumerable<Student>> GetByDepartmentAsync(int departmentId);
    }
}
