using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; } = null!;
       
        public decimal? Bouns { get; set; }
        
        public decimal? Salary { get; set; }
        public string? Address { get; set; }
        public double? HourRate { get; set; }
        //FK From DepartmentID
        public int? DepId { get; set; }


        public ICollection<Department> Departments { get; set; }= new List<Department>();
        public Department Department { get; set; } = null!;
        public ICollection<CourseInstructor> InstructorCourses{ get; set; }=new HashSet<CourseInstructor>();

    }
}
