namespace Label_Package
{
    partial class frm기초데이타_제품등록
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_제품등록));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan타이틀 = new System.Windows.Forms.Panel();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.pan관리사 = new System.Windows.Forms.Panel();
            this.cmb관리사 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pan거래처 = new System.Windows.Forms.Panel();
            this.cmb거래처 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.spr0 = new FarPoint.Win.Spread.FpSpread();
            this.spr0_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan버튼 = new System.Windows.Forms.Panel();
            this.lblCnt0 = new System.Windows.Forms.Label();
            this.pic사진 = new System.Windows.Forms.PictureBox();
            this.btn사진 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan등록.SuspendLayout();
            this.pan타이틀.SuspendLayout();
            this.pan관리사.SuspendLayout();
            this.pan거래처.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).BeginInit();
            this.pan버튼.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic사진)).BeginInit();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 55);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(484, 510);
            this.spr.TabIndex = 98;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.label6);
            this.pan등록.Controls.Add(this.txt4);
            this.pan등록.Controls.Add(this.lblCnt);
            this.pan등록.Controls.Add(this.txt조회);
            this.pan등록.Controls.Add(this.label1);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(484, 55);
            this.pan등록.TabIndex = 100;
            this.pan등록.Paint += new System.Windows.Forms.PaintEventHandler(this.pan데이타_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 104;
            this.label6.Text = "소속";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(748, 33);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.MaxLength = 0;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(153, 21);
            this.txt4.TabIndex = 99;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            this.txt4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(3, 33);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            this.lblCnt.Click += new System.EventHandler(this.lblCnt_Click);
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(181, 14);
            this.txt조회.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회.MaxLength = 0;
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(206, 21);
            this.txt조회.TabIndex = 0;
            this.txt조회.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "조회";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pan타이틀
            // 
            this.pan타이틀.BackColor = System.Drawing.Color.White;
            this.pan타이틀.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan타이틀.Controls.Add(this.lbl타이틀);
            this.pan타이틀.Controls.Add(this.btnSearch);
            this.pan타이틀.Controls.Add(this.btnClose);
            this.pan타이틀.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan타이틀.Location = new System.Drawing.Point(0, 0);
            this.pan타이틀.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan타이틀.Name = "pan타이틀";
            this.pan타이틀.Size = new System.Drawing.Size(1056, 50);
            this.pan타이틀.TabIndex = 99;
            // 
            // lbl타이틀
            // 
            this.lbl타이틀.AutoSize = true;
            this.lbl타이틀.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀.Location = new System.Drawing.Point(11, 15);
            this.lbl타이틀.Name = "lbl타이틀";
            this.lbl타이틀.Size = new System.Drawing.Size(59, 16);
            this.lbl타이틀.TabIndex = 44;
            this.lbl타이틀.Text = "타이틀";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(366, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "    조 회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(263, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "    닫 기";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(33, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(33, 52);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "    등 록";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(33, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(9, 7);
            this.btninit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(84, 32);
            this.btninit.TabIndex = 40;
            this.btninit.Text = "   초기화";
            this.btninit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // pan관리사
            // 
            this.pan관리사.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan관리사.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan관리사.Controls.Add(this.cmb관리사);
            this.pan관리사.Controls.Add(this.label8);
            this.pan관리사.Controls.Add(this.label10);
            this.pan관리사.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan관리사.Location = new System.Drawing.Point(0, 0);
            this.pan관리사.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan관리사.Name = "pan관리사";
            this.pan관리사.Size = new System.Drawing.Size(568, 42);
            this.pan관리사.TabIndex = 102;
            // 
            // cmb관리사
            // 
            this.cmb관리사.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb관리사.FormattingEnabled = true;
            this.cmb관리사.Location = new System.Drawing.Point(73, 11);
            this.cmb관리사.Name = "cmb관리사";
            this.cmb관리사.Size = new System.Drawing.Size(230, 20);
            this.cmb관리사.TabIndex = 110;
            this.cmb관리사.SelectedIndexChanged += new System.EventHandler(this.cmb관리사_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 98;
            this.label8.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 70;
            this.label10.Text = "관리사";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pan거래처
            // 
            this.pan거래처.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan거래처.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan거래처.Controls.Add(this.cmb거래처);
            this.pan거래처.Controls.Add(this.label11);
            this.pan거래처.Controls.Add(this.label12);
            this.pan거래처.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan거래처.Location = new System.Drawing.Point(0, 42);
            this.pan거래처.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan거래처.Name = "pan거래처";
            this.pan거래처.Size = new System.Drawing.Size(568, 42);
            this.pan거래처.TabIndex = 103;
            // 
            // cmb거래처
            // 
            this.cmb거래처.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb거래처.FormattingEnabled = true;
            this.cmb거래처.Location = new System.Drawing.Point(73, 14);
            this.cmb거래처.Name = "cmb거래처";
            this.cmb거래처.Size = new System.Drawing.Size(230, 20);
            this.cmb거래처.TabIndex = 110;
            this.cmb거래처.SelectedIndexChanged += new System.EventHandler(this.cmb거래처_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 98;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 70;
            this.label12.Text = "거래처";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc.Location = new System.Drawing.Point(0, 50);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.spr0);
            this.sc.Panel1.Controls.Add(this.pan버튼);
            this.sc.Panel1.Controls.Add(this.pan거래처);
            this.sc.Panel1.Controls.Add(this.pan관리사);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.spr);
            this.sc.Panel2.Controls.Add(this.pan등록);
            this.sc.Size = new System.Drawing.Size(1056, 565);
            this.sc.SplitterDistance = 568;
            this.sc.TabIndex = 104;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // spr0
            // 
            this.spr0.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr0.Location = new System.Drawing.Point(0, 258);
            this.spr0.Name = "spr0";
            this.spr0.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr0_Sheet1});
            this.spr0.Size = new System.Drawing.Size(568, 307);
            this.spr0.TabIndex = 105;
            this.spr0.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr0_ColumnWidthChanged);
            // 
            // spr0_Sheet1
            // 
            this.spr0_Sheet1.Reset();
            spr0_Sheet1.SheetName = "Sheet0";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr0_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr0_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr0_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr0_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr0_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan버튼
            // 
            this.pan버튼.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan버튼.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan버튼.Controls.Add(this.btn사진);
            this.pan버튼.Controls.Add(this.pic사진);
            this.pan버튼.Controls.Add(this.lblCnt0);
            this.pan버튼.Controls.Add(this.btnDelete);
            this.pan버튼.Controls.Add(this.btninit);
            this.pan버튼.Controls.Add(this.btnAdd);
            this.pan버튼.Controls.Add(this.btnEdit);
            this.pan버튼.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan버튼.Location = new System.Drawing.Point(0, 84);
            this.pan버튼.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan버튼.Name = "pan버튼";
            this.pan버튼.Size = new System.Drawing.Size(568, 174);
            this.pan버튼.TabIndex = 104;
            // 
            // lblCnt0
            // 
            this.lblCnt0.AutoSize = true;
            this.lblCnt0.Location = new System.Drawing.Point(7, 158);
            this.lblCnt0.Name = "lblCnt0";
            this.lblCnt0.Size = new System.Drawing.Size(11, 12);
            this.lblCnt0.TabIndex = 99;
            this.lblCnt0.Text = "0";
            // 
            // pic사진
            // 
            this.pic사진.Location = new System.Drawing.Point(129, 3);
            this.pic사진.Name = "pic사진";
            this.pic사진.Size = new System.Drawing.Size(425, 164);
            this.pic사진.TabIndex = 100;
            this.pic사진.TabStop = false;
            // 
            // btn사진
            // 
            this.btn사진.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn사진.Location = new System.Drawing.Point(99, 7);
            this.btn사진.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn사진.Name = "btn사진";
            this.btn사진.Size = new System.Drawing.Size(24, 32);
            this.btn사진.TabIndex = 101;
            this.btn사진.Text = "...";
            this.btn사진.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn사진.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn사진.UseVisualStyleBackColor = true;
            this.btn사진.Click += new System.EventHandler(this.btn사진_Click);
            // 
            // frm기초데이타_제품등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pan타이틀);
            this.Name = "frm기초데이타_제품등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "제품 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm기초데이타_제품등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.pan타이틀.ResumeLayout(false);
            this.pan타이틀.PerformLayout();
            this.pan관리사.ResumeLayout(false);
            this.pan관리사.PerformLayout();
            this.pan거래처.ResumeLayout(false);
            this.pan거래처.PerformLayout();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).EndInit();
            this.pan버튼.ResumeLayout(false);
            this.pan버튼.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic사진)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan타이틀;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.Panel pan관리사;
        private System.Windows.Forms.ComboBox cmb관리사;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pan거래처;
        private System.Windows.Forms.ComboBox cmb거래처;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Panel pan버튼;
        private FarPoint.Win.Spread.FpSpread spr0;
        private FarPoint.Win.Spread.SheetView spr0_Sheet1;
        private System.Windows.Forms.Label lblCnt0;
        private System.Windows.Forms.Button btn사진;
        private System.Windows.Forms.PictureBox pic사진;
    }
}