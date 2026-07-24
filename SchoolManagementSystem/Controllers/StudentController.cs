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
    //   - View (GetAll / GetById): any logged-in role. Teachers and the
    //     Principal need it to do their jobs, and the Accountant needs it
    //     to work out fees -- so we don't lock it down further here.
    //   - Create / Update: Teacher or Principal only -- these are the
    //     people who actually enrol and manage students day-to-day.
    //   - Delete: Principal only. Removing a student record is the most
    //     sensitive action here, so it gets the strictest rule
    //     (Module 12: "least privilege" -- give the minimum access needed).
    //
    // [Authorize] on the class requires "logged in" for everything
    // (Module 7: authentication happens first); the per-action
    // [Authorize(Roles = ...)] attributes narrow that down further.
    // ===================================================================
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentController : Controller
    {
        protected readonly IStudentRepository _repository;
        protected readonly IDepartmentRepository _departmentRepository;

        public StudentController(IStudentRepository studentRepository, IDepartmentRepository departmentRepository)
        {
            _repository = studentRepository;
            _departmentRepository = departmentRepository;
        }

        //GET: api/students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {
            var response = await _repository.GetAllAsync();
            return Ok(response);
        }

        //GET: api/students/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var student = await _repository.GetByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        //POST: api/students
        [HttpPost]
        [Authorize(Roles = RoleNames.TeacherOrPrincipal)]
        public async Task<ActionResult<StudentDto>> Create(CreateStudentDto dto)
        {
            //check if the department id exist
            var department = await _departmentRepository.GetByIdAsync(dto.DepartmentId);
            if (department == null)
            {
                return BadRequest("Department does not exist");
            }

            var student = new Student
            {
                Name = dto.Name,
                Email = dto.Email,
                DepartmentId = dto.DepartmentId,
            };

            var created = await _repository.AddAsync(student);

            var result = new StudentDto
            {
                Id = created.Id,
                Name = created.Name,
                Email = created.Email,
                DepartmentId = created.DepartmentId
            };

            return Ok(result);
        }

        // PUT: api/students/3
        [HttpPut("{id}")]
        [Authorize(Roles = RoleNames.TeacherOrPrincipal)]
        public async Task<ActionResult> Update(int id, Student student)
        {
            if(id != student.Id)
            {
                return BadRequest("Route id does not match the body id");
            }

            var isStudentExist = await _repository.ExistsAsync(id);
            if (isStudentExist == false)
            {
                return NotFound();
            }

            await _repository.UpdateAsync(student);
            return NoContent();
        }

        //DELETE: api/students/3
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
