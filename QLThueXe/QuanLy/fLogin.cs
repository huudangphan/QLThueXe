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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://localhost:44302/api/Khach/DangNhap?username=" + textEdit1.Text.Trim() + "&password=" + textEdit2.Text.Trim();
                var result = Http.POST(url);
                if (result == "200")
                {
                    fMenu f = new fMenu();
                    this.Hide();
                    f.ShowDialog();
                   

                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
            
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
