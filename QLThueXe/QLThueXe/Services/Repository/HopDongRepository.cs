using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repository
{
    public class HopDongRepository
    {
        public string InsertHopDong(DateTime ngay_thue,DateTime ngay_tra,bool tinh_trang)
        {
            string query = string.Format("select * from insert_hop_dong('{0}','{1}','{2}')", ngay_thue, ngay_tra, tinh_trang);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string SearchHopDong(DateTime _from_ngay_thue,DateTime _to_ngay_thue,DateTime _from_ngay_tra,DateTime _to_ngay_tra,bool _tinh_trang)
        {
            string query = string.Format("select * from search_hop_dong('{0}','{1}','{2}','{3}','{4}')", _from_ngay_thue, _to_ngay_thue, _from_ngay_tra, _to_ngay_tra, _tinh_trang) ;
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
