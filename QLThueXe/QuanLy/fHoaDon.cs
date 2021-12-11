using DevExpress.XtraTreeList;
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
    public partial class fHoaDon : UserControl
    {
        public fHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
            
        }
        public void LoadHoaDon()
        {
            
            try
            {
                string baseURL = "https://localhost:44302/api/HopDong/SearchHoaDon?id_hop_dong=" + Global.id_hop_dong + "&bien_so=" + Global.bien_so;
                HoaDon hd = new HoaDon();
                treeList1.DataSource = Global.LoadData<HoaDon>(hd, baseURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
           

        }
        public void LoadPhieuPhat(int id_phieu_phat)
        {
            string baseURL = "https://localhost:44302/api/HopDong/SearchPhieuPhat?id="+id_phieu_phat;
            PhieuPhat pp = new PhieuPhat();
            treeList2.DataSource = Global.LoadData<PhieuPhat>(pp, baseURL);
        }
        public class HoaDon
        {
            public string id_hop_dong { get; set; }
            public string bien_so_hd { get; set; }
            public int id_phieu_phat { get; set; }
            public double tong_tien { get; set; }
        }
        public class PhieuPhat
        {
            public int id_phieu_phat { get; set; }
            public string id_hop_dong { get; set; }
            public int so_ngay_tre { get; set; }
            public double tong_tien_phat { get; set; }
            public int km_tre { get; set; }
            public string bien_so_hd { get; set; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id_phieu_phat = Int32.Parse(treeList1.FocusedNode[2].ToString());
                LoadPhieuPhat(id_phieu_phat);
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();
            }
            

        }
    }
}
