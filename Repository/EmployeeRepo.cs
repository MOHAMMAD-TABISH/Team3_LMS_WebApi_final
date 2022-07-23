using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public class EmployeeRepo:IEmployeeRepo
    {

        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;

        public EmployeeRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }



        public async Task<int> Insert_Employee_Async(EmployeeDb employee)
        {
            var add = mapper.Map<EmployeeDb>(employee);

            if (add != null)
            {
                await dataAccessLayer_LMS.Employee_T.AddAsync(add);
                await dataAccessLayer_LMS.SaveChangesAsync();

            }

            return 1;
        }
        public async Task<int> Login_Async(string email, string password)
        {
            var data = await dataAccessLayer_LMS.Employee_T.FirstOrDefaultAsync(x => x.Emp_Email == email & x.Password == password);
            if (data != null)
            {

                var map = mapper.Map<Employee>(data);
                return 1;
            }

            return 0;

        }
        public async Task<int> Login_withID_Async(int id, string password)
        {
            var data = await dataAccessLayer_LMS.Employee_T.FirstOrDefaultAsync(x => x.Emp_Id == id & x.Password == password);
            if (data != null)
            {

                var map = mapper.Map<Employee>(data);
                return 1;
            }

            return 0;

        }
        public async Task<Employee> MyDetailsAsync(int? id)
        {
            var details = await dataAccessLayer_LMS.Employee_T.FirstOrDefaultAsync(x => x.Emp_Id == id);
            var details_View = mapper.Map<Employee>(details);

            return details_View;
        }
        public async Task<Employee> MyDetails_emailAsync(string email)
        {
            var detail = await dataAccessLayer_LMS.Employee_T.FirstOrDefaultAsync(x => x.Emp_Email == email);
            var detail_View = mapper.Map<Employee>(detail);

            return detail_View;
        }

        public async Task<List<Employee>> ShowAllEMPAsync()
        {
            var list_emp = await dataAccessLayer_LMS.Employee_T.ToListAsync();
            var map_list = mapper.Map<List<Employee>>(list_emp);
            return map_list;
        }
        public async Task<int> DeleteEmp_Async(int? id)
        {
            var data = await dataAccessLayer_LMS.Employee_T.FirstAsync(x => x.Emp_Id == id);
            if (data != null)
            {
                dataAccessLayer_LMS.Employee_T.Remove(data);
                await dataAccessLayer_LMS.SaveChangesAsync();
            }

            return 1;
        }
        public int UpdatePass(int? id, string pass)
        {
            var a = dataAccessLayer_LMS.Employee_T.FirstOrDefault(x => x.Emp_Id == id);
            if (a != null)
            {
                a.Password = pass;
                
                dataAccessLayer_LMS.SaveChanges();

            }

            return 1;
        }

    }
}
