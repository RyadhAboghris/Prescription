using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prescription.PL
{
    public partial class FRM_BACKUP : Form
    {
        // this for move form 
        int move, movex, movey;
        string DBNAME,DBSAVEPATH,DBRESTORENAME;
        public FRM_BACKUP()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PL.FRM_WRITEPAGES frmWrite =new FRM_WRITEPAGES();
            frmWrite.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            PL.FRM_HOME frmhome = new FRM_HOME();
            frmhome.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            var rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                DBSAVEPATH = ofd.SelectedPath;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                DBRESTORENAME = ofd.FileName;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DBNAME + ";Integrated Security=True");
                string quarystr = "ALTER DATABASE ["+DBNAME+"]SET OFFLINE WITH ROLLBACK IMMEDIATE;RESTORE DATABASE [" + DBNAME + "] FROM DISK='" + DBRESTORENAME + "'";
                SqlCommand cmd = new SqlCommand(quarystr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة النسخة بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DBNAME + ";Integrated Security=True");
                string FileName = DBSAVEPATH + "\\DBPRSCRIPTION";
                string quarystr = "BACKUP DATABASE [" + DBNAME + "] TO DISK='" + FileName + ".bak'";
                SqlCommand cmd = new SqlCommand(quarystr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم النسخ الاحتياطي بنجاح");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var rs=ofd.ShowDialog();
            if(rs== DialogResult.OK)
            {
                DBNAME=ofd.FileName;
            }
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
