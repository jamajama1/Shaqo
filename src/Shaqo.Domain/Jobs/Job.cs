using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shaqo.Jobs
{
    public class Job : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ApplyUrl { get; set; }
    }
}
