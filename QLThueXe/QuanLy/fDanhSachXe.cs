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
    public partial class fDanhSachXe : DevExpress.XtraEditors.XtraUserControl
    {
        public fDanhSachXe()
        {
            InitializeComponent();
            string baseURL = "https://localhost:44302/api/Xe/SearchDataXe";
            Xe x = new Xe();
            
            var a = Global.LoadData<Xe>(x, baseURL);
            foreach (var item in a)
            {
               
                item.gia_thue = (Decimal.Parse(item.gia_thue)).ToString("n") + " VNĐ";
            }
            treeList1.DataSource=a;
           
        }
        class Xe
        {
            public string bien_so { get; set; }
            public string ten_xe { get; set; }
            public string gia_thue { get; set; }
            public string ma_kiem_soat { get; set; }
            public bool status { get; set; }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string a = treeList1.FocusedNode[2].ToString();
            double b = Global.FormatCurrency(a);

            MessageBox.Show(treeList1.FocusedNode[2].ToString());
            MessageBox.Show(b.ToString());
        }
    }
}
