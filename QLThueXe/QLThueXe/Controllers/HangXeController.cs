using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Services.Repository;
namespace QLThueXe.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HangXeController : ControllerBase
    {
        HangXeRepository db = new HangXeRepository();
        [HttpGet]
        public string GetData()
        {
            return db.GetData();
        }
        [HttpPost]
        public void InsertData(string hang_xe)
        {
            db.InsertData(hang_xe);
        }
    }
}
