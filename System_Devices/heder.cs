using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Devices
{
    public partial class heder : UserControl
    {
        public FormWindowState WindowState { get; private set; }

        public heder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_setting f = new Form_setting();
            f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
