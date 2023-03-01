using AutoMapper;
using Shaqo.Jobs;

namespace Shaqo;

public class ShaqoApplicationAutoMapperProfile : Profile
{
    public ShaqoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Job, JobDto>();
        CreateMap<CreateUpdateJobDto, Job>();
        CreateMap<JobDto, CreateUpdateJobDto>();
    }
}
