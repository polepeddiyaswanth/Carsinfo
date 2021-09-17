using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public string GetName()
        {
            return "john Doe";
        }

        [Route("getAge")]
        [HttpGet]

        public int GetAge()
        {
            return 10;
        }

         [Route("sendData")]

            public void SendData([FromBody]Person p)
        {
            Console.WriteLine(p.firstname + " " + p.lastname);
        }
    }
}       