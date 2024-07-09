using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Entity;
using StudentWebApi.Services;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudInterface Stud;

        public StudentController(StudInterface stud)
        {
            Stud = stud;
        }
        [HttpPost]
        public IActionResult Insert(Student student)
        {
            Stud.Insert(student);
            return Ok();
        }

        [HttpGet]
        public IActionResult Display()
        {
            return Ok(Stud.GetAll());
        }
        [HttpPost("{id}")]
        public IActionResult Delete(int id)
        {
            Stud.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Upate(Student student)
        {
            Stud.Update(student);
            return Ok();
        }
    }
}
