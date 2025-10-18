using CollegeApp.Model.Validations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeApp.Data
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentID { get; set; }
       
        public string  name { get; set; }
   
        public int? age { get; set; }

        //[EmailAddress(ErrorMessage = "Enter email correctly!")]
        public string? email { get; set; }

        public string Password { get; set; }
        //[Compare("Password")]
        public string confirmPassword { get; set; }
        //[DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }
    }
}
