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
        public string InsertHopDong(  bool tinh_trang,int so_ngay,string cmnd)
        {
            return db.InsertHopDong(  tinh_trang,so_ngay,cmnd);
        }
        [HttpGet]
        public string SearchHopDong(DateTime _from_ngay_thue, DateTime _to_ngay_thue, DateTime _from_ngay_tra, DateTime _to_ngay_tra, bool _tinh_trang)
        {
            return db.SearchHopDong(_from_ngay_thue, _to_ngay_thue, _from_ngay_tra, _to_ngay_tra, _tinh_trang);
        }
        [HttpGet]
        public string CTHopDOng(int id)
        {
            return db.ChiTietHopDong(id);
        }
        [HttpPost]
        public string InsertCTHD(string bien_so,double gia_thue,int so_ngay)
        {
            return db.InsertCTHD(bien_so, gia_thue, so_ngay);
        }
        [HttpPost]
        public string UpdateHopDong(int id,DateTime ngay_tra)
        {
            return db.UpdateHopDong(id, ngay_tra);
        }
    }
}
