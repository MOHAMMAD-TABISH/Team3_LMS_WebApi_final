using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class Manager
    {

        public int serialno { get; set; }
        [Required]
        public string Mng_Name { get; set; }
        [Required]
        public string Mng_Email { get; set; }
        [Required]
        public long Mng_Mobile { get; set; }
        public int Mng_Id { get; set; }
    }
}