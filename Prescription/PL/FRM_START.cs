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
    public partial class FRM_START : Form
    {
        BL.CLS_UESRS BLUSERS = new BL.CLS_UESRS();
        public FRM_START()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSERS.load_start();
                if (dt.Rows.Count > 0)
                {
                    object ID = dt.Rows[0][0];
                    object name = dt.Rows[0][1];
                    object roll = dt.Rows[0][4];
                    BLUSERS.Edit_state(Convert.ToInt16(ID));
                    PL.FRM_HOME FRMIAN = new FRM_HOME();
                    FRMIAN.txt_doc_name.Text = ".د " + name.ToString();
                    FRMIAN.txt_doc_name2.Text = name.ToString();
                    FRMIAN.txt_doc_roll.Text = roll.ToString();
                    Properties.Settings.Default.username = "د" + "." + name.ToString();
                    Properties.Settings.Default.roll = roll.ToString();
                    Properties.Settings.Default.Save();

                    FRMIAN.Show();
                    this.Hide();
                    timer1.Enabled = false; 
                }
                else
                {
                    PL.FRM_LOGIN frmlogin = new FRM_LOGIN();
                    frmlogin.Show();
                    this.Hide();
                    timer1.Enabled=false;
                }

            }
            catch
            {
            }

        }
    }
}
