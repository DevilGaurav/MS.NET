using StudentWebApi.Entity;

namespace StudentWebApi.Services
{
    public interface StudInterface
    {
        void Insert(Student  student);

        List<Student> GetAll();
        Student Delete(int id);
        Student Update(Student student);
    }
}
