using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class fMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        
        public fMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            
            fDanhSachXe f = new fDanhSachXe();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            fKhachHang f = new fKhachHang();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
            
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            fThemXeMoi f = new fThemXeMoi();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            fLichSu f = new fLichSu();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            fThueXe f = new fThueXe();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            fThemKhachHang f = new fThemKhachHang();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            //Global.id_hop_dong = "23156621456hd25";
            //Global.bien_so = "79A-12624";
            //fMain.Controls.Clear();
            //fHoaDon f = new fHoaDon();
            //f.Dock = DockStyle.Fill;
            //fMain.Controls.Add(f);
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            Global.id_hop_dong = "23156621456hd25";
            Global.bien_so = "79A-12624";

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Global.id_hop_dong) || string.IsNullOrEmpty(Global.bien_so))
                MessageBox.Show("Vui lòng thanh toán hợp đồng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                fMain.Controls.Clear();
                fHoaDon f = new fHoaDon();
                f.Dock = DockStyle.Fill;
                fMain.Controls.Add(f);
            }
            

        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            BaoDuong f = new BaoDuong();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            fMain.Controls.Clear();
            fAddBaoDuong f = new fAddBaoDuong();
            f.Dock = DockStyle.Fill;
            fMain.Controls.Add(f);
        }
    }
}
