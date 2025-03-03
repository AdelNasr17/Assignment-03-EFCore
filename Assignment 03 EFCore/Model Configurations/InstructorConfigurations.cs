using Assignment_03_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.Model_Configurations
{
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {


            builder.Property(I => I.Bouns)
                 .HasColumnType("decimal(10,4)");
            builder.Property(I => I.Salary)
                  .HasColumnType("decimal(10,4)");



            //RelationShip Between Department And Instructor (One = To = Many )
            builder.HasOne(I=> I.Department)
                   .WithMany(D=> D.Instructors)
                   .HasForeignKey(I=> I.DepId)
                   .OnDelete(DeleteBehavior.NoAction);


            //RelationShip Between instructor And CourseInstructor (Many To One )
            builder.HasMany(C => C.InstructorCourses)
                   .WithOne(CI => CI.Instructor)
                   .HasForeignKey(CI => CI.Inst_Id)
                   .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
