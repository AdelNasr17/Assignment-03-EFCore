using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    [PrimaryKey(nameof(Stud_Id),nameof(Course_Id))]
    public class StudentCourse
    {
        //FK From StudentId
        public int Stud_Id { get; set; }
        //FK From CourseId
        public int Course_Id { get; set; }
        public double? Grade { get; set; }

        public  Student Students { get; set; } = null!;
        public Course Courses { get; set; } = null!;
    }
}
