using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public class ApplyLeaveRepo : IApplyLeaveRepo
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;

        public ApplyLeaveRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }

        public int ManagerState(int? id, ApplyLeave applyleave)
        {
            var data = dataAccessLayer_LMS.ApplyLeave_T.Where(x => x.LeaveId == id).FirstOrDefault();
            if (data != null)
            {
                data.Mng_Comments = applyleave.Mng_Comments;
                data.LeaveStatus = applyleave.LeaveStatus;
                dataAccessLayer_LMS.SaveChanges();
            }

            return 1;
        }

        /* public int ManagerState(int? id, ApplyLeave applyleave)
         {
             throw new NotImplementedException();
         }*/

        public async Task<int> NewLeaveAsync(ApplyLeaveDb leaveSection)
        {
            var data = mapper.Map<ApplyLeaveDb>(leaveSection);
            if (data != null)
            {
                await dataAccessLayer_LMS.ApplyLeave_T.AddAsync(data);
                await dataAccessLayer_LMS.SaveChangesAsync();
            }
            return 1;

        }

        /* public Task<int> NewLeave(ApplyLeave applyleave)
         {
             throw new NotImplementedException();
         }
 */
        public List<ApplyLeave> ShowAllLeaves(int? id)
        {
            var all_leaves = dataAccessLayer_LMS.ApplyLeave_T.Where(x => x.LeaveId == id);
            var leaves = mapper.Map<List<ApplyLeave>>(all_leaves);
            return leaves;

        }

        public List<ApplyLeave> ShowAllLeaves_Emp(int? id)
        {
            var all_leaves = dataAccessLayer_LMS.ApplyLeave_T.Where(x => x.Emp_Id == id);
            var leaves = mapper.Map<List<ApplyLeave>>(all_leaves);
            return leaves;

        }
        public List<ApplyLeave> ShowAllLeaves_Mng(int? id)
        {
            var all_leaves = dataAccessLayer_LMS.ApplyLeave_T.Where(x => x.Mng_Id == id);
            var leaves = mapper.Map<List<ApplyLeave>>(all_leaves);
            return leaves;

        }
        public int Update_approve(int? id)
        {
            var a = dataAccessLayer_LMS.ApplyLeave_T.FirstOrDefault(x => x.LeaveId == id);
            if (a != null)
            {
                a.LeaveStatus = "Approve";

                dataAccessLayer_LMS.SaveChanges();

            }

            return 1;
        }
        public int Update_deny(int? id)
        {
            var a = dataAccessLayer_LMS.ApplyLeave_T.FirstOrDefault(x => x.LeaveId == id);
            if (a != null)
            {
                a.LeaveStatus = "Denied";
                a.Mng_Comments = "I'm sorry I had to to refuse your request due to work Load";
                dataAccessLayer_LMS.SaveChanges();

            }

            return 1;
        }


    }
}