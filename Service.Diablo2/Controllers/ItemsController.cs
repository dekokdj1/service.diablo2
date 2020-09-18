using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSwag.Annotations;
using Service.Diablo2.Database;
using Service.Diablo2.Entities.Models;

namespace Service.Diablo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly ILogger<ItemsController> _logger;
        private Diablo2Context _dbContext;

        public ItemsController(ILogger<ItemsController> logger, Diablo2Context context)
        {
            _logger = logger;
            _dbContext = context;
        }

        [HttpGet]
        [Route("diablo2items")]
        [SwaggerResponse(System.Net.HttpStatusCode.OK, typeof(IEnumerable<Diablo2Item>))]
        [SwaggerResponse(System.Net.HttpStatusCode.InternalServerError, typeof(string))]
        public IActionResult Get()
        {
            return Ok(_dbContext.Diablo2Items.Include(x => x.ItemType).ToList());
        }
    }
}
