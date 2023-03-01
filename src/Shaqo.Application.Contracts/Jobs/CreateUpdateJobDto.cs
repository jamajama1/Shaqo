using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Shaqo.Jobs
{
    public class CreateUpdateJobDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [Required]
        [StringLength(128)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(128)]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        /*[Required]
        [DataType(DataType.Url)]
        public string ApplyUrl { get; set; }*/
    }
}
