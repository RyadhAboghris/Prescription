using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prescription.PL
{
    public partial class FRM_WRITEPAGES : Form
    {
        // this for move form 
        int move, movex, movey;
        // instance from class
        BL.CLS_PRES BLPRES = new BL.CLS_PRES();
        BL.CLS_TREAT BLTREAT = new BL.CLS_TREAT();

        public FRM_WRITEPAGES()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState =FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex=e.X;  
            movey=e.Y;
        }

       

        private void panel5_Click(object sender, EventArgs e)
        {
          PL.FRM_CONTROL frmcon = new PL.FRM_CONTROL();
            frmcon.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            PL.FRM_HOME frmhome = new FRM_HOME();
            frmhome.Show();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == ""||txt_name.Text==""|| txt_type.Text == "")
            {
                MessageBox.Show("ادخل متطلبات الادخال اولا");
            }
            else
            {
                BLPRES.Insert_Pat_Info(txt_name.Text, Convert.ToInt16(txt_age.Text), txt_type.Text);
                pn_treat_info.BringToFront();
                txt_name.Text = ""; 
                txt_age.Text = "";
                txt_type.Text = "";
            }
        }

        private void FRM_WRITEPAGES_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLPRES.loadTreat();
            AutoCompleteStringCollection cool=new AutoCompleteStringCollection();
            foreach(DataRow row in dt.Rows)
            {
                cool.Add(row[0].ToString());
            }
            txt_treat_name.AutoCompleteCustomSource = cool;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(txt_treat_name.Text == "")
            {
                MessageBox.Show("رجاءا اكمل متطلبات العلاج");
            }
            else
            {
                DataTable dt2 = new DataTable();
                dt2 = BLTREAT.loadPat();
                int lastRow=dt2.Rows.Count-1;
                object ob1 = dt2.Rows[lastRow][0];
                int PAT_ID = Convert.ToInt16(ob1);
                BLPRES.Insert_Treat_Info(PAT_ID, txt_treat_name.Text, txt_all.Text, txt_dur.Text, txt_time.Text);
                txt_treat_name.Text = txt_all.Text = txt_dur.Text = txt_time.Text = "";
                MessageBox.Show("تمت اضافة العلاج");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = BLTREAT.loadPat();
            int pat_id,pat_age;
            string pat_name,pat_type;
            int lastRow = dt2.Rows.Count - 1;
            object ob1 = dt2.Rows[lastRow][0];
            object ob2 = dt2.Rows[lastRow][1];
            object ob3 = dt2.Rows[lastRow][2];
            object ob4 = dt2.Rows[lastRow][3];
            pat_id = Convert.ToInt16(ob1);
            pat_name=Convert.ToString(ob2);
            pat_age=Convert.ToInt16(ob3);
            pat_type = Convert.ToString(ob4);
            // load treat for patients
            PL.FRM_PRINT frmPrint = new FRM_PRINT();
            DataTable dt = new DataTable();
            dt = BLTREAT.loadTreatPat(pat_id);
            frmPrint.dgvprint.DataSource = dt;
            frmPrint.dgvprint.Columns[0].HeaderText = "اسم العلاج";
            frmPrint.dgvprint.Columns[1].HeaderText = "كل";
            frmPrint.dgvprint.Columns[2].HeaderText = "لمدة";
            frmPrint.dgvprint.Columns[3].HeaderText = "الوقت";
            frmPrint.txt_name.Text = pat_name;
            frmPrint.txt_age.Text = pat_age.ToString();
            frmPrint.txt_type.Text = pat_type;
            frmPrint.Show();
            txt_treat_name.Text = txt_all.Text = txt_dur.Text = txt_time.Text = "";
            pn_pat_info.BringToFront();

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X-movex, MousePosition.Y-movey);
            }
        }
    }
}
