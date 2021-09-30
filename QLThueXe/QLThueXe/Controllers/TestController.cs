using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Services;
using System.Data;
using QLThueXe.Services.Repositor;
using QLThueXe.Connection;
using Newtonsoft.Json;

namespace QLThueXe.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {      
        
        TestRe tes = new TestRe();
        [HttpGet]
        public string Test()
        {

            return tes.GetData();
        }
        [HttpPost]
        public HttpResult TestF()
        {
           
            return tes.TestF();

        }
    }
}
