using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repository
{
    public class KhachRepository
    {
        public string InsertKhach(string cmnd,string ten,string dia_chi,string sdt,DateTime ngay_sinh,string anh)
        {
            string query = string.Format("select * from insert_khach('{0}','{1}','{2}','{3}','{4}','{5}')",cmnd,ten,dia_chi,sdt,ngay_sinh,anh);                
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string GetKhach(string cmnd, string ten, string dia_chi, string sdt, DateTime ngay_sinh, string anh)
        {
            string query = string.Format("select * from get_khach('{0}','{1}','{2}','{3}','{4}')", cmnd, ten, dia_chi, sdt, ngay_sinh);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
