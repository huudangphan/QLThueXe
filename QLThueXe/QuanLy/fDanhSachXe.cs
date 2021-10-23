using DevExpress.XtraEditors;
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
    public partial class fDanhSachXe : DevExpress.XtraEditors.XtraUserControl
    {
        public static List<ModelXe> lstXe = new List<ModelXe>();
        public fDanhSachXe()
        {
            InitializeComponent();
            LoadData();
           
        }
        public void LoadData()
        {
            string baseURL = "https://localhost:44302/api/Xe/SearchDataXe";
            Xe x = new Xe();

            var a = Global.LoadData<Xe>(x, baseURL);
            foreach (var item in a)
            {

                item.gia_thue = (Decimal.Parse(item.gia_thue)).ToString("n");
            }
            treeList1.DataSource = a;

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeList1.FocusedNode[4].ToString() == "True")
                    MessageBox.Show("Xe đã được thuê");
                else
                {
                  
                    string bien_so = treeList1.FocusedNode[0].ToString();
                    double gia_thue = double.Parse(treeList1.FocusedNode[2].ToString());
                    lstXe.Add(new ModelXe() { bien_so = bien_so, gia_thue = gia_thue });
                    MessageBox.Show("Chọn xe thành công");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại sau");
            }
           
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string bien_so = treeList1.FocusedNode[0].ToString();
                double gia_thue = double.Parse(treeList1.FocusedNode[2].ToString());
                bool status = bool.Parse(treeList1.FocusedNode[4].ToString());
                string url = "https://localhost:44302/api/Xe/UpdateXe?bien_so=" + bien_so + "&gia_thue=" + gia_thue + "&status=" + status;
                var result = Http.PUT(url);
                var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                int result_update = temp[0]["update_xe"];
                if (result_update != 200)
                    MessageBox.Show("Sửa thông tin xe thất bại");
                else
                    MessageBox.Show("Sửa thông tin xe thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại");
            }
          
        }
    }
}
