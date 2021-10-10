using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repositor
{
    public  class PhieuPhatRepository
    {      
       
        public string GetData(int id)
        {
            
            string query = string.Format("select * from Test where id={0}", id);
            var a = DataBaseServices.Instance.ExecuteScalar(query);
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public HttpResult TestF()
        {
            int id = 1;
            string query = string.Format("select * from Test({0})", id);
            return new HttpResult(DataBaseServices.Instance.ExecuteScalar(query));
        }
    }
}
