using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Column("FName",TypeName ="nvarchar(50)")]
        public string FName { get; set; } = null!;
        [Column("LName", TypeName = "nvarchar(50)")]
        public string? LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }

        // FK From DepartmentID
        public int? DeptId { get; set; }


        public Department StudentDepartments { get; set; } = null!;

        public ICollection<StudentCourse> StudentCourse { get; set; }= new HashSet<StudentCourse>();



    }
}
