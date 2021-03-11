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
    public partial class Form_main : Form
    {
        private static Form_main frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Form_main getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Form_main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.control1.Enabled = false;
            this.heder1.Enabled = false;

        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            form_login f = new form_login();
            //f.Location = new Point(20, 20);


            f.ShowDialog();

            
        }
    }
}
