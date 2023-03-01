using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Shaqo.Jobs
{
    public interface IJobAppService :
    ICrudAppService< //Defines CRUD methods
        JobDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateJobDto> //Used to create/update a book
    {

    }
}
