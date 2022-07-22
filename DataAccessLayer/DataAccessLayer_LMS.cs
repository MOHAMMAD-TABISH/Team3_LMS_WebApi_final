using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.DataAccessLayer
{
    public class DataAccessLayer_LMS:DbContext
    {
        public DataAccessLayer_LMS(DbContextOptions<DataAccessLayer_LMS> option) : base(option)
        {

        }
        public DbSet<EmployeeDb> Employee_T { get; set; }
        public DbSet<ManagerDb> Manager_T { get; set; }
        public DbSet<ApplyLeaveDb> ApplyLeave_T { get; set; }
        
      
    }
}
