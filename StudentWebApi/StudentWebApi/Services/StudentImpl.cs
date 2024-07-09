using Microsoft.OpenApi.Validations;
using StudentWebApi.Entity;
using StudentWebApi.Repository;

namespace StudentWebApi.Services
{
    public class StudentImpl : StudInterface
    {
        private readonly StudentContext _context=new StudentContext();
        public Student Delete(int id)
        {
            var student=_context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return student;
        }

        public List<Student> GetAll()
        {
            var studs=_context.Students.ToList();
            return studs;
        }

        public void Insert(Student student)
        {
            var studs = _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }
    }
}
