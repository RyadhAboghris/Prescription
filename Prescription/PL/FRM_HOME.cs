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
    public partial class FRM_HOME : Form
    {
        // this for move form 
        int move, movex, movey;
        //instance from users form
       BL.CLS_UESRS BLUSER = new BL.CLS_UESRS();
        public FRM_HOME()
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

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Transparent;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
          PL.FRM_CONTROL frmcon = new PL.FRM_CONTROL();
            frmcon.user_state=txt_doc_roll.Text;
            frmcon.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PL.FRM_WRITEPAGES frmWrite =new FRM_WRITEPAGES();
            frmWrite.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            PL.FRM_BACKUP frmBackup =new PL.FRM_BACKUP();
            frmBackup.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            
            try
            {
                BLUSER.logout();
                PL.FRM_LOGIN frmLogin = new PL.FRM_LOGIN();
                frmLogin.Show();
                this.Hide();
            }
            catch { }
        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            txt_doc_name.Text = Properties.Settings.Default.username;
            txt_doc_name2.Text = Properties.Settings.Default.username;
            txt_doc_roll.Text = Properties.Settings.Default.roll;
         
            if (txt_doc_roll.Text == "مدير")
            {
                panel5.Enabled = true;
            }
            else
            {
                panel5.Enabled = false;
            }

        }

        private void panel5_Click(object sender, PaintEventArgs e)
        {

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
