using DevExpress.XtraBars;
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
    public partial class fChiTietHD : DevExpress.XtraEditors.XtraForm
    {
        public fChiTietHD()
        {
            InitializeComponent();
            LoadData();           

        }
        public void LoadData()
        {
            try
            {
                KhachHang kh = new KhachHang();
                string url_kh = "https://localhost:44302/api/Khach/GetKhachById?id_hop_dong=" + Global.id_hop_dong;
                var a = Global.LoadData<KhachHang>(kh, url_kh);
                CTHD ct = new CTHD();
                string url_hd = "https://localhost:44302/api/HopDong/SearchCTHD?id=" + Global.id_hop_dong;
                var b = Global.LoadData<CTHD>(ct, url_hd);
                treeList2.DataSource = b;
                treeList1.DataSource = a;
            }
            catch (Exception)
            {

                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại sau!");
            }

        }
        public bool Check()
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Vui lòng nhập số công tơ khi trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string tra= treeList2.FocusedNode[7].ToString().Trim();
            if(tra=="True")
            {
                MessageBox.Show("Xe đã được trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
           
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // trả xe UpdateHopDong
            try
            {
                string bien_so = treeList2.FocusedNode[3].ToString().Trim();
                Global.bien_so = bien_so;
                if (MessageBox.Show("Bạn có muốn thanh toán xe " + bien_so, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (Check())
                    {
                        string url_hd = "https://localhost:44302/api/HopDong/UpdateHopDong?id_hop_dong=" + Global.id_hop_dong.Trim() + "&km_tra=" + textBox1.Text + "&bien_so=" + bien_so;
                        var result = Http.POST(url_hd);
                        var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                        int result_inser = temp[0]["update_hop_dong"];
                        if (result_inser != 200)
                            MessageBox.Show("Thất bại");
                        else
                        {
                            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadData();
                        }
                    }                                    
                                          
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại sau!");
            }            
        }       
    }
    public class CTHD
    {
       
        public string id_hop_dong { get; set; }
        public DateTime ngay_thue { get; set; }
        public DateTime ngay_tra { get; set; }
        public bool status { get; set; }
        public string bien_so_hd { get; set; }
        public double gia_thue { get; set; }
        public int so_ngay_thue { get; set; }
        public double tong_tien { get; set; }
        public int km_hien_tai { get; set; }
    }
    public class PhieuPhat
    {
        public int id_phieu_phat { get; set; }
        public int id_hop_dong { get; set; }
        public int so_ngay_tre { get; set; }
        public double tong_tien_phat { get; set; }
    }
}