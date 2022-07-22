using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;
using WebApi_LMS_Team3.Repository;

namespace WebApi_LMS_Team3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplyLeaveController : ControllerBase
    {
        private readonly IApplyLeaveRepo applyLeaveRepo;
        public ApplyLeaveController(IApplyLeaveRepo applyLeaveRepo)
        {
            this.applyLeaveRepo = applyLeaveRepo;

        }
        [HttpGet]
        [Route("ShowAll_Leaves/{id}")]
        public List<ApplyLeave> Leave_List(int? id)
        {
            var list = applyLeaveRepo.ShowAllLeaves(id);
            return list;
        }
        [HttpGet]
        [Route("Emp_Leaves/{id}")]
        public List<ApplyLeave> Leave_List_Emp(int? id)
        {
            var list = applyLeaveRepo.ShowAllLeaves_Emp(id);
            return list;
        }
        [HttpPatch]
        [Route("ChangeStatus/{id}")]

        public int ChangeState(int? id, ApplyLeave applyLeave)
        {
            var data = applyLeaveRepo.ManagerState(id, applyLeave);
            return 1;
        }
        [HttpPost]
        [Route("Leave")]
        public async Task<int>AddNewLeave(ApplyLeaveDb leave)
        {
            var newleave = await applyLeaveRepo.NewLeaveAsync(leave);
            return 1;
        }

    }
}
