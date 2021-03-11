using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace System_Devices
{
    public partial class Form_Devices : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_Devices()
        {
            InitializeComponent();
        }

        private void Form_Devices_Load(object sender, EventArgs e)
        {
            db = new ClassDB2();
            ////جلب البيانات من الجدول
            //ds = new DataSet();
            DataSet ds2 = new DataSet();
            db.ConnectDb();
            ds = db.SetectDB("select * from DEVICES ", "DEVICES");
            ds2 = db.SetectDB("select * from CATEGROIES", "CATEGROIES");

            comboBoxCategories.DataSource = ds2;
            comboBoxCategories.DisplayMember = "CATEGROIES.name";
            comboBoxCategories.ValueMember = "CATEGROIES.id";


            // textBoxاظهار بيانات الجدول في 
            textBox_num.DataBindings.Add("text", ds, "DEVICES.id");
            textBox_name.DataBindings.Add("text", ds, "DEVICES.name");
            textBox_dasc.DataBindings.Add("text", ds, "DEVICES.DESCRIPTION");
            textBox_issus.DataBindings.Add("text", ds, "DEVICES.issus");
            textBox_man.DataBindings.Add("text", ds, "DEVICES.MANUFACTURE");
            textBox_sales.DataBindings.Add("text", ds, "DEVICES.sales");
            textBox_type.DataBindings.Add("text", ds, "DEVICES.type");
            
            
            comboBoxCategories.DataBindings.Add("text", ds, "DEVICES.cate_name");




        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "DEVICES"].Position = this.BindingContext[ds, "DEVICES"].Count - 1;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "DEVICES"].Position = 0;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "DEVICES"].Position -= 1;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "DEVICES"].Position += 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          


            string query = "insert into DEVICES (id,name,sales,DESCRIPTION,issus,MANUFACTURE,type,cate_id) values(" + textBox_num.Text + ",'" + textBox_name.Text + "'," + textBox_sales.Text + ",'" + textBox_dasc.Text + "','" + textBox_issus.Text + "','" + textBox_man.Text + "','" + textBox_type.Text + "'," + comboBoxCategories.SelectedValue + ")";

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Saved");
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            BindingContext[ds, "DEVICES"].AddNew();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "update DEVICES set name ='" + textBox_name.Text + "',sales=" + textBox_sales.Text + ",DESCRIPTION='" + textBox_dasc.Text + "',issus='" + textBox_issus.Text + "',MANUFACTURE='" + textBox_man.Text + "',type='" + textBox_type.Text + "',cate_id=" + comboBoxCategories.SelectedValue + " where id=" + textBox_num.Text;

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Updated");
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record", "Delete Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "delete from DEVICES where id =" + textBox_num.Text;

                db.Insert_Update_DeleteDB(query);

                MessageBox.Show("Your Data Deleted");
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form_queryDevices f = new Form_queryDevices();
            // f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Close();
        }
    }
}
