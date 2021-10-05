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
    public class CthdController : ControllerBase
    {
        CthdRepository db =new CthdRepository();
        [HttpPost]
        public string InsertCthd(string bien_so_hd, string cmnd_hd, double gia_thue, int ngaythue)
        {
            return db.InsertCthd(bien_so_hd, cmnd_hd, gia_thue, ngaythue);
        }
        [HttpGet]
        public string SearchCthd(int id)
        {
            return db.SearchCthd(id);
        }
    }
}
