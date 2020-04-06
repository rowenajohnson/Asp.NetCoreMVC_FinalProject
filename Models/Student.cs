using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectStudentTutorialManagement.Models
{
    public enum Status
    {
        Undergraduate, Postgraduate, PhD, Suspended
    }
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }
        public int GenderId { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public Status? Status { get; set; }
    }
}
