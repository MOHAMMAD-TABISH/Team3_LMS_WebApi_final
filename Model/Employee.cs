using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class Employee
    {
        public int Emp_Id { get; set; }
        [Required]
        public string Emp_Name { get; set; }
        [Required]
        public string Emp_Email { get; set; }
        [Required]
        public long Emp_Mobile { get; set; }
        [Required]
        public string Emp_Dept { get; set; }
        [Required]
        public long Available_Leave { get; set; }
        public string image { get; set; }
    }
}
