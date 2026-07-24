using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDbContext context) : base(context)
        {

        }

        public Task<IEnumerable<Student>> GetByDepartmentAsync(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
