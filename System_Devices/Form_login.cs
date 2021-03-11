using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Devices
{
    public partial class form_login : Form
    {
       
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_userName.Text!= "" && textBox_password.Text!= "")
            {
                ClassDB2 db = new ClassDB2();
                db.ConnectDb();
                string Query = ("select * from login where name ='" + textBox_userName.Text + "' and password='" + textBox_password.Text + "'");
                DataSet DS = new DataSet();
                DS = db.SetectDB(Query, "login");

                if (DS.Tables["login"].Rows.Count > 0)
                {
                    Form_main.getMainForm.control1.Enabled = true;
                    Form_main.getMainForm.heder1.Enabled = true;
                    Form_queryDevices f = new Form_queryDevices();
                    // f.Location = new Point(20, 20);


                    f.Show();

                    ((Form)this.TopLevelControl).Close();
                    this.Close();

                }
                else
                {
                    label_error.Text = "Your Name or your password not valid";
                }

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
                
        }
    }
}
