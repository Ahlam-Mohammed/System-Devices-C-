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
    public partial class Form_sales : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_sales()
        {
            InitializeComponent();
        }

        private void Form_sales_Load(object sender, EventArgs e)
        {
            db = new ClassDB2();
            //جلب البيانات من الجدول
            ds = new DataSet();
            db.ConnectDb();
            ds = db.SetectDB("select * from SALES ", "SALES");


            // textBoxاظهار بيانات الجدول في 
            textBox_num.DataBindings.Add("text", ds, "SALES.SALE_NO");
          
            // اظهار بيانات الجدول كامل 
            dataGrid_sale.DataSource = ds;
            dataGrid_sale.DataMember = "SALES";
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record", "Delete Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "delete from SALES where SALE_NO =" + textBox_num.Text;

                db.Insert_Update_DeleteDB(query);

                MessageBox.Show("Your Data Deleted");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SALES"].Position = this.BindingContext[ds, "SALES"].Count - 1;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SALES"].Position = 0;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SALES"].Position -= 1;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SALES"].Position += 1;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from SALES", "SALES");
            dataGrid_sale.DataSource = null;
            dataGrid_sale.DataSource = ds;
            dataGrid_sale.DataMember = "SALES";
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            ds = db.SetectDB("select * from SALES where name like '%" + textBox_search.Text + "%'", "SearchSALES");
            dataGrid_sale.DataSource = ds;
            dataGrid_sale.DataMember = "SearchSALES";
        }
    }
}
