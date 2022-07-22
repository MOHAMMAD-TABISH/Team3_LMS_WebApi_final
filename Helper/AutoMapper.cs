using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Helper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Employee, EmployeeDb>().ReverseMap();
            CreateMap<ApplyLeave, ApplyLeaveDb>().ReverseMap();
            CreateMap<Manager, ManagerDb>().ReverseMap();
        }
    }
}
