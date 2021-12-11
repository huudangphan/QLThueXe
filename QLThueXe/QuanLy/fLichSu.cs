using DevExpress.XtraEditors;
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
    public partial class fLichSu : DevExpress.XtraEditors.XtraUserControl
    {
        public fLichSu()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            string url = "https://localhost:44302/api/HopDong/SearchHopDong";
            try
            {
                HopDong hd = new HopDong();
                var data = Global.LoadData<HopDong>(hd, url);
                treeList1.DataSource = data;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Global.id_hop_dong = (treeList1.FocusedNode[0].ToString());
            fChiTietHD f = new fChiTietHD();
            f.Show();
            
        }
    }
    class HopDong
    {
      
        public DateTime ngay_thue { get; set; }      
        
        public string cmnd { get; set; }
        public double tien_coc { get; set; }
        public string id_hop_dong { get; set; }
        public bool tra_coc { get; set; }

    }
       

}
