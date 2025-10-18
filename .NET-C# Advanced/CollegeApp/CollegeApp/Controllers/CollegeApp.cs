using CollegeApp.Data;
using CollegeApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        private readonly CollegeDBContext _DBContext;

        public CollegeAppController(CollegeDBContext DBContext)
        {
            _DBContext = DBContext;
        }

        [HttpGet]
        [Route("All")]
        public async Task< ActionResult<Student>> GetStudents()            
        {

            //var students = _DBContext.Students.ToList();
            var students =await _DBContext.Students.Select(s => new Student()
            {
                name = s.name,
                age = s.age,
                email = s.email,
                Password = s.Password,
                confirmPassword = s.confirmPassword,
                AdmissionDate = s.AdmissionDate
            }).ToListAsync();
            return Ok(students);

        }
        [HttpGet("{id:int}", Name = "GetStudentById")]
        public async Task< ActionResult<StudentDTO>> getStudentById(int id)
        {
            if (id <= 0) return BadRequest();
            var s =await _DBContext.Students.Where(n => n.studentID == id).FirstOrDefaultAsync();

            if (s == null) return NotFound();
            var studentDTO = new StudentDTO()
            {
                name = s.name,
                age = s.age,
                email = s.email,
                Password = s.Password,
                confirmPassword = s.confirmPassword,
                AdmissionDate = s.AdmissionDate
            };
            return Ok(studentDTO);
        }

        //public ActionResult<IEnumerable<Student>> GetStudentById(int id)
        //{
        //    if (id < 0) return BadRequest();
        //    Student s = _DBContext.Students.First(n => n.studentID == id);
        //    if (s == null) return NotFound();
        //    return Ok(s);
        //}

        //[HttpGet("{name:alpha}", Name = "GetStudentByName")]

        //public ActionResult<IEnumerable<Student>> GetStudentByName(string name)
        //{
        //    if (name == null || name == "") return BadRequest();
        //    Student s = (_DBContext.Students.First(n => n.name == name));
        //    if (s == null) return NotFound();
        //    var studentDTO1 = new Student()
        //    {
        //        name = s.name,
        //        age = s.age,
        //        email = s.email,
        //        Password = s.Password,
        //        confirmPassword = s.confirmPassword,
        //        AdmissionDate = s.AdmissionDate
        //    };
        //    return Ok(studentDTO1);
        //}
        ////public ActionResult<IEnumerable<Student>> GetStudentByName(string name)
        ////{
        ////    if (name == null || name == "") return BadRequest();
        ////    Student s = (_DBContext.Students.First(n => n.name == name));
        ////    if (s == null) return NotFound();
        ////    return Ok(s);
        ////}

        //[HttpDelete("{id:int}", Name = "DeleteStudent")]
        //public ActionResult<IEnumerable<Student>> DeleteStudent(int id)
        //{
        //    if (id < 0) return BadRequest();
        //    var deleting = _DBContext.Students.FirstOrDefault(n => n.studentID == id);
        //    if (deleting != null) _DBContext.Students.Remove(deleting);
        //    return Ok(deleting != null);
        //}

        [HttpPost]
        [ProducesResponseType(400)]
        public ActionResult<Student> CreateStudent([FromBody] Student Model)
        {
            if (Model == null) return BadRequest();
            //int newId = _DBContext.Students.LastOrDefault().studentID + 1;
            Student studentnew = new Student()
            {
                //studentID = newId,
                name = Model.name,
                email = Model.email,
                age = Model.age,
                Password = Model.Password,
                confirmPassword = Model.confirmPassword,
                AdmissionDate = Model.AdmissionDate,
            };
            _DBContext.Students.Add(studentnew);

            _DBContext.SaveChanges(); 

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<Student> UpdateStudent([FromBody] Student model)
        {
            if (model == null || model.studentID <= 0) return BadRequest();

            var existingStudent = _DBContext.Students.Where(s => s.studentID == model.studentID).FirstOrDefault();

            if (existingStudent == null) return NotFound($"The student with id {model.studentID} not found");

            //existingStudent.name = model.name;
            //existingStudent.email = model.email;
            existingStudent.age = model.age;
            existingStudent.Password = model.Password;
            existingStudent.confirmPassword = model.confirmPassword;
            existingStudent.AdmissionDate = model.AdmissionDate;
            _DBContext.SaveChanges();
            return Ok(existingStudent);
        }

        //[HttpPatch]
        //[Route("{id:int}/UpdatePartial")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(500)]
        //public ActionResult<Student> UpdateStudentById(int id, [FromBody] JsonPatchDocument<Student> patchDocument)
        //{
        //    if (patchDocument == null || id <= 0) return BadRequest();
        //    var existingStudent = _DBContext.Students.Where(n => n.studentID == id).FirstOrDefault();
        //    if (existingStudent == null) return NotFound($"The student with id {id} not found!");

        //    var studentDTO = new Student()
        //    {
        //        studentID = existingStudent.studentID,
        //        name = existingStudent.name,
        //        email = existingStudent.email,
        //        age = existingStudent.age,
        //        Password= existingStudent.Password,
        //        confirmPassword= existingStudent.confirmPassword,
        //        AdmissionDate= existingStudent.AdmissionDate
        //    };
        //    patchDocument.ApplyTo(studentDTO, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    existingStudent.name = studentDTO.name;
        //    existingStudent.email = studentDTO.email;
        //    existingStudent.age = studentDTO.age;
        //    existingStudent.AdmissionDate = studentDTO.AdmissionDate;
        //    existingStudent.Password = studentDTO.Password;
        //    existingStudent.confirmPassword = studentDTO.confirmPassword;
        //    return NoContent();
        //}


    }


}
