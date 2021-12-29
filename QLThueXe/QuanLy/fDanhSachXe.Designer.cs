
namespace QuanLy
{
    partial class fDanhSachXe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachXe));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.fDanhSachXelayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.txtmdk = new DevExpress.XtraEditors.TextEdit();
            this.txtgia = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txthang = new DevExpress.XtraEditors.TextEdit();
            this.txtbks = new DevExpress.XtraEditors.TextEdit();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit6item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit3item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit4item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkBox1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton3item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.treeList1item = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDanhSachXelayoutControl1ConvertedLayout)).BeginInit();
            this.fDanhSachXelayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmdk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton3item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1item)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6});
            this.treeList1.Location = new System.Drawing.Point(11, 74);
            this.treeList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeList1.MinWidth = 17;
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(733, 334);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeLevelWidth = 15;
            this.treeList1.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.treeList1_RowClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Biển kiểm soát";
            this.treeListColumn1.FieldName = "bien_so";
            this.treeListColumn1.MinWidth = 17;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 64;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Tên xe";
            this.treeListColumn3.FieldName = "ten_xe";
            this.treeListColumn3.MinWidth = 17;
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            this.treeListColumn3.Width = 64;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Giá thuê";
            this.treeListColumn4.FieldName = "gia_thue";
            this.treeListColumn4.MinWidth = 17;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 2;
            this.treeListColumn4.Width = 64;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Mã đăng kiểm";
            this.treeListColumn5.FieldName = "ma_kiem-soat";
            this.treeListColumn5.MinWidth = 17;
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 3;
            this.treeListColumn5.Width = 64;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Đã thuê";
            this.treeListColumn6.FieldName = "status";
            this.treeListColumn6.MinWidth = 17;
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.OptionsColumn.AllowEdit = false;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 4;
            this.treeListColumn6.Width = 64;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(89, 412);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(655, 36);
            this.simpleButton1.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fDanhSachXelayoutControl1ConvertedLayout
            // 
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.txtmdk);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.txtgia);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.txtten);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.txthang);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.txtbks);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.checkBox1);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.simpleButton3);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.simpleButton2);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.fDanhSachXelayoutControl1ConvertedLayout.Controls.Add(this.treeList1);
            this.fDanhSachXelayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fDanhSachXelayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.fDanhSachXelayoutControl1ConvertedLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fDanhSachXelayoutControl1ConvertedLayout.Name = "fDanhSachXelayoutControl1ConvertedLayout";
            this.fDanhSachXelayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.fDanhSachXelayoutControl1ConvertedLayout.Size = new System.Drawing.Size(755, 458);
            this.fDanhSachXelayoutControl1ConvertedLayout.TabIndex = 17;
            // 
            // txtmdk
            // 
            this.txtmdk.Location = new System.Drawing.Point(602, 10);
            this.txtmdk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmdk.Name = "txtmdk";
            this.txtmdk.Size = new System.Drawing.Size(142, 20);
            this.txtmdk.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.txtmdk.TabIndex = 8;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(313, 34);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(122, 20);
            this.txtgia.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.txtgia.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(313, 10);
            this.txtten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(122, 20);
            this.txtten.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.txtten.TabIndex = 6;
            // 
            // txthang
            // 
            this.txthang.Location = new System.Drawing.Point(82, 34);
            this.txthang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthang.Name = "txthang";
            this.txthang.Size = new System.Drawing.Size(156, 20);
            this.txthang.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.txthang.TabIndex = 5;
            // 
            // txtbks
            // 
            this.txtbks.Location = new System.Drawing.Point(82, 10);
            this.txtbks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbks.Name = "txtbks";
            this.txtbks.Size = new System.Drawing.Size(156, 20);
            this.txtbks.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.txtbks.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(439, 10);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Đã thuê";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(531, 34);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(213, 36);
            this.simpleButton3.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Tìm kiếm";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(11, 412);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(74, 36);
            this.simpleButton2.StyleController = this.fDanhSachXelayoutControl1ConvertedLayout;
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Chọn";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.textEdit6item,
            this.textEdit3item,
            this.textEdit4item,
            this.textEdit2item,
            this.textEdit1item,
            this.checkBox1item,
            this.simpleButton3item,
            this.simpleButton2item,
            this.simpleButton1item,
            this.treeList1item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(755, 458);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // textEdit6item
            // 
            this.textEdit6item.Control = this.txtmdk;
            this.textEdit6item.Location = new System.Drawing.Point(520, 0);
            this.textEdit6item.Name = "textEdit6item";
            this.textEdit6item.Size = new System.Drawing.Size(217, 24);
            this.textEdit6item.Text = "Mã đăng kiểm";
            this.textEdit6item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit6item.TextSize = new System.Drawing.Size(68, 13);
            // 
            // textEdit3item
            // 
            this.textEdit3item.Control = this.txtgia;
            this.textEdit3item.Location = new System.Drawing.Point(231, 24);
            this.textEdit3item.Name = "textEdit3item";
            this.textEdit3item.Size = new System.Drawing.Size(197, 40);
            this.textEdit3item.Text = "Giá thuê";
            this.textEdit3item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit3item.TextSize = new System.Drawing.Size(68, 13);
            // 
            // textEdit4item
            // 
            this.textEdit4item.Control = this.txtten;
            this.textEdit4item.Location = new System.Drawing.Point(231, 0);
            this.textEdit4item.Name = "textEdit4item";
            this.textEdit4item.Size = new System.Drawing.Size(197, 24);
            this.textEdit4item.Text = "Tên xe";
            this.textEdit4item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit4item.TextSize = new System.Drawing.Size(68, 13);
            // 
            // textEdit2item
            // 
            this.textEdit2item.Control = this.txthang;
            this.textEdit2item.Location = new System.Drawing.Point(0, 24);
            this.textEdit2item.Name = "textEdit2item";
            this.textEdit2item.Size = new System.Drawing.Size(231, 40);
            this.textEdit2item.Text = "Hãng";
            this.textEdit2item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit2item.TextSize = new System.Drawing.Size(68, 13);
            // 
            // textEdit1item
            // 
            this.textEdit1item.Control = this.txtbks;
            this.textEdit1item.Location = new System.Drawing.Point(0, 0);
            this.textEdit1item.Name = "textEdit1item";
            this.textEdit1item.Size = new System.Drawing.Size(231, 24);
            this.textEdit1item.Text = "Biển kiểm soát";
            this.textEdit1item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textEdit1item.TextSize = new System.Drawing.Size(68, 13);
            // 
            // checkBox1item
            // 
            this.checkBox1item.Control = this.checkBox1;
            this.checkBox1item.Location = new System.Drawing.Point(428, 0);
            this.checkBox1item.Name = "checkBox1item";
            this.checkBox1item.Size = new System.Drawing.Size(92, 64);
            this.checkBox1item.TextSize = new System.Drawing.Size(0, 0);
            this.checkBox1item.TextVisible = false;
            // 
            // simpleButton3item
            // 
            this.simpleButton3item.Control = this.simpleButton3;
            this.simpleButton3item.Location = new System.Drawing.Point(520, 24);
            this.simpleButton3item.Name = "simpleButton3item";
            this.simpleButton3item.Size = new System.Drawing.Size(217, 40);
            this.simpleButton3item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton3item.TextVisible = false;
            // 
            // simpleButton2item
            // 
            this.simpleButton2item.Control = this.simpleButton2;
            this.simpleButton2item.Location = new System.Drawing.Point(0, 402);
            this.simpleButton2item.Name = "simpleButton2item";
            this.simpleButton2item.Size = new System.Drawing.Size(78, 40);
            this.simpleButton2item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton2item.TextVisible = false;
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(78, 402);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(659, 40);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // treeList1item
            // 
            this.treeList1item.Control = this.treeList1;
            this.treeList1item.Location = new System.Drawing.Point(0, 64);
            this.treeList1item.Name = "treeList1item";
            this.treeList1item.Size = new System.Drawing.Size(737, 338);
            this.treeList1item.TextSize = new System.Drawing.Size(0, 0);
            this.treeList1item.TextVisible = false;
            // 
            // fDanhSachXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fDanhSachXelayoutControl1ConvertedLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDanhSachXe";
            this.Size = new System.Drawing.Size(755, 458);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDanhSachXelayoutControl1ConvertedLayout)).EndInit();
            this.fDanhSachXelayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmdk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton3item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit txtbks;
        private DevExpress.XtraEditors.TextEdit txthang;
        private DevExpress.XtraEditors.TextEdit txtgia;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtmdk;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraLayout.LayoutControl fDanhSachXelayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem textEdit6item;
        private DevExpress.XtraLayout.LayoutControlItem textEdit3item;
        private DevExpress.XtraLayout.LayoutControlItem textEdit4item;
        private DevExpress.XtraLayout.LayoutControlItem textEdit2item;
        private DevExpress.XtraLayout.LayoutControlItem textEdit1item;
        private DevExpress.XtraLayout.LayoutControlItem checkBox1item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton3item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton2item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton1item;
        private DevExpress.XtraLayout.LayoutControlItem treeList1item;
    }
}
