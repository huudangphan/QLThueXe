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
    public class BaoHanhController : ControllerBase
    {

        BaoHanhRepository bh = new BaoHanhRepository();
        [HttpGet]
        public string GetBaoHanh()
        {
            return bh.GetBaoHanh();
        }
        [HttpGet]
        public string GetCTBaoHanh(string id_phieu)
        {
            return bh.GetCTBaoHanh(id_phieu);
        }
        [HttpPost]
        public string InsertBaoHanh(string date)
        {
            return bh.InsertBaoHanh(date);
        }
        [HttpPost]
        public string InsertCTBaoHanh(string bien_so,double chi_phi,string ghi_chu)
        {
            return bh.InsertCTBaoHanh(bien_so, chi_phi, ghi_chu);
        }
    }
}
