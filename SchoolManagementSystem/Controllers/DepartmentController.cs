using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Repositories;

namespace SchoolManagementSystem.Controllers
{
    // ===================================================================
    // AUTHORIZATION MAP for this controller (workshop Module 13 activity:
    // "Design the Access" for Student / Teacher / Principal / Accountant).
    //
    // Departments are the school's org structure, so we treat them like the
    // "bank account screen" example from Module 6: everyone who is logged in
    // can VIEW them, but only the Principal can create/rename/delete one --
    // that's "least privilege" from Module 12: give the minimum access needed.
    //
    // [Authorize] on the class means "you must be logged in at all" for
    // every action here (Module 7: authentication happens first). The
    // stricter [Authorize(Roles = ...)] on individual actions below then
    // narrows that further for the actions that change data.
    // ===================================================================
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
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
        // Only the Principal manages departments -- least privilege (Module 12).
        [HttpPost]
        [Authorize(Roles = RoleNames.Principal)]
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
        [Authorize(Roles = RoleNames.Principal)]
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
        [Authorize(Roles = RoleNames.Principal)]
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
