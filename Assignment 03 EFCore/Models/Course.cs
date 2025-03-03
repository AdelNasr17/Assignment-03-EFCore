using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        [DataType(DataType.Duration)]
        public int? Duration { get; set; }
        //FK From TopicID
        public int? ToPicId { get; set; }


        public Topic Topic { get; set; } = null!;
        public ICollection<StudentCourse> CourseStudent {  get; set; }= new HashSet<StudentCourse>();
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();

    }
}
