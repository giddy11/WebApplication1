using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Repositories;

namespace SchoolManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
