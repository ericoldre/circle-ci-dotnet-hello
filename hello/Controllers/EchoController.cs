using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public EchoController(IConfiguration config)
        {
            this.Configuration = config;
        }

        [HttpGet]
        [Route("headers")]
        public Dictionary<string, string> EchoHeaders()
        {
            Dictionary<string, string> results = new Dictionary<string, string>();

            foreach(var h in this.Request.Headers)
            {
                results.Add(h.Key, h.Value);
            }

            return results;
        }

        [HttpGet]
        [Route("config")]
        public Dictionary<string,string> EchoConfig()
        {
            Dictionary<string, string> results = new Dictionary<string, string>();

            foreach (var kvp in this.Configuration.AsEnumerable())
            {
                results.Add(kvp.Key, kvp.Value);
            }

            return results;
        }

        [HttpGet]
        [Route("user")]
        public string EchoUser()
        {
            return this.User?.Identity?.Name;
        }
    }
}
