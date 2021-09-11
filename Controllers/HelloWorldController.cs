using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace test1_webapi.Controllers {
    [ApiController]
    [Route("[controller]")]

    public class HelloWorldController : ControllerBase {
        
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger){
            _logger = logger;
        }

        [HttpGet]
        public string Get(){
            DateTime date = DateTime.Now;
            _logger.LogInformation(date+" :: Test log in helloworldcontroller");
            return "Hello World";
        }

        [HttpGet]
        [Route("user")]
        public UserModel GetCustomUser(int id) {
            UserModel user = new UserModel{
                Name = "Test User",
                Age = 20
            };
            _logger.LogInformation(DateTime.Now+" :: TEST USER :: "+user);
            return user;
        }

    }
}