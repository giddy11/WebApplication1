using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<IEnumerable<Department>> GetAllDepartmentsIncludingStudents();
    }
}
