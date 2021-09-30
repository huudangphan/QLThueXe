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
    public class KhachController : ControllerBase
    {
        KhachRepository db = new KhachRepository();
        [HttpPost]
        public string InsertKhach(string cmnd, string ten, string dia_chi, string sdt, DateTime ngay_sinh, string anh)
        {
            return db.InsertKhach(cmnd, ten, dia_chi, sdt, ngay_sinh, anh);
        }
        [HttpGet]
        public string GetKhach(string cmnd, string ten, string dia_chi, string sdt, DateTime ngay_sinh, string anh)
        {
            return db.GetKhach(cmnd, ten, dia_chi, sdt, ngay_sinh, anh);
        }
    }
}
