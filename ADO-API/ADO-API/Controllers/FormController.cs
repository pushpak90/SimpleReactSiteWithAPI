using businessLogic.BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly FormLogic _formLogic;

        public FormController(FormLogic formLogic)
        {
            _formLogic = formLogic;
        }

        [HttpPost]
        public async Task<IActionResult> Submit([FromBody] FormObj obj)
        {
            var result = await _formLogic.submitForm(obj);
            return Ok(result);
        }
    }
}
