using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactAPI.DTOs;
using ReactAPI.Services.Interfaces;

namespace ReactAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {
        private readonly IFormService _service;

        public FormController(IFormService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitForm([FromBody] FormDTO formDto)
        {
            await _service.SubmitFormAsync(formDto);
            return Ok(new { message = "Form submitted successfully!" });
        }
    }
}
