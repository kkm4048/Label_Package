using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Label_Package
{
    public partial class frm메인 : Form
    {
        public frm메인()
        {
            InitializeComponent();
        }

        private void frm메인_Load(object sender, EventArgs e)
        {


            m개발사.Visible = false;
            m관리사.Visible = false;

            if (cls_com.s사용자.구분.Equals("개발사"))
            {
                m개발사.Visible = true;
                m관리사.Visible = true;

            }
            else if (cls_com.s사용자.구분.Equals("관리사"))
            {
                m관리사.Visible = true;

            }
            else
            {

            }
                
            ts.Text = cls_com.s사용자.구분 + " " +  cls_com.s사용자.아이디  + " " + cls_com.s사용자.성명 + " " + cls_com.s사용자.권한;

        }

        private void m개발사_관리사등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_사용자등록");
        }
        private void FrmShow2(String formToCall)
        {
            try
            {
                var type = Type.GetType("Label_Package." + formToCall);
                Form frm = Activator.CreateInstance(type) as Form;

                if (frm != null)
                {
                    bool FrmisExist = new bool();
                    FrmisExist = false;

                    foreach (Form form1 in Application.OpenForms)
                    {
                        if (form1.GetType() == frm.GetType())
                        {

                            form1.Activate();
                            form1.Focus();
                            FrmisExist = true;
                        }
                    }

                    // 폼존재여부에 따라서 생성과 파기
                    if (!FrmisExist)
                    {

                        frm.MdiParent = this;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        frm.Activate();
                        frm.Focus();
                        frm.BringToFront();
                    }
                    else
                    {
                        frm.Dispose();
                    }
                }
            }
            catch
            {
            }


        }

        private void m개발사_사용자등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_사용자등록");
        }

        private void m개발사_거래처등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_사용자등록");
        }

        private void m관리사_거래처등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm관리사_거래처등록");
        }

        private void m관리사_사용자등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm관리사_사용자등록");
        }

        private void m기초데이타_사용자등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_사용자등록");
        }

        private void 거래처제품정의ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow2("frm관리사_제품정의");
        }

        private void m기초데이타_제품등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_제품등록");
        }

        private void 제품라벨출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow2("frm라벨출력_제품라벨출력");
        }
    }
}
