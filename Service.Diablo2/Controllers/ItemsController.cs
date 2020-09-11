using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Diablo2.Entities.Models;

namespace service.diablo2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Diablo2Item> Get()
        {
            return new List<Diablo2Item>();
        }
    }
}
