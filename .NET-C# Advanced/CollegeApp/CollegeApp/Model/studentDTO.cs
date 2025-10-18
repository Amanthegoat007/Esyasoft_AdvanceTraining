using CollegeApp.Model.Validations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class StudentDTO
    {
        [ValidateNever]
        public int studentID {  get; set; }
        [StringLength(100)]
        [FirstCapital]
        public required string name { get; set; }
        [Range(5,30)]
        public int age { get; set; }

        [EmailAddress(ErrorMessage ="Enter email correctly!")]
        public required string email { get; set; }
        
        public required string Password { get; set; }
        [Compare("Password")]
        public required string confirmPassword { get; set; }
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

    }


}
