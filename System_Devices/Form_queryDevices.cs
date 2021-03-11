using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace System_Devices
{
    public partial class Form_queryDevices : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_queryDevices()
        {
            InitializeComponent();
        }

        private void Form_queryDevices_Load(object sender, EventArgs e)
        {
            db = new ClassDB2();
            //جلب البيانات من الجدول
            ds = new DataSet();
            db.ConnectDb();
            ds = db.SetectDB("select * from DEVICES ", "DEVICES");
           

            // textBoxاظهار بيانات الجدول في 
            textBox_num.DataBindings.Add("text", ds, "DEVICES.id");
            textBox_name.DataBindings.Add("text", ds, "DEVICES.name");

            // اظهار بيانات الجدول كامل 
            dataGrid_dvi.DataSource = ds;
            dataGrid_dvi.DataMember = "DEVICES";

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

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record", "Delete Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "delete from DEVICES where id =" + textBox_num.Text;

                db.Insert_Update_DeleteDB(query);

                MessageBox.Show("Your Data Deleted");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from DEVICES", "DEVICES");
            dataGrid_dvi.DataSource = null;
            dataGrid_dvi.DataSource = ds;
            dataGrid_dvi.DataMember = "DEVICES";
        }



   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from DEVICES where name like '%" + textBox_search.Text + "%'", "SearchDEVICES");
            dataGrid_dvi.DataSource = ds;
            dataGrid_dvi.DataMember = "SearchDEVICES";
        }
    }
}
