using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repositor
{
    public  class BaoHanhRepository 
    {
        public BaoHanhRepository() { }
        public string GetBaoHanh()
        {
            string query = "select * from search_bao_hanh()";
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string GetCTBaoHanh(string id_phieu)
        {
            string query = string.Format("select * from search_ct_bao_hanh('{0}')", id_phieu);
            return DataBaseServices.Instance.ExecuteQuery(query);

        }
        public string InsertBaoHanh(string date)
        {
            string query = string.Format("select * from insert_bao_hanh('{0}')", date);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public string InsertCTBaoHanh(string bien_so,double chi_phi,string ghi_chu)
        {
            string query = string.Format("select * from insert_ct_phieu_bao_hanh('{0}',{1},'{2}')", bien_so, chi_phi, ghi_chu);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
    }
}
