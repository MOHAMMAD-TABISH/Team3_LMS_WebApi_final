using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;
using WebApi_LMS_Team3.Repository;

namespace WebApi_LMS_Team3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee_LMSController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;

        public Employee_LMSController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        [HttpGet]
        [Route("MyDetails/{id}")]

        public async Task<IActionResult> MyDetails_Id(int? id)
        {
            var get_details = await employeeRepo.MyDetailsAsync(id);
            return Ok(get_details);
        }
        [HttpGet]
        [Route("MyDetail/{email}")]

        public async Task<IActionResult> MyDetails_email(string email)
        {
            var get_detail = await employeeRepo.MyDetails_emailAsync(email);
            return Ok(get_detail);
        }
        [HttpGet]
        [Route("ShowAll")]

        public async Task<IActionResult> ShowAll()
        {
            var get_allemp = await employeeRepo.ShowAllEMPAsync();
            return Ok(get_allemp);
        }
        [HttpPost]
        [Route("InsertEmpolyee")]
        public async Task<int> InsertEmployee(EmployeeDb employeeModel)
        {
            var add = await employeeRepo.Insert_Employee_Async(employeeModel);
            return 1;
        }
        [HttpGet]
        [Route("Login")]
        public async Task<int> Login(string email, string password)
        {
            var add = await employeeRepo.Login_Async(email, password);
            if (add == 0)
            {
                return 0;
            }
            return 1;
        }
        [HttpGet]
        [Route("LoginID")]
        public async Task<int> LoginID(int id, string password)
        {
            var add = await employeeRepo.Login_withID_Async(id, password);
            if (add == 0)
            {
                return 0;
            }
            return 1;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<int> Delete(int? id)
        {
            var get_details = await employeeRepo.DeleteEmp_Async(id);
            return 1;
        }

    }
}
