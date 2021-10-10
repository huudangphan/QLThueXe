﻿using DevExpress.XtraEditors;
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
    }
    class HopDong
    {
        public int id_hop_dong { get; set; }
        public DateTime ngay_thue { get; set; }
        public DateTime ngay_tra { get; set; }
        public bool tinh_trang { get; set; }
        public DateTime ngay_tra_du_tinh { get; set; }
    }
       

}