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
    public partial class fTaiXe : Form
    {
        public static string cmnd = "tu_lai";
        public fTaiXe()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                string baseURL = "https://localhost:44302/api/HopDong/GetTaiXe";
                TaiXe tx = new TaiXe();
                var a = Global.LoadData<TaiXe>(tx, baseURL);
                treeList1.DataSource = a;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeList1.FocusedNode[3].ToString() != "True")
                {
                    cmnd = treeList1.FocusedNode[0].ToString();
                    fDanhSachXe.lstXe.Add(new ModelXe { bien_so = Global.bien_so, gia_thue = Global.gia_thue, km_hien_tai = 0, so_ngay_thue = 3, tai_xe = cmnd });
                    MessageBox.Show("Chọn tài xế thành công", "Thông báo", MessageBoxButtons.OK);
                }
                    
                else
                    MessageBox.Show("Tài xế đang bận", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
    public class TaiXe
    {
        public string cmnd { get; set; }
        public string ten_tx { get; set; }
        public DateTime ngay_sinh { get; set; }
        public bool status { get; set; }
    }
}
