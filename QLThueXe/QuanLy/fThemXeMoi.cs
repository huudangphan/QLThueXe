using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class fThemXeMoi : DevExpress.XtraEditors.XtraUserControl
    {
        public fThemXeMoi()
        {
            InitializeComponent();
            LoadCombobox();
        }
        public void LoadCombobox()
        {
            cbHang.Items.Add("Toyota");
            cbHang.Items.Add("Honda");
            cbHang.Items.Add("Ford");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string hang = "";
                if (cbHang.Text == "Toyota")
                    hang = "1";
                else if (cbHang.Text == "Honda")
                    hang = "2";
                else
                    hang = "3";
                string bks = txtBienKiemSoat.Text;
                string tenXe = txtTenXe.Text;
                string madk = txtMaDangKiem.Text;
                double giaThue = double.Parse(txtGiaTHue.Text);
              
                var result = Http.POST("https://localhost:44302/api/Xe/InsertDataXe?bien_so="+bks+"&id_hang="+hang+"&ten_xe="+tenXe+"&gia_thue="+giaThue+"&ma_ks="+madk+"&status=false");
                var temp= JsonConvert.DeserializeObject<List<dynamic>>(result);
                int result_inser = temp[0]["insert_xe"];
                
                if (result_inser == 100)
                    MessageBox.Show("Biển kiểm soát bị trùng");
                if (result_inser != 200)
                    MessageBox.Show("Thêm dữ liệu thất bại");
                else
                    MessageBox.Show("Thêm dữ liệu thành công");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
