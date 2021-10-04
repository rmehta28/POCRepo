using BeanStalkPOC.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeanStalkPOC.Core
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
