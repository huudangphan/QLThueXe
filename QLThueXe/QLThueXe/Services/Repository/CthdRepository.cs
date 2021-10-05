using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repository
{
    public class CthdRepository
    {
        public string InsertCthd(string bien_so_hd,string cmnd_hd,double gia_thue,int ngaythue)
        {
            string query = string.Format("select * from insert_ct_hop_dong('{0}','{1}',{2},{3})", bien_so_hd, cmnd_hd, gia_thue, ngaythue);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string SearchCthd(int id)
        {
            string query = string.Format("select * from search_cy_hop_dong({0})", id);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }

    }
}
