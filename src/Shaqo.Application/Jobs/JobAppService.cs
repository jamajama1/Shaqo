using Shaqo.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Shaqo.Jobs
{
    public class JobAppService :
    CrudAppService<
        Job, //The Job entity
        JobDto, //Used to show Jobs
        Guid, //Primary key of the Job entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateJobDto>, //Used to create/update a Job
    IJobAppService //implement the IJobAppService
    {
        public JobAppService(IRepository<Job, Guid> repository)
            : base(repository)
        {
            GetPolicyName = ShaqoPermissions.Jobs.Default;
            GetListPolicyName = ShaqoPermissions.Jobs.Default;
            CreatePolicyName = ShaqoPermissions.Jobs.Create;
            UpdatePolicyName = ShaqoPermissions.Jobs.Edit;
            DeletePolicyName = ShaqoPermissions.Jobs.Delete;
        }
    }
}
