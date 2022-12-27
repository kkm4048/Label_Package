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
    public partial class frm관리사_제품정의 : Form
    {

        string sql = "";
        public frm관리사_제품정의()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm관리사_제품정의_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";

            // 메뉴();
            txt구분.Text = "거래처" ;

            초기화();
            Add관리사();
            Add거래처();
            조회();
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
            조회();
        }

        private void 조회()
        {

            sql = " exec s_a101_제품_필드명_조회 '1','" + cmb관리사.Text  + "','" + cmb거래처.Text  +"','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr.EditModeReplace = true;
                FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
                im = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.Sheets[0].Cells.Get(0, 1, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked =  false;
                spr.Sheets[0].Cells.Get(0, 1, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).BackColor = cls_color.gColor_수정;

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }



        private void 저장()
        {

            if (cmb관리사.Text.Equals(""))
            {
                MessageBox.Show("관리사를 확인하세요");
                return;
            }
            if (cmb거래처.Text.Equals(""))
            {
                MessageBox.Show("거래처를 확인하세요");
                return;
            }

            sql = " ";
            sql = sql + "EXEC [s_a101_제품_필드명_저장] '3'";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
            sql = sql + "   ,'' ";
            sql = sql + "   ,'' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }

            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                if (spr.ActiveSheet.Cells[i, 1].Text.Equals(""))  break;

                sql = " ";
                sql = sql + "EXEC [s_a101_제품_필드명_저장] '1'";
                sql = sql + "   ,'" + cmb관리사.Text + "' ";
                sql = sql + "   ,'" + cmb거래처.Text + "' ";
                sql = sql + "   ,'" + spr.ActiveSheet.Cells[i, 0].Text + "' ";
                sql = sql + "   ,'" + spr.ActiveSheet.Cells[i, 1].Text + "' ";
                ds = cls_com.Select_Query(sql);

                if (ds == null) return;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                    {
                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    }

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
            sql = sql + "   ,'" + txt구분.Text + "' ";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
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
            sql = sql + "   ,'" + txt구분.Text + "' ";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
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

        }

        private void btninit_Click(object sender, EventArgs e)
        {


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
            조회();
        }

        private void cmb거래처_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }
    }
}
