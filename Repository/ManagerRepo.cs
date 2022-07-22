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
    public class ManagerRepo:IManagerRepo
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;

        public ManagerRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }


        public async Task<Manager> getManagerAsync(int? id)
        {
            var details = await dataAccessLayer_LMS.Manager_T.FirstOrDefaultAsync(x => x.Mng_Id == id);
            var details_View = mapper.Map<Manager>(details);

            return details_View;

        }

        public async Task<ManagerDb> getManagerdetailAsync(int? id)
        {
            var details = await dataAccessLayer_LMS.Manager_T.FirstOrDefaultAsync(x => x.EmployeeId == id);
            var details_View = mapper.Map<ManagerDb>(details);

            return details_View;

        }
        public async Task<List<Manager>> ShowAllMNGAsync()
        {
            var list_mng = await dataAccessLayer_LMS.Manager_T.ToListAsync();
            var map_list = mapper.Map<List<Manager>>(list_mng);
            return map_list;
        }

        public async Task<int> Insert_Manager_Async(ManagerDb manager)
        {
            var add = mapper.Map<ManagerDb>(manager);

            if (add != null)
            {
                await dataAccessLayer_LMS.Manager_T.AddAsync(add);
                await dataAccessLayer_LMS.SaveChangesAsync();

            }

            return 1;
        }
    }
    }

