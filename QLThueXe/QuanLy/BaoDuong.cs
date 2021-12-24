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
    public partial class BaoDuong : DevExpress.XtraEditors.XtraUserControl
    {
        public BaoDuong()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                string baseURL = "https://localhost:44302/api/BaoHanh/GetBaoHanh";
                BaoHanh bh = new BaoHanh();
                var a = Global.LoadData<BaoHanh>(bh, baseURL);
                treeList1.DataSource = a; ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeList1.FocusedNode[1].ToString() != null)
                {
                    string ma_phieu = treeList1.FocusedNode[1].ToString();
                    string baseURL = "https://localhost:44302/api/BaoHanh/GetCTBaoHanh?id_phieu=" + ma_phieu;
                    CTBaoHanh ct = new CTBaoHanh();
                    var b = Global.LoadData<CTBaoHanh>(ct, baseURL);
                    treeList2.DataSource = b;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                   
        }
    }
    public class BaoHanh
    {
        public int stt { get; set; }
        public string id_phieu { get; set; }
        public DateTime ngay { get; set; }
    }
    public class CTBaoHanh
    {
        public string id_phieu { get; set; }
        public string bien_so { get; set; }
        public double chi_phi { get; set; }
        public string ghi_chu { get; set; }
    }

}
