using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity2.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name="First Name"), 
            RegularExpression(@"[a-zA-Z""'\s-]*$"),
            StringLength(50, MinimumLength =1, ErrorMessage = "First name must be 1-50 characters.")]
        public string FirstMidName { get; set; }
        [Display(Name = "Last Name"), 
            RegularExpression(@"[a-zA-Z""'\s-]*$"),
            StringLength(50, MinimumLength =1, ErrorMessage = "Last name must be 1-50 characters.")]
        public string LastName { get; set; }
        [DataType(DataType.Date), Display(Name = "Enrollment Date"),
            DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        [Display(Name ="Student Name")]
        public string StudentName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }
    }
}
