using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_LMS_Team3.Model
{
    public class ManagerDb
    {
        [Key]
        public int Mng_Id { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public string Mng_Name { get; set; }
        public string Mng_Email { get; set; }
        public long Mng_Mobile { get; set; }

    }
}