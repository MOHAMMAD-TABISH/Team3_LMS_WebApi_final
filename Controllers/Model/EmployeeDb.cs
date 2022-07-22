using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApi_LMS_Team3.Model
{
    public class EmployeeDb
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Email { get; set; }
        public long Emp_Mobile { get; set; }
        public string Emp_Dept { get; set; }
        public long Available_Leave { get; set; }
        public string Password { get; set; }
    }
}
