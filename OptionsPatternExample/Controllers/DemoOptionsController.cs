using Microsoft.AspNetCore.Mvc;
using OptionsPatternExample.Settings;

namespace OptionsPatternExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoOptionsController : ControllerBase
    {
        private readonly IAplicationConfigurations _aplicationConfigurations;

        public DemoOptionsController(IAplicationConfigurations aplicationConfigurations) 
            => _aplicationConfigurations = aplicationConfigurations;

        [HttpGet]
        public string Get() 
            => $"The {_aplicationConfigurations.Name} is {_aplicationConfigurations.Title}";
    }
}
