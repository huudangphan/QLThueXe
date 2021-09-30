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
    public class XeController : ControllerBase
    {
        XeRepository db = new XeRepository();
        [HttpPost]
        public string InsertDataXe(string bien_so, int id_hang, string ten_xe, double gia_thue, string ma_ks,bool status)
        {
            
                return db.InsertData(bien_so, id_hang, ten_xe, gia_thue, ma_ks,status);
            
            
        }
        [HttpGet]
        public string SearchDataXe(string bien_so, int id_hang, string ten_xe, double gia_thue, string ma_ks,bool status)
        {
            
                return db.SearchXe(bien_so, id_hang, ten_xe, gia_thue, ma_ks,status);

        }
        [HttpPut]
        public string UpdateXe(string bien_so,double gia_thue,bool status)
        {
            return db.UpdateXe(bien_so, gia_thue,status);
        }
    }
}
