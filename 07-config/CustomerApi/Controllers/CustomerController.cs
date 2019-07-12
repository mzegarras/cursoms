using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerApi.Lib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;


namespace CustomerApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

          private readonly MongoOptions mongoOptions;

    public CustomersController(IOptions<MongoOptions> myOptions)
        {
            this.mongoOptions = myOptions.Value;
        }

         //public IConfiguration Configuration { get;private set; }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            string getEnv = Environment.GetEnvironmentVariable("CUSTOMER_NAME");

        
            return new string[] { "value2", "value3",getEnv };
        }

    }
}