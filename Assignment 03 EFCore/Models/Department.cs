using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateOnly? HiringDate { get; set; }
        //FK From InstructorId 
        public int? InsId { get; set; }

       

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public Instructor Instructor { get; set; }=null!;
        public ICollection<Instructor> Instructors { get; set; }=new List<Instructor>();
    }
}
