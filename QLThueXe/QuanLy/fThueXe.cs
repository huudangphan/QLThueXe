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
    public partial class fThueXe : DevExpress.XtraEditors.XtraUserControl
    {
        public fThueXe()
        {
            InitializeComponent();
            //treeList1.DataSource = fDanhSachXe.lstXe;
            txt_cmnd.Text = Global.cmnd;
            txt_dia_chi.Text = Global.dia_chi;
            txt_sdt.Text = Global.sdt;
            txt_ten.Text = Global.tenkh;
            LoadData();

           
        }
        public void LoadData()
        {
            dataGridView1.DataSource = fDanhSachXe.lstXe;
            dataGridView1.Columns[0].HeaderText = "Biển số";
            dataGridView1.Columns[0].HeaderText = "Giá thuê";
            dataGridView1.Columns[0].HeaderText = "Số ngày thuê";
            dataGridView1.Columns[0].HeaderText = "Hiện tại";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void flyoutPanel1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (fDanhSachXe.lstXe.Count<1 )
                MessageBox.Show("Vui lòng chọn xe để thuê");
            if (string.IsNullOrEmpty(Global.cmnd))
                MessageBox.Show("Vui lòng chọn khách hàng");
            else
            {
                try
                {
                    DateTime ngay_thue = DateTime.Now;
                    DateTime ngay_tra = new DateTime();
                    bool status = false;
                    int so_ngay = Int32.Parse(numericUpDown1.Value.ToString());
                   
                    string url = "https://localhost:44302/api/HopDong/InsertHopDong?tinh_trang=false&so_ngay="+so_ngay+"&cmnd="+Global.cmnd;
                    var result= Http.POST(url);
                    var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                    int result_update = temp[0]["insert_hop_dong"];
                    foreach (var item in fDanhSachXe.lstXe)
                    {
                        string temp_url = "https://localhost:44302/api/HopDong/InsertCTHD?bien_so="+item.bien_so+"&gia_thue="+item.gia_thue+"&so_ngay="+so_ngay;
                        Http.POST(temp_url);
                    }
                    if (result_update != 200)
                        MessageBox.Show("Thuê xe thất bại");
                    else
                        MessageBox.Show("Thuê xe thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            try
            {
                txt_bks.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_tong_tien.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                numericUpDown1.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtkm.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            

        }
    }
}
