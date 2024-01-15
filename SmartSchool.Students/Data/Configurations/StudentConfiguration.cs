using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartSchool.Students.Domain.Models;

namespace SmartSchool.Students.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Ignore(student => student.Age);
            builder.Property(student => student.FirstName).IsRequired().HasMaxLength(70);
            builder.Property(student => student.LastName).IsRequired().HasMaxLength(70);
            builder.Property(student => student.Email).HasMaxLength(100);
        }
    }
}
