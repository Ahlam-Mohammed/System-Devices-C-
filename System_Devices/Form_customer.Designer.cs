namespace System_Devices
{
    partial class Form_customer
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dataGrid_cust = new System.Windows.Forms.DataGridView();
            this.groupBox_cust = new System.Windows.Forms.GroupBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.control1 = new System_Devices.control();
            this.heder1 = new System_Devices.heder();
            this.label_phone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cust)).BeginInit();
            this.groupBox_cust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_name.Location = new System.Drawing.Point(221, 90);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(286, 35);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_num
            // 
            this.textBox_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_num.Location = new System.Drawing.Point(221, 44);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(132, 35);
            this.textBox_num.TabIndex = 3;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_num.Location = new System.Drawing.Point(42, 50);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(155, 21);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "Customer Number :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_name.Location = new System.Drawing.Point(49, 97);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(140, 21);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(165, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERS DATA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(425, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 42);
            this.panel1.TabIndex = 25;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_Refresh.Image = global::System_Devices.Properties.Resources.icons8_recurring_appointment_filled_25px;
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(471, 7);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(82, 31);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dataGrid_cust
            // 
            this.dataGrid_cust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGrid_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cust.Location = new System.Drawing.Point(425, 404);
            this.dataGrid_cust.Name = "dataGrid_cust";
            this.dataGrid_cust.RowTemplate.Height = 26;
            this.dataGrid_cust.Size = new System.Drawing.Size(536, 234);
            this.dataGrid_cust.TabIndex = 24;
            // 
            // groupBox_cust
            // 
            this.groupBox_cust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.groupBox_cust.Controls.Add(this.textBox_phone);
            this.groupBox_cust.Controls.Add(this.textBox_title);
            this.groupBox_cust.Controls.Add(this.label_title);
            this.groupBox_cust.Controls.Add(this.textBox_name);
            this.groupBox_cust.Controls.Add(this.textBox_num);
            this.groupBox_cust.Controls.Add(this.label_num);
            this.groupBox_cust.Controls.Add(this.label_name);
            this.groupBox_cust.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_cust.Location = new System.Drawing.Point(332, 87);
            this.groupBox_cust.Name = "groupBox_cust";
            this.groupBox_cust.Size = new System.Drawing.Size(593, 238);
            this.groupBox_cust.TabIndex = 18;
            this.groupBox_cust.TabStop = false;
            this.groupBox_cust.Text = "CUSTOMERS";
            // 
            // textBox_phone
            // 
            this.textBox_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_phone.Location = new System.Drawing.Point(221, 182);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(286, 35);
            this.textBox_phone.TabIndex = 32;
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_title.Location = new System.Drawing.Point(221, 137);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(286, 35);
            this.textBox_title.TabIndex = 33;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_title.Location = new System.Drawing.Point(49, 145);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(130, 21);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Customer Title :";
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(-5, 37);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(263, 663);
            this.control1.TabIndex = 29;
            // 
            // heder1
            // 
            this.heder1.Location = new System.Drawing.Point(1, -1);
            this.heder1.Name = "heder1";
            this.heder1.Size = new System.Drawing.Size(1200, 38);
            this.heder1.TabIndex = 30;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_phone.Location = new System.Drawing.Point(382, 276);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(142, 21);
            this.label_phone.TabIndex = 31;
            this.label_phone.Text = "Customer Phone :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Location = new System.Drawing.Point(941, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 29);
            this.panel2.TabIndex = 64;
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_search.Location = new System.Drawing.Point(0, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(188, 24);
            this.textBox_search.TabIndex = 61;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_search.Image = global::System_Devices.Properties.Resources.icons8_search_25px;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(188, -1);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 30);
            this.btn_search.TabIndex = 62;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_bill.Image = global::System_Devices.Properties.Resources.icons8_bill_25px_1;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(1047, 650);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(129, 38);
            this.btn_bill.TabIndex = 65;
            this.btn_bill.Text = "Add in bill";
            this.btn_bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_first.FlatAppearance.BorderSize = 0;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_first.Image = global::System_Devices.Properties.Resources.icons8_first_30px;
            this.btn_first.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_first.Location = new System.Drawing.Point(587, 326);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(43, 31);
            this.btn_first.TabIndex = 28;
            this.btn_first.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_last.FlatAppearance.BorderSize = 0;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_last.Image = global::System_Devices.Properties.Resources.icons8_last_30px;
            this.btn_last.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_last.Location = new System.Drawing.Point(747, 326);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(43, 31);
            this.btn_last.TabIndex = 27;
            this.btn_last.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_right.FlatAppearance.BorderSize = 0;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_right.Image = global::System_Devices.Properties.Resources.icons8_right_squared_30px;
            this.btn_right.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_right.Location = new System.Drawing.Point(701, 326);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(43, 31);
            this.btn_right.TabIndex = 26;
            this.btn_right.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_left.FlatAppearance.BorderSize = 0;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_left.Image = global::System_Devices.Properties.Resources.icons8_left_squared_30px;
            this.btn_left.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_left.Location = new System.Drawing.Point(638, 326);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(43, 31);
            this.btn_left.TabIndex = 23;
            this.btn_left.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_delet.FlatAppearance.BorderSize = 0;
            this.btn_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_delet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_delet.Image = global::System_Devices.Properties.Resources.icons8_delete_25px;
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.Location = new System.Drawing.Point(961, 255);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(101, 38);
            this.btn_delet.TabIndex = 22;
            this.btn_delet.Text = "Delete";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_new.Image = global::System_Devices.Properties.Resources.icons8_plus_25px;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(961, 209);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(101, 38);
            this.btn_new.TabIndex = 21;
            this.btn_new.Text = "       New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_update.Image = global::System_Devices.Properties.Resources.icons8_update_file_filled_25px;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(961, 162);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 38);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "  Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_save.Image = global::System_Devices.Properties.Resources.icons8_save_25px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(961, 116);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 38);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(961, 332);
            this.maskedTextBox1.Mask = "799999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 24);
            this.maskedTextBox1.TabIndex = 66;
            // 
            // Form_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.heder1);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_cust);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox_cust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_customer";
            this.Text = "Form_customer";
            this.Load += new System.EventHandler(this.Form_customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cust)).EndInit();
            this.groupBox_cust.ResumeLayout(false);
            this.groupBox_cust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_cust;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox_cust;
        private control control1;
        private heder heder1;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}