using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repository
{
    public class HopDongRepository
    {
        public string InsertHopDong(bool tinh_trang,int so_ngay,string cmnd)
        {
            string query = string.Format("select * from insert_hop_dong({0},'{1}','{2}')",   tinh_trang,so_ngay,cmnd);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string SearchHopDong(DateTime _from_ngay_thue,DateTime _to_ngay_thue,DateTime _from_ngay_tra,DateTime _to_ngay_tra,bool _tinh_trang)
        {
            string query = string.Format("select * from search_hop_dong('{0}','{1}','{2}','{3}','{4}')", _from_ngay_thue, _to_ngay_thue, _from_ngay_tra, _to_ngay_tra, _tinh_trang) ;
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string ChiTietHopDong(int id)
        {
            string query = string.Format(@"select * from ct_hop_dong ct,(select * from hop_dong hd join khach k on hd.cmnd= hd.cmnd where id_hop_dong={0}) _hd
	where _hd.id_hop_dong=ct.id_hop_dong",id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string InsertCTHD(string bien_so,double gia_thue,int so_ngay)
        {
            string query = string.Format(@"select * from insert_ct_hop_dong('{0}',{1},{2})", bien_so, gia_thue, so_ngay);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string UpdateHopDong(int id,DateTime ngay_tra)
        {
            string query = string.Format(@"select * from  update_hop_dong({0},'{1}')", id, ngay_tra);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
