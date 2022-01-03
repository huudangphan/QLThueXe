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
            string query = string.Format("BEGIN TRANSACTION; SET TRANSACTION ISOLATION LEVEL SERIALIZABLE; ");
            string query2= string.Format("select * from insert_hop_dong('{0}','{1}',{2});", ngay_thue, cmnd, tien_coc);
            string query3 = "commit";
            DataBaseServices.Instance.ExecuteQuery(query);
            var a= DataBaseServices.Instance.ExecuteQuery(query2);
            DataBaseServices.Instance.ExecuteQuery(query3);
            return a;

        }
        public string SearchHopDong(string cmnd)
        {
            string query2 = string.Format("BEGIN TRANSACTION; SET TRANSACTION ISOLATION LEVEL REPEATABLE READ; ");
            string query = string.Format("select * from search_hop_dong('{0}');commit", cmnd) ;
            DataBaseServices.Instance.ExecuteNonQuery(query2);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string ChiTietHopDong(string id)
        {           
            string query = string.Format("select * from search_ct_hop_dong_byid('{0}')", id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        //select * from insert_ct_hop_dong('19H',23434,5,'0001-01-01',140232)
        public string InsertCTHD(string bien_so,double gia_thue,int so_ngay,int km_hien_tai)
        {
            string query2 = string.Format("BEGIN TRANSACTION; SET TRANSACTION ISOLATION LEVEL SERIALIZABLE; ");
            DataBaseServices.Instance.ExecuteQuery(query2);
            string query = string.Format(@"select * from insert_ct_hop_dong('{0}',{1},{2},'{3}',{4}) ;commit", bien_so, gia_thue, so_ngay,"0001-01-01",km_hien_tai);

            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string UpdateHopDong(string id_hop_dong,int km_tra,string bien_so)
        {
            string query2 = string.Format("BEGIN TRANSACTION; SET TRANSACTION ISOLATION LEVEL SERIALIZABLE; ");
            DataBaseServices.Instance.ExecuteQuery(query2);
            string query = string.Format(@"select * from  update_hop_dong('{0}',{1},'{2}');commit;", id_hop_dong,km_tra,bien_so);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string Search_ct_hop_dong_byid(string id)
        {
            string query2 = string.Format("BEGIN TRANSACTION; SET TRANSACTION ISOLATION LEVEL REPEATABLE READ; ");
            DataBaseServices.Instance.ExecuteQuery(query2);
            string query = string.Format("select * from search_ct_hop_dong_byid('{0}');commit;",id);
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
        public string Get_tai_xe()
        {
            string query = "select * from taixe";
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string InsertTaiXe(string cmnd,string tai_xe,DateTime ngaysinh)
        {
            string query = string.Format("select * from insert_taixe('{0}','{1}','{2}')", cmnd, tai_xe, ngaysinh);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string InsertPhanCong(string cmnd,string bien_so,DateTime from_date,int so_ngay)
        {
            string query = string.Format("select * from insert_phan_cong('{0}','{1}','{2}',{3})",cmnd,bien_so,from_date,so_ngay);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string TraTienCoc(string id)
        {
            string query = string.Format("update hop_dong set tra_coc='true' where id_hop_dong='{0}'",id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
