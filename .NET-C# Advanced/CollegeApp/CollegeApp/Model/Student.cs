using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Student
    {
        [Required]
        public int studentID { get; set; }
        public required string name { get; set; }
        public int age { get; set; }
        public required string email { get; set; }
    }
}
