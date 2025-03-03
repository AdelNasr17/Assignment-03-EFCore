using Assignment_03_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Model_Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {



            // RelationShip Between Student And Department (Many = To = One )
            builder.HasOne(S => S.StudentDepartments)
                   .WithMany(D => D.Students)
                   .HasForeignKey(S => S.DeptId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.NoAction);

            //RelationShip Between Student And StudentCourse (Many To One )
            builder.HasMany(S=> S.StudentCourse)
                   .WithOne(SC=> SC.Students)
                   .HasForeignKey(SC=> SC.Stud_Id)
                   .OnDelete(DeleteBehavior.NoAction);


            
        }
    }
}
