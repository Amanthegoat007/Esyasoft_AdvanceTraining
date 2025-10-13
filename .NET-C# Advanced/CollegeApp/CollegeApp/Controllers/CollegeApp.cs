using CollegeApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeAppController : ControllerBase
    {
        //[HttpGet("all")]
        //public ActionResult <IEnumerable<Student>> GetStudents()
        //{
        //    return collegeRepository.students;
        //}
        [HttpGet]
        [Route("All")]
        public ActionResult <IEnumerable<Student>> getStudents()
        {
            var students = collegeRepository.students.Select(s => new studentDTO()
            {
                //studentID = s.studentID,
                name = s.name,
                age = s.age,
                email = s.email,
            });
            return Ok(students);

        }
        [HttpGet("{id:int}",Name = "GetStudentById")]
        public ActionResult<studentDTO> getStudentById(int id)
        {
            if (id <= 0) return BadRequest();
            var student = collegeRepository.students.Where(n => n.studentID == id).FirstOrDefault();

            if (student == null) return NotFound();
            var studentDTO = new studentDTO()
            {
                //studentID = student.studentID,
                name = student.name,
                age = student.age,
                email = student.email,
            };
            return Ok(studentDTO);
        }

        //public ActionResult<IEnumerable<Student>> GetStudentById(int id)
        //{
        //    if (id < 0) return BadRequest();
        //    Student s= collegeRepository.students.First(n => n.studentID == id);
        //    if (s == null) return NotFound();
        //    return Ok(s);
        //}

        [HttpGet("{name:alpha}",Name = "GetStudentByName")]

        public ActionResult<IEnumerable<studentDTO>> GetStudentByName(string name)
        {
            if (name == null || name == "") return BadRequest();
            Student s = (collegeRepository.students.First(n => n.name == name));
            if (s == null) return NotFound();
            var studentDTO1 = new studentDTO()
            {
                name = s.name,
                age = s.age,
                email = s.email,
            };
            return Ok(studentDTO1);
        }
        //public ActionResult<IEnumerable<Student>> GetStudentByName(string name)
        //{
        //    if (name == null || name == "") return BadRequest();
        //    Student s= (collegeRepository.students.First(n => n.name == name));
        //    if (s == null) return NotFound();
        //    return Ok(s);
        //}

        [HttpDelete("{id:int}",Name ="DeleteStudent")]
        public ActionResult<IEnumerable<Student>> DeleteStudent(int id)
        {
            if (id < 0) return BadRequest();
            var deleting = collegeRepository.students.FirstOrDefault(n => n.studentID == id);
            if (deleting != null)collegeRepository.students.Remove(deleting);
            return Ok(deleting != null);
        }

        [HttpPost]
        public ActionResult<studentDTO> CreateStudent([FromBody]studentDTO Model)
        {
            if (Model == null) return BadRequest();
            int newId = collegeRepository.students.LastOrDefault().studentID + 1;
            Student studentnew = new ()
            {
                studentID = newId,
                name = Model.name,
                email = Model.email,
                age = Model.age
            };
            collegeRepository.students.Add(studentnew);

            return Ok();
        }
    }
}
