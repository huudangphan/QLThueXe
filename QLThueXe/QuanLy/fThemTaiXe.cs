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
    public partial class fThemTaiXe : UserControl
    {
        public fThemTaiXe()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtcmnd.Text;
                string ten = txthoten.Text;
                string ns = dateTimePicker1.Value.ToString();
                string baseURL = "https://localhost:44302/api/HopDong/InsertTaiXe?cmnd=" + cmnd+"&ten="+ten+"&ngaysinh="+ns;
                Http.POST(baseURL);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
