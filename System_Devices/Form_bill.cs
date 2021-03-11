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
    public partial class Form_bill : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_bill()
        {
            InitializeComponent();
        }

        private void Form_select_Load(object sender, EventArgs e)
        {
            db = new ClassDB2();
            ds = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            DataSet ds4 = new DataSet();
            db.ConnectDb();

            ds = db.SetectDB("select * from DEVICES ", "DEVICES");
            ds2 = db.SetectDB("select * from BILL_SALES_TABLE", "BILL_SALES_TABLE");
            ds3 = db.SetectDB("select * from CUSTOMER ", "CUSTOMER");
         //   ds4 = db.SetectDB("select * from BILL_SALES_TABLE ", "BILL_SALES_TABLE");

            comboBoxDevices.DataSource = ds;
            comboBoxDevices.DisplayMember = "DEVICES.name";
            comboBoxDevices.ValueMember = "DEVICES.id";

            comboBoxCustomer.DataSource = ds3;
            comboBoxCustomer.DisplayMember = "CUSTOMER.name";
            comboBoxCustomer.ValueMember = "CUSTOMER.id";

            comboBox_bill.DataSource = ds2;
         //   comboBox_bill.DisplayMember = "BILL_SALES_TABLE.name";
            comboBox_bill.ValueMember = "BILL_SALES_TABLE.BILL_SALES_NO";


           
            //ds4 = db.SetectDB("select MAX(BILL_SALES_NO) from BILL_SALES_TABLE", "BILL_SALES_TABLE");
            //textBox_IdBill.DataBindings.Add("text", ds4, "BILL_SALES_NO");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            // DataSet ds4 = new DataSet();
            // ds4 = db.SetectDB("select MAX(BILL_SALES_NO) from BILL_SALES_TABLE", "id_BILL");
            //textBox_IdBill.DataBindings.Add("text", ds4, "id_BILL");


            string query2 = "insert into SALES ( DEVICE_NO , QUANITY , BILL_SALE_NO ) values(" + comboBoxDevices.SelectedValue + "," + textBox_Quanity.Text + ","+ comboBox_bill.SelectedValue+ ")";
            db.Insert_Update_DeleteDB(query2);
            MessageBox.Show("Your Data Saved");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string query1 = "insert into BILL_SALES_TABLE (BILL_DATE , CUSTOMER_NO) values('" + dateTimePicker1.Value + "'," + comboBoxCustomer.SelectedValue + ")";
            db.Insert_Update_DeleteDB(query1);
           
            MessageBox.Show("Your Data Saved");
        }

        
    }
}
