using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public interface IApplyLeaveRepo
    {
        List<ApplyLeave> ShowAllLeaves(int? id);
        List<ApplyLeave> ShowAllLeaves_Emp(int? id);
        List<ApplyLeave> ShowAllLeaves_Mng(int? id);
        int ManagerState(int? id, ApplyLeave applyleave);
        int Update_approve(int? id);
        int Update_deny(int? id);
        Task<int> NewLeaveAsync(ApplyLeaveDb applyleave);


    }
}