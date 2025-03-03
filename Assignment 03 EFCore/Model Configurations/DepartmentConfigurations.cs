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
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);


            builder.Property(D => D.Name)                
                  .HasColumnType("nvarchar(50)");


            //RelationShip Between Department And Instructor (Many = To = One  )

            builder.HasOne(D=> D.Instructor)
                   .WithMany(I=> I.Departments)
                   .HasForeignKey(D=> D.InsId)
                   .OnDelete(DeleteBehavior.NoAction);

            
                   

           
        }
    }
}
