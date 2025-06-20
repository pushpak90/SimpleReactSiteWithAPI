using API8.DTOs;
using API8.Repositories.Interfaces;
using API8.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProspectController : ControllerBase
    {
        private readonly IProspectService _prospect;

        public ProspectController(IProspectService prospect)
        {
            _prospect = prospect;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitForm([FromBody] ProspectDTO formDto)
        {
            await _prospect.SubmitFormAsync(formDto);
            return Ok(new { message = "Form submitted successfully!" });
        }
    }
}
