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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_UESRS BLUSERS = new BL.CLS_UESRS();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);        
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("ادخل معلومات الدخول");
            }
            else
            {

                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUSERS.loadLogin(txt_username.Text, txt_password.Text);
                    if (dt.Rows.Count > 0)
                    {
                        object ID = dt.Rows[0][0]; 
                        object name = dt.Rows[0][1];
                        object roll = dt.Rows[0][4];
                        BLUSERS.Edit_state(Convert.ToInt16(ID));
                        PL.FRM_HOME FRMIAN = new FRM_HOME();
                        FRMIAN.txt_doc_name.Text =".د "+ name.ToString();
                        FRMIAN.txt_doc_name2.Text = name.ToString();
                        FRMIAN.txt_doc_roll.Text = roll.ToString();
                        Properties.Settings.Default.username="د"+"."+name.ToString();
                        Properties.Settings.Default.roll=roll.ToString();
                        Properties.Settings.Default.Save();

                        FRMIAN.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في معلومات  تسجيل الدخول");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
               
            }
        }
    }
}
