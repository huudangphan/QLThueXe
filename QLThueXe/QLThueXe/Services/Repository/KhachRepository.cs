using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repository
{
    public class KhachRepository
    {
        public string InsertKhach(string cmnd,string ten,string dia_chi,string sdt,string ngay_sinh,string anh)
        {
            string query = string.Format("select * from insert_khach('{0}','{1}','{2}','{3}','{4}','{5}')",cmnd,ten,dia_chi,sdt,ngay_sinh,anh);                
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string GetKhach(string cmnd, string ten, string dia_chi, string sdt, DateTime ngay_sinh, string anh)
        {
            string query = string.Format("select * from get_khach('{0}','{1}','{2}','{3}','{4}')", cmnd, ten, dia_chi, sdt, ngay_sinh);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string GetKhachByID(int id_hop_dong)
        {
            string query = string.Format("select k.*   from khach k join  (select cmnd, ct.* from ct_hop_dong ct " +
                "join hop_dong h on ct.id_hop_dong = h.id_hop_dong and h.id_hop_dong = {0}) hd   on k.cmnd = hd.cmnd",id_hop_dong);

            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string DangNhap(string username,string password)
        {
            //Server=localhost;Port=5432;User Id=postgres;Password=24122021;Database=MyDB;Pooling=false;Timeout=300;CommandTimeout=300
            DataBaseServices.conStr = String.Format("Server=localhost;Port=5432;User Id={0};Password={1};Database=MyDB", username, password);
            return DataBaseServices.Instance.ExecuteQuery("select 1 ");
        }
        public void ThemTaiKhoan(string username,string password)
        {
            string query = string.Format("create user {0} with password '{1}'", username, password);
            string query2 = string.Format("grant employee to {0}", username);
            DataBaseServices.Instance.ExecuteQuery(query);
            DataBaseServices.Instance.ExecuteQuery(query2);
        }
        public void XoaTaiKhoan(string username)
        {
            string query = string.Format("drop user {0}", username);
            DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
