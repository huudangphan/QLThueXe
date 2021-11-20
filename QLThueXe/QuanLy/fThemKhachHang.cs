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
    public partial class fThemKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public fThemKhachHang()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ten = txtTen.Text;
                string cmnd = txtcmnd.Text;
                string sdt = txtSdt.Text;
                string dia_chi = txtDiaChi.Text;
                string ns = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                //https://localhost:44302/api/Khach/InsertKhach?cmnd=a&ten=a&dia_chi=a&sdt=a&ngay_sinh=2020-1-1&anh=1
                string url = "https://localhost:44302/api/Khach/InsertKhach?cmnd=" + cmnd+"&ten="+ten+"&dia_chi="+dia_chi+"&sdt="+
                    sdt+"&ngay_sinh="+ns+"&anh=1";
                var result = Http.POST(url);
                var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                int result_inser = temp[0]["insert_khach"];
                if (result_inser != 200)
                    MessageBox.Show("Thêm dữ liệu thất bại");
                else
                    MessageBox.Show("Thêm dữ liệu thành công");

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại sau");
            }
            
        }
    }
}
