using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Last, First Name")]
        public string Name { get; set; }        
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [Display(Name = "Cell Phone")]
        public double CellPhone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [DisplayFormat(DataFormatString = "{0:somthing@email.com}", ApplyFormatInEditMode = true)]
        public string EmailAddress { get; set; }
        [Display(Name = "Birth Year")]
        public int YearBorn { get; set; }
        
    }
}
