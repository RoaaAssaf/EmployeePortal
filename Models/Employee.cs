using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Employee
    {
        [Key]
      
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Mobile { get; set; }


        public required string Age { get; set; }


        public required string Salary { get; set; }

        public required bool Status { get; set; }
    }
}
