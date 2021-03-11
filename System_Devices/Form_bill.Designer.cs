namespace System_Devices
{
    partial class Form_bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_bill));
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label_numCat = new System.Windows.Forms.Label();
            this.label_nameCateg = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox_categ = new System.Windows.Forms.GroupBox();
            this.btn_save_bill = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Quanity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.comboBox_bill = new System.Windows.Forms.ComboBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IdBill = new System.Windows.Forms.TextBox();
            this.control1 = new System_Devices.control();
            this.heder1 = new System_Devices.heder();
            this.groupBox_categ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(487, 62);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 35);
            this.comboBoxCustomer.TabIndex = 44;
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_delet.FlatAppearance.BorderSize = 0;
            this.btn_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_delet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_delet.Image = global::System_Devices.Properties.Resources.icons8_delete_25px;
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.Location = new System.Drawing.Point(1077, 365);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(101, 38);
            this.btn_delet.TabIndex = 50;
            this.btn_delet.Text = "Delete";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_new.Image = global::System_Devices.Properties.Resources.icons8_plus_25px;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(1077, 319);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(101, 38);
            this.btn_new.TabIndex = 49;
            this.btn_new.Text = "       New";
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(1077, 228);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 38);
            this.btn_save.TabIndex = 47;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textBox_num
            // 
            this.textBox_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_num.Location = new System.Drawing.Point(159, 62);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(89, 35);
            this.textBox_num.TabIndex = 3;
            // 
            // label_numCat
            // 
            this.label_numCat.AutoSize = true;
            this.label_numCat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_numCat.Location = new System.Drawing.Point(55, 69);
            this.label_numCat.Name = "label_numCat";
            this.label_numCat.Size = new System.Drawing.Size(61, 21);
            this.label_numCat.TabIndex = 2;
            this.label_numCat.Text = "Bill ID:";
            // 
            // label_nameCateg
            // 
            this.label_nameCateg.AutoSize = true;
            this.label_nameCateg.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_nameCateg.Location = new System.Drawing.Point(326, 69);
            this.label_nameCateg.Name = "label_nameCateg";
            this.label_nameCateg.Size = new System.Drawing.Size(140, 21);
            this.label_nameCateg.TabIndex = 1;
            this.label_nameCateg.Text = "Customer Name :";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_update.Image = global::System_Devices.Properties.Resources.icons8_update_file_filled_25px;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(1077, 272);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 38);
            this.btn_update.TabIndex = 48;
            this.btn_update.Text = "  Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // groupBox_categ
            // 
            this.groupBox_categ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox_categ.Controls.Add(this.btn_save_bill);
            this.groupBox_categ.Controls.Add(this.dateTimePicker1);
            this.groupBox_categ.Controls.Add(this.comboBoxCustomer);
            this.groupBox_categ.Controls.Add(this.label4);
            this.groupBox_categ.Controls.Add(this.textBox_num);
            this.groupBox_categ.Controls.Add(this.label_numCat);
            this.groupBox_categ.Controls.Add(this.label_nameCateg);
            this.groupBox_categ.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_categ.Location = new System.Drawing.Point(341, 91);
            this.groupBox_categ.Name = "groupBox_categ";
            this.groupBox_categ.Size = new System.Drawing.Size(675, 198);
            this.groupBox_categ.TabIndex = 46;
            this.groupBox_categ.TabStop = false;
            this.groupBox_categ.Text = "BILL";
            // 
            // btn_save_bill
            // 
            this.btn_save_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_save_bill.FlatAppearance.BorderSize = 0;
            this.btn_save_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_bill.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_save_bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_save_bill.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_bill.Image")));
            this.btn_save_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_bill.Location = new System.Drawing.Point(521, 154);
            this.btn_save_bill.Name = "btn_save_bill";
            this.btn_save_bill.Size = new System.Drawing.Size(101, 38);
            this.btn_save_bill.TabIndex = 52;
            this.btn_save_bill.Text = "Save";
            this.btn_save_bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save_bill.UseVisualStyleBackColor = false;
            this.btn_save_bill.Click += new System.EventHandler(this.btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 26);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 9, 14, 54, 45, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(55, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bill Date:";
            // 
            // textBox_Quanity
            // 
            this.textBox_Quanity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_Quanity.Location = new System.Drawing.Point(374, 124);
            this.textBox_Quanity.Name = "textBox_Quanity";
            this.textBox_Quanity.Size = new System.Drawing.Size(61, 35);
            this.textBox_Quanity.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(289, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quanity :";
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_price.Location = new System.Drawing.Point(562, 124);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(107, 35);
            this.textBox_price.TabIndex = 12;
            // 
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_total.Location = new System.Drawing.Point(570, 216);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(99, 35);
            this.textBox_total.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_total);
            this.groupBox1.Controls.Add(this.btn_show);
            this.groupBox1.Controls.Add(this.comboBox_bill);
            this.groupBox1.Controls.Add(this.comboBoxDevices);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Quanity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_price);
            this.groupBox1.Controls.Add(this.textBox_total);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(341, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 257);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BILL DETILSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Bill ID:";
            // 
            // btn_total
            // 
            this.btn_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_total.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_total.Location = new System.Drawing.Point(510, 214);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(60, 39);
            this.btn_total.TabIndex = 55;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = false;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_show.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_show.Location = new System.Drawing.Point(502, 122);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(60, 39);
            this.btn_show.TabIndex = 54;
            this.btn_show.Text = "price";
            this.btn_show.UseVisualStyleBackColor = false;
           
            // 
            // comboBox_bill
            // 
            this.comboBox_bill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bill.FormattingEnabled = true;
            this.comboBox_bill.Location = new System.Drawing.Point(94, 53);
            this.comboBox_bill.Name = "comboBox_bill";
            this.comboBox_bill.Size = new System.Drawing.Size(121, 35);
            this.comboBox_bill.TabIndex = 53;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(95, 124);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(121, 35);
            this.comboBoxDevices.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Device:";
            // 
            // textBox_IdBill
            // 
            this.textBox_IdBill.Location = new System.Drawing.Point(625, 295);
            this.textBox_IdBill.Name = "textBox_IdBill";
            this.textBox_IdBill.Size = new System.Drawing.Size(100, 24);
            this.textBox_IdBill.TabIndex = 52;
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(-5, 37);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(263, 663);
            this.control1.TabIndex = 1;
            // 
            // heder1
            // 
            this.heder1.Location = new System.Drawing.Point(1, -1);
            this.heder1.Name = "heder1";
            this.heder1.Size = new System.Drawing.Size(1200, 38);
            this.heder1.TabIndex = 0;
            // 
            // Form_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.textBox_IdBill);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox_categ);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.heder1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_bill";
            this.Text = "Form_supplier";
            this.Load += new System.EventHandler(this.Form_select_Load);
            this.groupBox_categ.ResumeLayout(false);
            this.groupBox_categ.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private heder heder1;
        private control control1;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label_numCat;
        private System.Windows.Forms.Label label_nameCateg;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox_categ;
        private System.Windows.Forms.TextBox textBox_Quanity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save_bill;
        private System.Windows.Forms.TextBox textBox_IdBill;
        private System.Windows.Forms.ComboBox comboBox_bill;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Label label1;
    }
}