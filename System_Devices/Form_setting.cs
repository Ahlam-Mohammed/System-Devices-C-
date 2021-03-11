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
    public partial class Form_setting : Form
    {
        ClassDB2 db;
        DataSet ds;
        public Form_setting()
        {
            InitializeComponent();
        }

        private void Form_setting_Load(object sender, EventArgs e)
        {
            db = new ClassDB2();
            ds = new DataSet();
            db.ConnectDb();
            ds = db.SetectDB("select * from login ", "login");

            textBox_num.DataBindings.Add("text", ds, "login.ID");
            textBox_name.DataBindings.Add("text", ds, "login.name");
            textBox_pass.DataBindings.Add("text", ds, "login.password");
            // textBox_img.DataBindings.Add("text", ds, "login.img");
          //  picture_user.Image = Image.FromFile("../../Upload/" + textBox_img.Text);

            dataGrid_user.DataSource = ds;
            dataGrid_user.DataMember = "login";
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
           // string Fullpath, SubPath;
           // openFileDialog1.Title = "Select Image";
           // openFileDialog1.Filter = "Image File |*.jpg|Jpge|*.jpge|Gif|*.gif";
             
           //if(openFileDialog1.ShowDialog() == DialogResult.OK)
           // {
           //    //label2.Text = openFileDialog1.FileName;
           //     Fullpath= openFileDialog1.FileName;
           //     SubPath = Fullpath.Substring( Fullpath.LastIndexOf(@"\")+1);
           //     picture_user.Image = Image.FromFile(Fullpath);
           //     picture_user.Image.Save("../../Upload/" + SubPath);
           //     textBox_img.Text = SubPath;
           // }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            string query = "insert into login(name,password) values ('"+ textBox_name.Text+"','"+textBox_pass.Text+"')";
            db.Insert_Update_DeleteDB(query);
            MessageBox.Show("Your Data Saved");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "update login set name ='" + textBox_name.Text + "',password='" + textBox_pass.Text + "' where ID=" + textBox_num.Text;

            db.Insert_Update_DeleteDB(query);

            MessageBox.Show("Your Data Updated");
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            BindingContext[ds, "login"].AddNew();
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record", "Delete Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "delete from login where ID =" + textBox_num.Text;

                db.Insert_Update_DeleteDB(query);

                MessageBox.Show("Your Data Deleted");
            }
        }
    }
}
