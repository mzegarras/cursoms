using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CustomerApi.Data;
namespace CustomerApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            var dbConnection = DBConnection.Instance();
dbConnection.IsConnect();
            return new string[] { "value2", "value3" };
        }

    }
}