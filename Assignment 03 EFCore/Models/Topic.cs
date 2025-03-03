using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Models
{
    public class Topic
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
