namespace Label_Package
{
    partial class frm메인
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m파일 = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.m개발사 = new System.Windows.Forms.ToolStripMenuItem();
            this.m개발사_관리사등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m개발사_거래처등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m개발사_사용자등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m관리사 = new System.Windows.Forms.ToolStripMenuItem();
            this.m관리사_거래처등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m관리사_사용자등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.거래처제품정의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_제품등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_사용자등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m라벨출력 = new System.Windows.Forms.ToolStripMenuItem();
            this.제품라벨출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.박스라벨출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1165, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts
            // 
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(31, 17);
            this.ts.Text = "정보";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일,
            this.m개발사,
            this.m관리사,
            this.m기초데이타,
            this.m라벨출력});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m파일
            // 
            this.m파일.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일_설정,
            this.m파일_종료});
            this.m파일.Name = "m파일";
            this.m파일.Size = new System.Drawing.Size(47, 20);
            this.m파일.Text = "파 일";
            // 
            // m파일_설정
            // 
            this.m파일_설정.Name = "m파일_설정";
            this.m파일_설정.Size = new System.Drawing.Size(102, 22);
            this.m파일_설정.Text = "설 정";
            // 
            // m파일_종료
            // 
            this.m파일_종료.Name = "m파일_종료";
            this.m파일_종료.Size = new System.Drawing.Size(102, 22);
            this.m파일_종료.Text = "종 료";
            // 
            // m개발사
            // 
            this.m개발사.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m개발사_관리사등록,
            this.m개발사_거래처등록,
            this.m개발사_사용자등록});
            this.m개발사.Name = "m개발사";
            this.m개발사.Size = new System.Drawing.Size(55, 20);
            this.m개발사.Text = "개발사";
            // 
            // m개발사_관리사등록
            // 
            this.m개발사_관리사등록.Name = "m개발사_관리사등록";
            this.m개발사_관리사등록.Size = new System.Drawing.Size(138, 22);
            this.m개발사_관리사등록.Text = "관리사 등록";
            this.m개발사_관리사등록.Click += new System.EventHandler(this.m개발사_관리사등록_Click);
            // 
            // m개발사_거래처등록
            // 
            this.m개발사_거래처등록.Name = "m개발사_거래처등록";
            this.m개발사_거래처등록.Size = new System.Drawing.Size(138, 22);
            this.m개발사_거래처등록.Text = "거래처 등록";
            this.m개발사_거래처등록.Click += new System.EventHandler(this.m개발사_거래처등록_Click);
            // 
            // m개발사_사용자등록
            // 
            this.m개발사_사용자등록.Name = "m개발사_사용자등록";
            this.m개발사_사용자등록.Size = new System.Drawing.Size(138, 22);
            this.m개발사_사용자등록.Text = "사용자 등록";
            this.m개발사_사용자등록.Click += new System.EventHandler(this.m개발사_사용자등록_Click);
            // 
            // m관리사
            // 
            this.m관리사.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m관리사_거래처등록,
            this.m관리사_사용자등록,
            this.toolStripMenuItem1,
            this.거래처제품정의ToolStripMenuItem});
            this.m관리사.Name = "m관리사";
            this.m관리사.Size = new System.Drawing.Size(55, 20);
            this.m관리사.Text = "관리사";
            // 
            // m관리사_거래처등록
            // 
            this.m관리사_거래처등록.Name = "m관리사_거래처등록";
            this.m관리사_거래처등록.Size = new System.Drawing.Size(180, 22);
            this.m관리사_거래처등록.Text = "거래처 등록";
            this.m관리사_거래처등록.Click += new System.EventHandler(this.m관리사_거래처등록_Click);
            // 
            // m관리사_사용자등록
            // 
            this.m관리사_사용자등록.Name = "m관리사_사용자등록";
            this.m관리사_사용자등록.Size = new System.Drawing.Size(180, 22);
            this.m관리사_사용자등록.Text = "사용자 등록";
            this.m관리사_사용자등록.Click += new System.EventHandler(this.m관리사_사용자등록_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 거래처제품정의ToolStripMenuItem
            // 
            this.거래처제품정의ToolStripMenuItem.Name = "거래처제품정의ToolStripMenuItem";
            this.거래처제품정의ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.거래처제품정의ToolStripMenuItem.Text = "거래처 제품 정의";
            this.거래처제품정의ToolStripMenuItem.Click += new System.EventHandler(this.거래처제품정의ToolStripMenuItem_Click);
            // 
            // m기초데이타
            // 
            this.m기초데이타.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m기초데이타_제품등록,
            this.m기초데이타_사용자등록});
            this.m기초데이타.Name = "m기초데이타";
            this.m기초데이타.Size = new System.Drawing.Size(83, 20);
            this.m기초데이타.Text = "기초 데이타";
            // 
            // m기초데이타_제품등록
            // 
            this.m기초데이타_제품등록.Name = "m기초데이타_제품등록";
            this.m기초데이타_제품등록.Size = new System.Drawing.Size(180, 22);
            this.m기초데이타_제품등록.Text = "제품 등록";
            this.m기초데이타_제품등록.Click += new System.EventHandler(this.m기초데이타_제품등록_Click);
            // 
            // m기초데이타_사용자등록
            // 
            this.m기초데이타_사용자등록.Name = "m기초데이타_사용자등록";
            this.m기초데이타_사용자등록.Size = new System.Drawing.Size(138, 22);
            this.m기초데이타_사용자등록.Text = "사용자 등록";
            this.m기초데이타_사용자등록.Click += new System.EventHandler(this.m기초데이타_사용자등록_Click);
            // 
            // m라벨출력
            // 
            this.m라벨출력.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제품라벨출력ToolStripMenuItem,
            this.박스라벨출력ToolStripMenuItem});
            this.m라벨출력.Name = "m라벨출력";
            this.m라벨출력.Size = new System.Drawing.Size(71, 20);
            this.m라벨출력.Text = "라벨 출력";
            // 
            // 제품라벨출력ToolStripMenuItem
            // 
            this.제품라벨출력ToolStripMenuItem.Name = "제품라벨출력ToolStripMenuItem";
            this.제품라벨출력ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.제품라벨출력ToolStripMenuItem.Text = "제품 라벨 출력";
            this.제품라벨출력ToolStripMenuItem.Click += new System.EventHandler(this.제품라벨출력ToolStripMenuItem_Click);
            // 
            // 박스라벨출력ToolStripMenuItem
            // 
            this.박스라벨출력ToolStripMenuItem.Name = "박스라벨출력ToolStripMenuItem";
            this.박스라벨출력ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.박스라벨출력ToolStripMenuItem.Text = "박스 라벨 출력";
            // 
            // frm메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 706);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm메인";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Package System [LPS] v1.1  2022-12.30";
            this.Load += new System.EventHandler(this.frm메인_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m파일;
        private System.Windows.Forms.ToolStripMenuItem m파일_설정;
        private System.Windows.Forms.ToolStripMenuItem m파일_종료;
        private System.Windows.Forms.ToolStripMenuItem m개발사;
        private System.Windows.Forms.ToolStripMenuItem m개발사_관리사등록;
        private System.Windows.Forms.ToolStripMenuItem m관리사;
        private System.Windows.Forms.ToolStripMenuItem m관리사_거래처등록;
        private System.Windows.Forms.ToolStripMenuItem m관리사_사용자등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_사용자등록;
        private System.Windows.Forms.ToolStripMenuItem m라벨출력;
        private System.Windows.Forms.ToolStripMenuItem 제품라벨출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 박스라벨출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m개발사_거래처등록;
        private System.Windows.Forms.ToolStripMenuItem m개발사_사용자등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_제품등록;
        private System.Windows.Forms.ToolStripStatusLabel ts;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 거래처제품정의ToolStripMenuItem;
    }
}

