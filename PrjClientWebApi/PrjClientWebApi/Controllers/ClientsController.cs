using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrjClientWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjClientWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        //https://localhost:44392/api/Clients
        [HttpGet]
        public IActionResult GetDescription()
        {
            DescriptionData description = new DescriptionData();
            description.Description = "Hello";
            description.Date = DateTime.Now;
            var values = description.Description + " " + description.Date;
            return Ok(values);
        }
    }
}
