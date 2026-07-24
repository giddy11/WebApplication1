using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Repositories;

namespace SchoolManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        protected readonly IDepartmentRepository _repository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _repository = departmentRepository;
        }

        //GET: api/departments
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Department>>> GetAll()
        //{
        //    var response = await _repository.GetAllAsync();
        //    return Ok(response);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetAll()
        {
            var departments = await _repository.GetAllDepartmentsIncludingStudents();
            var dtos = departments.Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name,
                StudentCount = d.Students?.Count ?? 0,
            });

            return Ok(dtos);
        }


        //GET: api/departments/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetById(int id)
        {
            var department = await _repository.GetByIdAsync(id);
            if(department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        //POST: api/departments
        [HttpPost]
        public async Task<ActionResult<CreateDepartmentDto>> Create(CreateDepartmentDto departmentDto)
        {
            var department = new Department
            {
                Name = departmentDto.Name
            };

            var created = await _repository.AddAsync(department);
            return Ok(created);
        }


        //PUT: api/departments/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateDepartmentDto dto)
        {
            var department = await _repository.GetByIdAsync(id);
            if (department == null) return NotFound();

            department.Name = dto.Name;

            await _repository.UpdateAsync(department);
            return NoContent();
        }


        //DELETE: api/departments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _repository.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
