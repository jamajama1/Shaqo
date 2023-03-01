using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using Shaqo.Jobs;

namespace Shaqo.Web.Pages.Jobs
{
    public class EditModalModel : ShaqoPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateJobDto Job { get; set; }

        private readonly IJobAppService _JobAppService;

        public EditModalModel(IJobAppService JobAppService)
        {
            _JobAppService = JobAppService;
        }

        public async Task OnGetAsync()
        {
            var JobDto = await _JobAppService.GetAsync(Id);
            Job = ObjectMapper.Map<JobDto, CreateUpdateJobDto>(JobDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _JobAppService.UpdateAsync(Id, Job);
            return NoContent();
        }
    }
}
