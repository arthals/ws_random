using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BueiroController : ControllerBase
    {
                private readonly ILogger<BueiroController> _logger;

        public BueiroController(ILogger<BueiroController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public  void InserirBueiros(Bueiro bueiro)
        {
            //... o codigo que faz algo com o bueiro
        }
    }
}
