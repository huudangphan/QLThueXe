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
    public class HopDongController : ControllerBase
    {
        HopDongRepository db = new HopDongRepository();
        [HttpPost]
        public string InsertHopDong(DateTime ngay_thue, DateTime ngay_tra, bool tinh_trang,DateTime ngay_tra_du_tinh)
        {
            return db.InsertHopDong(ngay_thue, ngay_tra, tinh_trang,ngay_tra_du_tinh);
        }
        [HttpGet]
        public string SearchHopDong(DateTime _from_ngay_thue, DateTime _to_ngay_thue, DateTime _from_ngay_tra, DateTime _to_ngay_tra, bool _tinh_trang)
        {
            return db.SearchHopDong(_from_ngay_thue, _to_ngay_thue, _from_ngay_tra, _to_ngay_tra, _tinh_trang);
        }
    }
}
