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
    }
}
