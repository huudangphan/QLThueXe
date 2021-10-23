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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Global.cmnd = treeList1.FocusedNode[0].ToString();
                Global.tenkh= treeList1.FocusedNode[1].ToString();
                Global.dia_chi= treeList1.FocusedNode[2].ToString();
                Global.sdt= treeList1.FocusedNode[3].ToString();
                MessageBox.Show("Chọn khách hàng thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại sau");
            }
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
