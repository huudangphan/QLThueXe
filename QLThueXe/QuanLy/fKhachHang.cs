using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class fKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public fKhachHang()
        {
            InitializeComponent();
            KhachHang kh = new KhachHang();
            string baseURL = "https://localhost:44302/api/Khach/GetKhach";
            treeList1.DataSource = Global.LoadData<KhachHang>(kh,baseURL);

        }
      
    }
    public class KhachHang
    {
        public string cmnd { get; set; }
        public string ten { get; set; }
        public string dia_chi { get; set; }
        public string sdt { get; set; }
        public DateTime ngay_sinh { get; set; }
        public string anh { get; set; }
    }
}
