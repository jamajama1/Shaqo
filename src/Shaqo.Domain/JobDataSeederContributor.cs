using Shaqo.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Shaqo
{
    public class JobDataSeederContributor: IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Job, Guid> _jobRepository;

        public JobDataSeederContributor(IRepository<Job, Guid> jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _jobRepository.GetCountAsync() <= 0)
            {
                await _jobRepository.InsertAsync(
                    new Job
                    {
                        Title = "test",
                        Salary= 1,
                        Description = "testsdsdssd",
                        Location = "testplace",
                        CompanyName = "testcompany"
                    },
                    autoSave: true
                ); ;

                await _jobRepository.InsertAsync(
                    new Job
                    {
                        Title = "asdasad",
                        Salary = 1,
                        Description = "asasavdasdv",
                        Location = "sdber",
                        CompanyName = "beber"
                    },
                    autoSave: true
                );
            }
        }
    }
}