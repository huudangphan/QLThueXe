using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repository
{
    public class HopDongRepository
    {
        public string InsertHopDong(string ngay_thue,string cmnd,double tien_coc)
        {
            string query = string.Format("select * from insert_hop_dong('{0}','{1}',{2})",   ngay_thue,cmnd,tien_coc);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string SearchHopDong(string cmnd)
        {
            string query = string.Format("select * from search_hop_dong('{0}')", cmnd) ;
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string ChiTietHopDong(string id)
        {
            //           string query = string.Format(@"select * from ct_hop_dong ct,(select * from hop_dong hd join khach k on hd.cmnd= hd.cmnd where id_hop_dong={0}) _hd
            //where _hd.id_hop_dong=ct.id_hop_dong",id);
            string query = string.Format("select * from search_ct_hop_dong_byid('{0}')", id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        //select * from insert_ct_hop_dong('19H',23434,5,'0001-01-01',140232)
        public string InsertCTHD(string bien_so,double gia_thue,int so_ngay,int km_hien_tai)
        {
            string query = string.Format(@"select * from insert_ct_hop_dong('{0}',{1},{2},'{3}',{4})", bien_so, gia_thue, so_ngay,"0001-01-01",km_hien_tai);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string UpdateHopDong(string id_hop_dong,int km_tra,string bien_so)
        {
            string query = string.Format(@"select * from  update_hop_dong('{0}',{1},'{2}')", id_hop_dong,km_tra,bien_so);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string Search_ct_hop_dong_byid(string id)
        {
            string query = string.Format("select * from search_ct_hop_dong_byid('{0}')",id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string Search_phieu_phat_by_id(string id)
        {
            string query = string.Format("select * from search_phieu_phat_byid({0})", id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string Search_Hoa_Don(string id_hop_dong,string bien_so)
        {
            string query = string.Format("select * from search_hoa_don('{0}','{1}')",id_hop_dong,bien_so);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
