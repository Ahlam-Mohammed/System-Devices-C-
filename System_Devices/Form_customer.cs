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
    public partial class Form_customer : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_customer()
        {
            InitializeComponent();
        }

        private void Form_customer_Load(object sender, EventArgs e)
        {

            db = new ClassDB2();
            //جلب البيانات من الجدول
            ds = new DataSet();
            db.ConnectDb();
            ds = db.SetectDB("select * from CUSTOMER ", "CUSTOMER");


            // textBoxاظهار بيانات الجدول في 
            textBox_num.DataBindings.Add("text", ds, "CUSTOMER.id");
            textBox_name.DataBindings.Add("text", ds, "CUSTOMER.name");
            textBox_title.DataBindings.Add("text", ds, "CUSTOMER.title");
            textBox_phone.DataBindings.Add("text", ds, "CUSTOMER.phone");
            // اظهار بيانات الجدول كامل 
            dataGrid_cust.DataSource = ds;
            dataGrid_cust.DataMember = "CUSTOMER";


        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CUSTOMER"].Position = this.BindingContext[ds, "CUSTOMER"].Count - 1;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CUSTOMER"].Position = 0;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CUSTOMER"].Position -= 1;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "CUSTOMER"].Position += 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = "insert into CUSTOMER (name,title,phone) values('" + textBox_name.Text + "','"+textBox_title.Text+"','"+textBox_phone.Text+"')";

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Saved");
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            BindingContext[ds, "CUSTOMER"].AddNew();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "update CUSTOMER set name ='" + textBox_name.Text + "',title='" + textBox_title.Text + "',phone ='" + textBox_phone.Text + "' where id=" + textBox_num.Text;

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Updated");
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record", "Delete Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "delete from CUSTOMER where id =" + textBox_num.Text;

                db.Insert_Update_DeleteDB(query);

                MessageBox.Show("Your Data Deleted");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from CUSTOMER", "CUSTOMER");
            dataGrid_cust.DataSource = null;
            dataGrid_cust.DataSource = ds;
            dataGrid_cust.DataMember = "CUSTOMER";
        }

       

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from CUSTOMER where name like '%" + textBox_search.Text + "%'", "SearchCUSTOMER");
            dataGrid_cust.DataSource = ds;
            dataGrid_cust.DataMember = "SearchCUSTOMER";
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            Form_bill f = new Form_bill();
            // f.Location = new Point(20, 20);


            f.Show();

            ((Form)this.TopLevelControl).Close();
        }
    }
}
