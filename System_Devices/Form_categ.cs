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
    public partial class Form_categ : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_categ()
        {
            InitializeComponent();
        }

        private void Form_categ_Load(object sender, EventArgs e)
        {
            db = new ClassDB2();
            //جلب البيانات من الجدول
            ds = new DataSet();
            db.ConnectDb();
            ds = db.SetectDB("select * from CATEGROIES ", "CATEGROIES");


            // textBoxاظهار بيانات الجدول في 
            textBox_num.DataBindings.Add("text", ds, "CATEGROIES.id");
            textBox_name.DataBindings.Add("text", ds, "CATEGROIES.name");

            // اظهار بيانات الجدول كامل 
            dataGrid_cat.DataSource = ds;
            dataGrid_cat.DataMember = "CATEGROIES";

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CATEGROIES"].Position = this.BindingContext[ds, "CATEGROIES"].Count-1;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CATEGROIES"].Position = 0;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CATEGROIES"].Position -=1;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CATEGROIES"].Position +=1;
        }

        

        

        
       

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from CATEGROIES", "CATEGROIES");
            dataGrid_cat.DataSource = null;
            dataGrid_cat.DataSource = ds;
            dataGrid_cat.DataMember = "CATEGROIES";
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from CATEGROIES where name like '%" + textBox_search.Text + "%'", "SearchCATEGROIES");
            dataGrid_cat.DataSource = ds;
            dataGrid_cat.DataMember = "SearchCATEGROIES";
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            string query = "insert into CATEGROIES ([name]) values('" + textBox_name.Text + "')";

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Saved");
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            string query = "update CATEGROIES set name ='" + textBox_name.Text + "' where id=" + textBox_num.Text;

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Updated");
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            BindingContext[ds, "CATEGROIES"].AddNew();
        }

        private void btn_delet_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record", "Delete Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "delete from CATEGROIES where id =" + textBox_num.Text;

                db.Insert_Update_DeleteDB(query);

                MessageBox.Show("Your Data Deleted");
            }
        }
    }
}
