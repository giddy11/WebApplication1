using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly SchoolDbContext _context;
        public DepartmentRepository(SchoolDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsIncludingStudents()
        {
            var result = await _context.Departments.Include(stu => stu.Students).ToListAsync();
            return result;
        }
    }
}
