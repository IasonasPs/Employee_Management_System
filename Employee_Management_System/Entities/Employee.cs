using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Entities
{
    public class Employee
    {
            [Key]
            public int EmployeeID { get; set; }

            [Required]
            [StringLength(50)]
            public string FirstName { get; set; }

            [Required]
            [StringLength(50)]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            public int? DepartmentID { get; set; }

            public Department? Department {  get; set; }    

            [DataType(DataType.Date)]
            public DateTime DateOfJoining { get; set; }
        
    }
}