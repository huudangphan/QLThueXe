using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;

namespace QLThueXe.Services.Repository
{
    public class HangXeRepository
    {
        public string GetData()
        {
            string query = string.Format("select * from hang_xe ");
            return DataBaseServices.Instance.ExecuteQuery(query);
        }
        public void InsertData(string ten_hang)
        {
            string query = string.Format("insert into hang_xe(ten_hang) values ('{0}')", ten_hang);
            DataBaseServices.Instance.ExecuteNonQuery(query);
        }
    }
}
