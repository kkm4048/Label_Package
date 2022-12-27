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
    public partial class frm기초데이타_제품등록 : Form
    {

        string sql = "";
        public frm기초데이타_제품등록()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_제품등록_Load(object sender, EventArgs e)
        {
            string d = "";
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";

            d = cls_com.ConfigLoad(this.Name + "_넓이","300");
            sc.SplitterDistance = cls_com.Val(d);
            메뉴();
            초기화();
            Add관리사();
            Add거래처();
            조회0();
            조회();
        }
        private void 메뉴()
        {
            if (cls_com.s사용자.구분.Equals("관리사"))
            {
                pan관리사.Visible = false;
                pan거래처.Visible = true ;
            }
            else if (cls_com.s사용자.구분.Equals("거래처"))
            {
                pan관리사.Visible = false ;
                pan거래처.Visible  = false;
            }

        }

        private void Add관리사()
        {
            
            cls_com.ComboAdd(cmb관리사, " exec s_a101_관리사_조회 '1','','' ",1);
            if (cls_com.s사용자.구분.Equals("관리사"))
            {
                cmb관리사.Text = cls_com.s사용자.관리사;
                cmb관리사.Enabled = false;
            }
        }


        private void Add거래처()
        {
            cls_com.ComboAdd(cmb거래처, " exec s_a101_거래처_조회 '2','" + cmb관리사.Text + "','' ", 0);
            if (cls_com.s사용자.구분.Equals("거래처"))
            {
                cmb거래처.Text = cls_com.s사용자.거래처;
            }
        }
        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회0();
            조회();
        }

        private void 조회0()
        {
            sql = " exec s_a201_제품0_조회'1','" +   cmb관리사.Text  + "','" + cmb거래처.Text + "'  ";
            DataSet ds = cls_com.Select_Query(sql);
            spr0.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt0.Text = ds.Tables[0].Rows.Count.ToString();
            spr0.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr0.EditModeReplace = true;
                FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
                im = spr0.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);

                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).Locked = true;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr0.Sheets[0].Cells.Get(0, 1, spr0.Sheets[0].RowCount - 1, 1).Locked = false;
                spr0.Sheets[0].Cells.Get(0, 1, spr0.Sheets[0].RowCount - 1, 1).BackColor = cls_color.gColor_수정;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr0.Sheets[0]);
            lblCnt0.Text = spr0.ActiveSheet.RowCount.ToString();
        }

        private void 조회()
        {

            try
            {
                sql = " exec s_a201_제품_조회 '1','" + cmb관리사.Text + "','" + cmb거래처.Text + "','','" + txt조회.Text + "' ";
                DataSet ds = cls_com.Select_Query2(sql);
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
            } catch
            {

            }
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
            int i; 
            sql = " ";
            sql = sql + "EXEC [s_a201_제품_저장] '1'";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
            for (i = 0 ;  i < spr0.ActiveSheet.RowCount ; i++ ) {
                sql = sql + "   ,'" + spr0.ActiveSheet.Cells[i,1].Text + "' ";
            }
            for ( ; i < cls_com.g필드수; i++)
            {
                sql = sql + "   ,'" + "" + "' ";
            }


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
            int i;
            sql = " ";
            sql = sql + "EXEC [s_a201_제품_저장] '1'";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
            for (i = 0; i < spr0.ActiveSheet.RowCount; i++)
            {
                sql = sql + "   ,'" + spr0.ActiveSheet.Cells[i, 1].Text + "' ";
            }
            for (; i < cls_com.g필드수; i++)
            {
                sql = sql + "   ,'" + "" + "' ";
            }
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
        private void 삭제()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "사용자 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            int i;
            sql = " ";
            sql = sql + "EXEC [s_a201_제품_저장] '3'";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
            for (i = 0; i < spr0.ActiveSheet.RowCount; i++)
            {
                sql = sql + "   ,'" + spr0.ActiveSheet.Cells[i, 1].Text + "' ";
            }
            for (; i < cls_com.g필드수; i++)
            {
                sql = sql + "   ,'" + "" + "' ";
            }
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

            try
            {
                if (e.Row < 0) return;
                //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
                for (int i = 0; i < spr.ActiveSheet.ColumnCount; i++)
                {
                    spr0.ActiveSheet.Cells[i, 1].Text = spr.ActiveSheet.Cells[e.Row, i].Text;
                }
            } catch
            {

            }

        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt조회.Text = "";
            for (int i = 0; i < spr0.ActiveSheet.RowCount;i ++)
            {
                spr0.ActiveSheet.Cells[i, 1].Text = "";
            }

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
            조회();
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
            조회();
        }

        private void cmb거래처_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회0();
            조회();

        }

        private void spr0_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr0.ActiveSheet);
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_넓이", sc.SplitterDistance.ToString());
        }
    }
}
