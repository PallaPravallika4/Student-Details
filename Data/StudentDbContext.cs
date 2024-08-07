using Microsoft.EntityFrameworkCore;
using StudentInformation.Models;
using System.Collections.Generic;

namespace StudentInformation.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
