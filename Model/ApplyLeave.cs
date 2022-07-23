using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class ApplyLeave
    {

        public int LeaveId { get; set; }
        [Required]
        public int Emp_Id { get; set; }
        [Required]
        public int NoOfDays { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string LeaveType { get; set; }
        [Required]
        public string LeaveStatus { get; set; }
        [Required]
        public string LeaveReason { get; set; }
        [Required]
        public DateTime AppliedOn { get; set; }
        [Required]
        public string Mng_Comments { get; set; }
    }
}