using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class fDangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44302/api/Khach/DangNhap?username="+textEdit1.Text.Trim()+"&password="+textEdit2.Text.Trim();
            var result = Http.PUT(url);
            var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
            //int result_update = temp[0]["update_xe"];
        }
    }
}
