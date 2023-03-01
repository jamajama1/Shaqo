using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Shaqo.Jobs
{
    public class JobDto: FullAuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public decimal Salary { get; set; }
    }

}
