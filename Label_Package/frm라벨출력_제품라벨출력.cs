using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Label_Package
{
    public partial class frm라벨출력_제품라벨출력 : Form
    {

        string sql = "";
        public frm라벨출력_제품라벨출력()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm라벨출력_제품라벨출력_Load(object sender, EventArgs e)
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
            Add라벨명();
            Add프린터명();
            조회();
            조회2();
        }
        private void Add라벨명()
        {
            cmb라벨명.Text = cls_com.ConfigLoad(this.Name + "_제품라벨");
        }
        private void Add프린터명()
        {
            String d = "";
            cmb프린터명.Items.Clear();
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                d = printer;
                try
                {
                    cmb프린터명.Items.Add(printer);
                }
                catch (Exception e)
                {
                    MessageBox.Show("프린터에러 : " + d + " > " + e.Message);
                }
            }
            cmb프린터명.Text = cls_com.ConfigLoad(this.Name + "_프린터");
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
            조회();
            조회2();
        }

        private void 조회()
        {
            sql = " exec s_a201_제품_조회'1','" +   cmb관리사.Text  + "','" + cmb거래처.Text + "','',''  ";
            DataSet ds = cls_com.Select_Query2(sql);
            spr0.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt0.Text = ds.Tables[0].Rows.Count.ToString();
            spr0.DataSource = ds;
            lbl1.Text = ds.Tables[0].Columns[0].ColumnName ;
            lbl2.Text = ds.Tables[0].Columns[1].ColumnName;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).Locked = true;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr0.Sheets[0]);
            lblCnt0.Text = spr0.ActiveSheet.RowCount.ToString();
        }

        private void 조회2()
        {

            try
            {
                sql = " exec s_a301_제품_출력_조회 '1','" + cmb관리사.Text + "','" + cmb거래처.Text + "','" + cls_com.GetDate2() + "','" + cls_com.GetDate2() + "','" + txt조회.Text + "' ";
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

 

      
        
        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            try
            {
                if (e.Row < 0) return;
                txt1.Text  = spr.ActiveSheet.Cells[e.Row, 4].Text;
                txt2.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;

            }
            catch
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
            조회();
            조회2();

        }

        private void spr0_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr0.ActiveSheet);
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_넓이", sc.SplitterDistance.ToString());
        }

        private void spr0_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt1.Text = spr0.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr0.ActiveSheet.Cells[e.Row, 1].Text;


        }

        private void btn라벨출력_Click(object sender, EventArgs e)
        {
            string d = "";
            if (저장())
            {
                d= 라벨출력2();
                if (d.Length > 20 )
                {
                    Stream fileStream = new FileStream(cls_com.g파일_자동출력, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fileStream);

                    sw.WriteLine(d);

                    sw.Close();

                    라벨출력프로그램();
                }
                조회2();
            }
        }

        private bool 저장()
        {
            int i;

            sql = " EXEC s_a301_제품_출력_제품_조회 '1' ";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
            sql = sql + "   ,'" + txt1.Text  + "' ";
            sql = sql + "   ,'" +"" + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count <= 0 )
            {
                return false;
            }

            sql = " ";
            sql = sql + "EXEC [s_a301_제품_출력_저장] '1'";
            sql = sql + "   ,'" + cmb관리사.Text + "' ";
            sql = sql + "   ,'" + cmb거래처.Text + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
            sql = sql + "   ,'" + txt출력수량.Text  + "' ";
            for (i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                sql = sql + "   ,'" + ds.Tables[0].Rows[0][i].ToString() + "' ";
            }
            for (; i < cls_com.g필드수; i++)
            {
                sql = sql + "   ,'" + "" + "' ";
            }


            DataSet ds2 = cls_com.Select_Query(sql);

            if (ds2 == null) return false ;
            if (ds2.Tables[0].Rows.Count > 0)
            {
                if (!ds2.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds2.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            return true; ;
        }

        private string  라벨출력2()
        {
            String d = "";
            sql = " s_a501_제품_라벨출력 '1','" + cmb라벨명.Text + "','" + cmb프린터명.Text + "','" + txt출력수량.Text + "','" + cmb관리사.Text + "','" + cmb거래처.Text + "','" + txt1.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            d = ds.GetXml();
            사진생성(txt1.Text);
            return d;

        }

        private void 사진생성(string 제품코드)
        {
            try
            {
                sql = "EXEC s_A201_제품_사진_조회 '1','" + cls_com.s사용자.관리사 + "','" + cls_com.s사용자.거래처 + "','" + 제품코드 + "' ";
                DataSet ds = cls_com.Select_Query(sql);

                if (ds == null) return;

                ImageConverter ImageConvert = new ImageConverter();
                Image img;
                img = (Image)ImageConvert.ConvertFrom(ds.Tables[0].Rows[0]["사진"]);
                img.Save(cls_com.gPath_그림 + "\\" + 제품코드 + ".jpg");
            }
            catch
            {
            }
        }

        private void 라벨출력프로그램()
        {

            Process[] processlist = Process.GetProcessesByName("syst_label_package");
            if (processlist.Length <= 0)
            {
                Process.Start(cls_com.g파일_자동출프로그램);

            }


        }

        private void cmb라벨명_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_제품라벨", cmb라벨명.Text);
        }

        private void cmb프린터_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_프린터", cmb프린터명.Text);
        }

        private void cmb라벨명_TextChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_제품라벨", cmb라벨명.Text);
        }

        private void cmb프린터_SelectedValueChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_프린터", cmb프린터명.Text);
        }

        private void btn라벨명_Click(object sender, EventArgs e)
        {
            if (cmb라벨명.Enabled)
            {
                cmb라벨명.Enabled = false;
            } else {
                cmb라벨명.Enabled = true;
            }
        }

        private void btn프린터명_Click(object sender, EventArgs e)
        {
            if (cmb프린터명.Enabled)
            {
                cmb프린터명.Enabled = false;
            }
            else
            {
                cmb프린터명.Enabled = true;
            }

        }
    }
}
