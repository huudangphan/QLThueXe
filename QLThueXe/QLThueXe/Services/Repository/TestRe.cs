using QLThueXe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Connection;
namespace QLThueXe.Services.Repositor
{
    public  class TestRe : ITest
    {
        DataBaseServices db = new DataBaseServices();
        public TestRe() { }
        public DataTable GetData()
        {
            return db.ExcuteQuery("select * from Test");
        }
    }
}
