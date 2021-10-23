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
    public partial class fThueXe : DevExpress.XtraEditors.XtraUserControl
    {
        public fThueXe()
        {
            InitializeComponent();
            treeList1.DataSource = fDanhSachXe.lstXe;
            txt_cmnd.Text = Global.cmnd;
            txt_dia_chi.Text = Global.dia_chi;
            txt_sdt.Text = Global.sdt;
            txt_ten.Text = Global.tenkh;
            

           
        }

        private void flyoutPanel1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (fDanhSachXe.lstXe.Count<1 )
                MessageBox.Show("Vui lòng chọn xe để thuê");
            if (string.IsNullOrEmpty(Global.cmnd))
                MessageBox.Show("Vui lòng chọn khách hàng");
            else
            {
                try
                {
                    DateTime ngay_thue = DateTime.Now;
                    DateTime ngay_tra = new DateTime();
                    bool status = false;
                    int so_ngay = Int32.Parse(numericUpDown1.Value.ToString());
                    //https://localhost:44302/api/HopDong/InsertHopDong?tinh_trang=false&so_ngay=3&cmnd=225
                    string url = "https://localhost:44302/api/HopDong/InsertHopDong?tinh_trang=false&so_ngay="+so_ngay+"&cmnd="+Global.cmnd;
                    var result= Http.POST(url);
                    var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                    int result_update = temp[0]["insert_hop_dong"];
                    foreach (var item in fDanhSachXe.lstXe)
                    {
                        
                    }
                    if (result_update != 200)
                        MessageBox.Show("Thuê xe thất bại");
                    else
                        MessageBox.Show("Thuê xe thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                
                
            }
        }
    }
}
