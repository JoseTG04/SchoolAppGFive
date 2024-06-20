using Microsoft.EntityFrameworkCore;
using SchoolAppGFive.DAL.Entities;

namespace SchoolAppGFive.DAL.Context
{
    public partial class SchoolContext : DbContext
    {
        #region "Constructor"
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        { 

        }

        #endregion

        #region "Db Sets"
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        #endregion

    }
}
