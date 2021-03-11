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
    public partial class control : UserControl
    {
        public control()
        {
            InitializeComponent();
 
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            
            Form_categ f = new Form_categ();
            //f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Hide();

        }

        private void btn_device_Click(object sender, EventArgs e)
        {
          
            Form_Devices f = new Form_Devices();
           // f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Hide();
        }

        private void btn_custom_Click(object sender, EventArgs e)
        {
            Form_customer f = new Form_customer();
            //f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Hide();
        }

        
       

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 260)
            {
                panel3.Width = 51;
                this.btn_menu.Location = new Point(0, 0);


            }
            else
            {
                panel3.Width = 260;
                this.btn_menu.Location = new Point(159, 0);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form_main f = new Form_main();
            // f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Close();

        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            Form_sales f = new Form_sales();
            // f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Close();
        }
    }
}
