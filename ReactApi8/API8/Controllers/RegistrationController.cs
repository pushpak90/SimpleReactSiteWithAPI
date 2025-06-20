using API8.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegistrationSubmit([FromBody] RegistrationDTO registrationDto)
        {
            if (registrationDto == null)
            {
                return BadRequest(new { message = "Invalid registration data." });
            }
            // Here you would typically call a service to handle the registration logic
            // For example: await _registrationService.RegisterAsync(registrationDto);
            return Ok(new { message = "Registration successful!" });
        }
    }
}
