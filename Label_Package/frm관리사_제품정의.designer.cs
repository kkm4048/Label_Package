namespace Label_Package
{
    partial class frm관리사_제품정의
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm관리사_제품정의));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.txt구분 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.pan타이틀 = new System.Windows.Forms.Panel();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn저장 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pan거래처 = new System.Windows.Forms.Panel();
            this.cmb거래처 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb관리사 = new System.Windows.Forms.ComboBox();
            this.pan관리사 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan등록.SuspendLayout();
            this.pan타이틀.SuspendLayout();
            this.pan거래처.SuspendLayout();
            this.pan관리사.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 200);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1056, 415);
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
            this.pan등록.Controls.Add(this.txt구분);
            this.pan등록.Controls.Add(this.label4);
            this.pan등록.Controls.Add(this.lblCnt);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 134);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1056, 66);
            this.pan등록.TabIndex = 100;
            this.pan등록.Paint += new System.Windows.Forms.PaintEventHandler(this.pan데이타_Paint);
            // 
            // txt구분
            // 
            this.txt구분.Enabled = false;
            this.txt구분.Location = new System.Drawing.Point(81, 6);
            this.txt구분.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt구분.MaxLength = 0;
            this.txt구분.Name = "txt구분";
            this.txt구분.Size = new System.Drawing.Size(153, 21);
            this.txt구분.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 111;
            this.label4.Text = "구분";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(3, 37);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            this.lblCnt.Click += new System.EventHandler(this.lblCnt_Click);
            // 
            // pan타이틀
            // 
            this.pan타이틀.BackColor = System.Drawing.Color.White;
            this.pan타이틀.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan타이틀.Controls.Add(this.lbl타이틀);
            this.pan타이틀.Controls.Add(this.btnDelete);
            this.pan타이틀.Controls.Add(this.btn저장);
            this.pan타이틀.Controls.Add(this.btnEdit);
            this.pan타이틀.Controls.Add(this.btninit);
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
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(748, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(570, 7);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(90, 32);
            this.btn저장.TabIndex = 42;
            this.btn저장.Text = "    저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(659, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(473, 7);
            this.btninit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(90, 32);
            this.btninit.TabIndex = 40;
            this.btninit.Text = "   초기화";
            this.btninit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
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
            // pan거래처
            // 
            this.pan거래처.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan거래처.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan거래처.Controls.Add(this.cmb거래처);
            this.pan거래처.Controls.Add(this.label11);
            this.pan거래처.Controls.Add(this.label12);
            this.pan거래처.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan거래처.Location = new System.Drawing.Point(0, 92);
            this.pan거래처.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan거래처.Name = "pan거래처";
            this.pan거래처.Size = new System.Drawing.Size(1056, 42);
            this.pan거래처.TabIndex = 103;
            // 
            // cmb거래처
            // 
            this.cmb거래처.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb거래처.FormattingEnabled = true;
            this.cmb거래처.Location = new System.Drawing.Point(84, 10);
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
            this.label12.Location = new System.Drawing.Point(25, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 70;
            this.label12.Text = "거래처";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 70;
            this.label10.Text = "관리사";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // cmb관리사
            // 
            this.cmb관리사.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb관리사.FormattingEnabled = true;
            this.cmb관리사.Location = new System.Drawing.Point(84, 10);
            this.cmb관리사.Name = "cmb관리사";
            this.cmb관리사.Size = new System.Drawing.Size(230, 20);
            this.cmb관리사.TabIndex = 110;
            this.cmb관리사.SelectedIndexChanged += new System.EventHandler(this.cmb관리사_SelectedIndexChanged);
            // 
            // pan관리사
            // 
            this.pan관리사.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan관리사.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan관리사.Controls.Add(this.cmb관리사);
            this.pan관리사.Controls.Add(this.label8);
            this.pan관리사.Controls.Add(this.label10);
            this.pan관리사.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan관리사.Location = new System.Drawing.Point(0, 50);
            this.pan관리사.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan관리사.Name = "pan관리사";
            this.pan관리사.Size = new System.Drawing.Size(1056, 42);
            this.pan관리사.TabIndex = 102;
            // 
            // frm관리사_제품정의
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.pan등록);
            this.Controls.Add(this.pan거래처);
            this.Controls.Add(this.pan관리사);
            this.Controls.Add(this.pan타이틀);
            this.Name = "frm관리사_제품정의";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "제품 정의";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm관리사_제품정의_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.pan타이틀.ResumeLayout(false);
            this.pan타이틀.PerformLayout();
            this.pan거래처.ResumeLayout(false);
            this.pan거래처.PerformLayout();
            this.pan관리사.ResumeLayout(false);
            this.pan관리사.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Panel pan타이틀;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.TextBox txt구분;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pan거래처;
        private System.Windows.Forms.ComboBox cmb거래처;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb관리사;
        private System.Windows.Forms.Panel pan관리사;
    }
}