using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;

namespace QLThueXe.Services.Repository
{
    public class XeRepository
    {
        
        public string InsertData(string bien_so,int id_hang,string ten_xe,double gia_thue,string ma_ks,bool status)
        {
            string query = string.Format("select *  from insert_xe('{0}',{1},'{2}',{3},'{4}',{5})", bien_so, id_hang, ten_xe, gia_thue, ma_ks,status);
            try
            {
                return DataBaseServices.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                
                return null;

            }

            
        }
        public string SearchXe(string bien_so, int id_hang, string ten_xe, double gia_thue, string ma_ks,bool status)
        {

            if (id_hang==0  )
                id_hang = -1;
            if (gia_thue==0)
                gia_thue = -1;

            string query = string.Format("select * from search_xe('{0}',{1},'{2}',{3},'{4}',{5})", bien_so, id_hang, ten_xe, gia_thue, ma_ks,status);
            try
            {
                return DataBaseServices.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                
                return null;
            }
            
        }
        public string UpdateXe(string bien_so,double gia_thue,bool status)
        {
            string query = string.Format("select * from update_xe('{0}',{1},{2})", bien_so, gia_thue,status);
            try
            {
                return DataBaseServices.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
