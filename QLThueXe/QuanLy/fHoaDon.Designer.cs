
namespace QuanLy
{
    partial class fHoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeList1.FixedLineWidth = 1;
            this.treeList1.HorzScrollStep = 2;
            this.treeList1.Location = new System.Drawing.Point(7, 45);
            this.treeList1.Margin = new System.Windows.Forms.Padding(2);
            this.treeList1.MinWidth = 16;
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(561, 267);
            this.treeList1.TabIndex = 24;
            this.treeList1.TreeLevelWidth = 13;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Id";
            this.treeListColumn1.FieldName = "id_hop_dong";
            this.treeListColumn1.MinWidth = 16;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 56;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Biển số xe";
            this.treeListColumn2.FieldName = "bien_so_hd";
            this.treeListColumn2.MinWidth = 16;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 56;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Id phiếu phạt";
            this.treeListColumn3.FieldName = "id_phieu_phat";
            this.treeListColumn3.MinWidth = 16;
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 56;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Tổng tiên";
            this.treeListColumn4.FieldName = "tong_tien";
            this.treeListColumn4.MinWidth = 16;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 56;
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.treeListColumn10});
            this.treeList2.FixedLineWidth = 1;
            this.treeList2.HorzScrollStep = 2;
            this.treeList2.Location = new System.Drawing.Point(2, 329);
            this.treeList2.Margin = new System.Windows.Forms.Padding(2);
            this.treeList2.MinWidth = 16;
            this.treeList2.Name = "treeList2";
            this.treeList2.Size = new System.Drawing.Size(717, 267);
            this.treeList2.TabIndex = 25;
            this.treeList2.TreeLevelWidth = 13;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "ID phiếu phạt";
            this.treeListColumn5.FieldName = "id_phieu_phat";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 0;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "ID hợp đồng";
            this.treeListColumn6.FieldName = "id_hop_dong";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 1;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Số ngày trễ";
            this.treeListColumn7.FieldName = "so_ngay_tre";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 2;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Tổng tiền phạt";
            this.treeListColumn8.FieldName = "tong_tien_phat";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 3;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "Số Km đã đi";
            this.treeListColumn9.FieldName = "km_tre";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 4;
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.Caption = "Biển số xe";
            this.treeListColumn10.FieldName = "bien_so_hd";
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(627, 45);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 37);
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Text = "Xem phiếu phạt";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treeList2);
            this.Controls.Add(this.treeList1);
            this.Name = "fHoaDon";
            this.Size = new System.Drawing.Size(822, 610);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
