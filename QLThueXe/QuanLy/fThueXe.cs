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
            if(fDanhSachXe.lstXe!=null)
            {
                dataGridView1.DataSource = fDanhSachXe.lstXe;
                dataGridView1.Columns[0].HeaderText = "Biển số";
                dataGridView1.Columns[0].HeaderText = "Giá thuê";
                dataGridView1.Columns[0].HeaderText = "Số ngày thuê";
                dataGridView1.Columns[0].HeaderText = "Hiện tại";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
           
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
                    string ngay_thue = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

                    if (!string.IsNullOrEmpty(txttiencoc.Text))
                    {                       
                        int so_ngay = Int32.Parse(numericUpDown1.Value.ToString());                       
                        string url = "https://localhost:44302/api/HopDong/InsertHopDong?ngay_thue=" + ngay_thue + "&cmnd=" + txt_cmnd.Text + "&tien_coc=" + txttiencoc.Text;
                        var result = Http.POST(url);
                        var temp = JsonConvert.DeserializeObject<List<dynamic>>(result);
                        int result_update = temp[0]["insert_hop_dong"];
                        int row = dataGridView1.Rows.Count;
                        string bks, tong_tien, ngay, km;

                        for (int i = 0; i < row; i++)
                        {
                            bks = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            tong_tien = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            ngay = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            km = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            string temp_url = "https://localhost:44302/api/HopDong/InsertCTHD?bien_so=" + bks + "&gia_thue=" + tong_tien + "&so_ngay=" + ngay + "&km_hien_tai=" + km;
                            Http.POST(temp_url);
                        }
                        if (result_update != 200)
                            MessageBox.Show("Thuê xe thất bại");
                        else
                        {
                            Global.cmnd = Global.dia_chi = Global.sdt = Global.tenkh = "";
                            fDanhSachXe.lstXe = null;
                            MessageBox.Show("Thuê xe thành công");
                        }
                           
                    }
                    else
                        MessageBox.Show("Tiền cọc không được để trống");
                   
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
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
