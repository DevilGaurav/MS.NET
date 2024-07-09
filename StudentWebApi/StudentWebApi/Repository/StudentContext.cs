using Microsoft.EntityFrameworkCore;
using StudentWebApi.Entity;


namespace StudentWebApi.Repository
{
    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"server=localhost;port=3306;user=root;password=root;database=StudentWebPrac";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(St =>
            {
                St.HasKey(e => e.id);
            });
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
