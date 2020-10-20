using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WebApplication3
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly VueConfiguration vueConfiguration;
        private readonly IConfiguration configuration;
        public ValuesController(IOptions<VueConfiguration> vueConfigOption, IConfiguration config)
        {
            vueConfiguration = vueConfigOption.Value;
            configuration = config;
        }

        public ActionResult Get()
        {
            string url = configuration["vue:URL"];
            string urlFromConfigurationOption = vueConfiguration.URL;

            return Ok();
        }
    }
}
