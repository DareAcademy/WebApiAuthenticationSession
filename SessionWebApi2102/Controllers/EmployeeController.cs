using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionWebApi2102.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionWebApi2102.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class EmployeeController : ControllerBase
    {
        // data type
        [HttpGet]
        [Route("GetData")]
        public string Get(string name)
        {
            string msg = "Hello "+name ;
            return msg;
        }

        [HttpGet]
        [Route("Load")]
        public string Load()
        {
            return "hi";
        }
        
        [HttpPost]
        public Employee Post(Employee emp)
        {
            return emp;
            //return "this is post metho";
        }

     

    }
}
