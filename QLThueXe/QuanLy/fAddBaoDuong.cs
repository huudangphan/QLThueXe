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
    public partial class fAddBaoDuong : DevExpress.XtraEditors.XtraUserControl
    {
        public fAddBaoDuong()
        {
            InitializeComponent();
            txtbienso.Text = Global.bien_so;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string bien_so = txtbienso.Text;
                string chi_phi = txtchiphi.Text;
                string ghi_chu = txtghichu.Text;
                string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                string urlbh = "https://localhost:44302/api/BaoHanh/InsertBaoHanh?date="+date;
                var result = Http.POST(urlbh);
                var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                int result_update = temp[0]["insert_bao_hanh"];
                if (result_update != 200)
                    MessageBox.Show("Xảy ra lỗi, vui lòng thử lại sau","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                {
                    string urlct= "https://localhost:44302/api/BaoHanh/InsertCTBaoHanh?bien_so="+bien_so+"&chi_phi="+chi_phi+"&ghi_chu="+ghi_chu;
                    var result2 = Http.POST(urlct);
                    var temp2 = JsonConvert.DeserializeObject<List<dynamic>>(result2);                    
                    MessageBox.Show("Thêm phiếu thành công", "Thông báo", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
