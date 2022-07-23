using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public interface IEmployeeRepo
    {
        Task<Employee> MyDetailsAsync(int? id);
        Task<Employee> MyDetails_emailAsync(string email);
        Task<List<Employee>> ShowAllEMPAsync();
        Task<int> Insert_Employee_Async(EmployeeDb employee);
        Task<int> Login_Async(string email, string password);
        Task<int> Login_withID_Async(int id, string password);
        Task<int> DeleteEmp_Async(int? id);
        int UpdatePass(int? id, string pass);

    }
}
