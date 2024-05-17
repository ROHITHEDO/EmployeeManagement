namespace EmployeeManagement.Models
{
    public class Employees
    {
        public int Id { get; set; }

        public string? FirstName { get; set; } 
        
        public string? LastName{ get; set; }

        public int EmployeeCode { get; set; }

        public DateTime DateOfJoining { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Salary { get; set;}

    }
}
