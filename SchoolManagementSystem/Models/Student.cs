namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

    public class CreateStudentDto
    {
        public string? Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }

    public class StudentDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}
