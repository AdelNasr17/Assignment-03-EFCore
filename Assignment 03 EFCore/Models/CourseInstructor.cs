using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    [PrimaryKey(nameof(Inst_Id),nameof(Course_Id))]
    public class CourseInstructor
    {
        //FK From InstructorId 
        public int Inst_Id { get; set; }
        //FK From CourseId
        public int Course_Id { get; set; }
        public double? Evaluate { get; set; }

        public Course course { get; set; } = null!;
        public Instructor Instructor { get; set; } = null!;
    }
}
