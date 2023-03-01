using Microsoft.AspNetCore.Mvc;
using Shaqo.Jobs;
using System.Threading.Tasks;

namespace Shaqo.Web.Pages.Jobs
{
    public class CreateModalModel : ShaqoPageModel
    {
        [BindProperty]
        public CreateUpdateJobDto Job { get; set; }

        private readonly IJobAppService _JobAppService;

        public CreateModalModel(IJobAppService JobAppService)
        {
            _JobAppService = JobAppService;
        }

        public void OnGet()
        {
            Job = new CreateUpdateJobDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _JobAppService.CreateAsync(Job);
            return NoContent();
        }
    }
}
