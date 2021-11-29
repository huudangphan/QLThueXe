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
        public string InsertHopDong(DateTime ngay_thue, string cmnd, double tien_coc)
        {
            return db.InsertHopDong(  ngay_thue,cmnd,tien_coc);
        }
        [HttpGet]
        public string SearchHopDong(string cmnd)
        {
            return db.SearchHopDong(cmnd);
        }
        [HttpGet]
        public string CTHopDOng(string id)
        {
            return db.ChiTietHopDong(id);
        }
        [HttpPost]
        public string InsertCTHD(string bien_so, double gia_thue, int so_ngay, int km_hien_tai)
        {
            return db.InsertCTHD(bien_so, gia_thue, so_ngay,km_hien_tai);
        }
        [HttpPost]
        public string UpdateHopDong(string id_hop_dong, int km_tra, string bien_so)
        {
            return db.UpdateHopDong(id_hop_dong,km_tra,bien_so);
        }
        [HttpGet]
        public string SearchCTHD(string id)
        {
            return db.Search_ct_hop_dong_byid(id);
        }
        [HttpGet]
        public string SearchPhieuPhat(string id)
        {
            return db.Search_phieu_phat_by_id(id);
        }
    }
}
