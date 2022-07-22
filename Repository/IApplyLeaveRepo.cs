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
        int ManagerState(int? id, ApplyLeave applyleave);

        Task<int> NewLeaveAsync(ApplyLeaveDb applyleave);

    }
}
