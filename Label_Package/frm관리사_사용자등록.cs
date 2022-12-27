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
    public partial class frm관리사_사용자등록 : Form
    {

        string sql = "";
        public frm관리사_사용자등록()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm관리사_사용자등록_Load(object sender, EventArgs e)
        {
            string d = "";

            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + d +" 】";

            txt구분.Text = cls_com.s사용자.구분;
            초기화();
            Add관리사();
            Add등급();
            조회();
        }
        private void Add관리사()
        {
            
            cls_com.ComboAdd(cmb관리사, " exec s_a101_관리사_조회 '1','" + cls_com.s사용자.관리사 + "','' ",1);
            if (cls_com.s사용자.구분.Equals("관리사"))
            {
                cmb관리사.Text = cls_com.s사용자.관리사;
                cmb관리사.Enabled = false;
            }
        }

        private void Add등급()
        {
            cmb권한.Items.Clear();
            cmb권한.Items.Add("관리자");
            cmb권한.Items.Add("사용자");
        }
        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void 조회()
        {
            //SPEC


            sql = " exec s_a101_관리사_사용자_조회 '1','" +"관리사" + "','" +   cls_com.s사용자.관리사  +"','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void 등록()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_사용자_저장] '1'";
            sql = sql + "   ,'" + cls_com.s사용자.구분  + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.관리사 + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.거래처 + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + cmb권한.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_사용자_저장] '2'";
            sql = sql + "   ,'" + cls_com.s사용자.구분 + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.관리사 + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.거래처 + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + cmb권한.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 삭제()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "사용자 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_사용자_저장] '3'";
            sql = sql + "   ,'" + cls_com.s사용자.구분 + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.관리사 + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.거래처 + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + cmb권한.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 7].Text;
            cmb권한.Text = spr.ActiveSheet.Cells[e.Row, 8].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;

        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";


        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCnt_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb권한_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pan구분_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pan데이타_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb개발사명_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb관리사_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
