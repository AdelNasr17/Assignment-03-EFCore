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
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(C => C.Id);
            builder.Property(C => C.Id).UseIdentityColumn(10, 10);


            //RelationShip Between Course And Topic (Many To One )
            builder.HasOne(C=> C.Topic)
                   .WithMany(T=> T.Courses)
                   .HasForeignKey(C=> C.ToPicId)
                   .OnDelete(DeleteBehavior.NoAction);


            //RelationShip Between Course And StudentCourse (Many To One )
            builder.HasMany(S => S.CourseStudent)
                  .WithOne(SC => SC.Courses)
                  .HasForeignKey(SC => SC.Course_Id)
                  .OnDelete(DeleteBehavior.NoAction);


            //RelationShip Between Course And CourseInstructor (Many To One )
            builder.HasMany(C => C.CourseInstructors)
                   .WithOne(CI => CI.course)
                   .HasForeignKey(CI => CI.Course_Id)
                   .OnDelete(DeleteBehavior.NoAction);
                



        }
    }
}
