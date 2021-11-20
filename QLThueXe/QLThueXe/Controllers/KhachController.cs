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
        public string InsertKhach(string cmnd, string ten, string dia_chi, string sdt, string ngay_sinh, string anh)
        {
            return db.InsertKhach(cmnd, ten, dia_chi, sdt, ngay_sinh, anh);
        }
        [HttpGet]
        public string GetKhach(string cmnd, string ten, string dia_chi, string sdt, DateTime ngay_sinh, string anh)
        {
            return db.GetKhach(cmnd, ten, dia_chi, sdt, ngay_sinh, anh);
        }
        [HttpGet]
        public string GetKhachById(int id_hop_dong)
        {
            return db.GetKhachByID(id_hop_dong);
        }
        [HttpPost]
        public int DangNhap(string username,string password)
        {
            if (db.DangNhap(username, password) == "[{\"?column?\":1}]")
                return 200;
            else
                return 19;
        }
        [HttpPost]
        public void ThemTaiKhoan(string username,string password)
        {
            db.ThemTaiKhoan(username, password);
        }
        [HttpPost]
        public void XoaTaiKhoan(string username)
        {
            db.XoaTaiKhoan(username);
        }
    }
}
