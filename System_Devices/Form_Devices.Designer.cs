namespace System_Devices
{
    partial class Form_Devices
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
            this.label_phone = new System.Windows.Forms.Label();
            this.groupBox_dev = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_man = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_issus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dasc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.textBox_sales = new System.Windows.Forms.TextBox();
            this.openFileDialog_device = new System.Windows.Forms.OpenFileDialog();
            this.heder1 = new System_Devices.heder();
            this.control1 = new System_Devices.control();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox_dev.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_name.Location = new System.Drawing.Point(157, 100);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(223, 35);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_num
            // 
            this.textBox_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_num.Location = new System.Drawing.Point(157, 44);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(77, 35);
            this.textBox_num.TabIndex = 3;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_num.Location = new System.Drawing.Point(17, 52);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(134, 21);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "Device Number :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_name.Location = new System.Drawing.Point(26, 108);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(119, 21);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Device Name :";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_phone.Location = new System.Drawing.Point(386, 108);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(101, 21);
            this.label_phone.TabIndex = 47;
            this.label_phone.Text = "Price Sales :";
            // 
            // groupBox_dev
            // 
            this.groupBox_dev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.groupBox_dev.Controls.Add(this.label1);
            this.groupBox_dev.Controls.Add(this.textBox_man);
            this.groupBox_dev.Controls.Add(this.label5);
            this.groupBox_dev.Controls.Add(this.textBox_issus);
            this.groupBox_dev.Controls.Add(this.label4);
            this.groupBox_dev.Controls.Add(this.btn_delet);
            this.groupBox_dev.Controls.Add(this.textBox_type);
            this.groupBox_dev.Controls.Add(this.btn_new);
            this.groupBox_dev.Controls.Add(this.label3);
            this.groupBox_dev.Controls.Add(this.btn_update);
            this.groupBox_dev.Controls.Add(this.textBox_dasc);
            this.groupBox_dev.Controls.Add(this.btn_save);
            this.groupBox_dev.Controls.Add(this.label2);
            this.groupBox_dev.Controls.Add(this.comboBoxCategories);
            this.groupBox_dev.Controls.Add(this.textBox_sales);
            this.groupBox_dev.Controls.Add(this.label_phone);
            this.groupBox_dev.Controls.Add(this.textBox_name);
            this.groupBox_dev.Controls.Add(this.textBox_num);
            this.groupBox_dev.Controls.Add(this.label_num);
            this.groupBox_dev.Controls.Add(this.label_name);
            this.groupBox_dev.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_dev.Location = new System.Drawing.Point(377, 85);
            this.groupBox_dev.Name = "groupBox_dev";
            this.groupBox_dev.Size = new System.Drawing.Size(689, 367);
            this.groupBox_dev.TabIndex = 36;
            this.groupBox_dev.TabStop = false;
            this.groupBox_dev.Text = "DEVICES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(314, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Category :";
            // 
            // textBox_man
            // 
            this.textBox_man.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_man.Location = new System.Drawing.Point(493, 203);
            this.textBox_man.Name = "textBox_man";
            this.textBox_man.Size = new System.Drawing.Size(148, 35);
            this.textBox_man.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(365, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Manufacture :";
            // 
            // textBox_issus
            // 
            this.textBox_issus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_issus.Location = new System.Drawing.Point(157, 203);
            this.textBox_issus.Name = "textBox_issus";
            this.textBox_issus.Size = new System.Drawing.Size(149, 35);
            this.textBox_issus.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(75, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Issus :";
            // 
            // textBox_type
            // 
            this.textBox_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_type.Location = new System.Drawing.Point(493, 156);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(94, 35);
            this.textBox_type.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(414, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Type :";
            // 
            // textBox_dasc
            // 
            this.textBox_dasc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_dasc.Location = new System.Drawing.Point(157, 156);
            this.textBox_dasc.Name = "textBox_dasc";
            this.textBox_dasc.Size = new System.Drawing.Size(223, 35);
            this.textBox_dasc.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Description :";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxCategories.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(418, 44);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(168, 29);
            this.comboBoxCategories.TabIndex = 48;
            // 
            // textBox_sales
            // 
            this.textBox_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_sales.Location = new System.Drawing.Point(493, 100);
            this.textBox_sales.Name = "textBox_sales";
            this.textBox_sales.Size = new System.Drawing.Size(94, 35);
            this.textBox_sales.TabIndex = 35;
            // 
            // openFileDialog_device
            // 
            this.openFileDialog_device.FileName = "openFileDialog1";
            // 
            // heder1
            // 
            this.heder1.Location = new System.Drawing.Point(0, -1);
            this.heder1.Name = "heder1";
            this.heder1.Size = new System.Drawing.Size(1200, 38);
            this.heder1.TabIndex = 1;
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(-5, 37);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(263, 663);
            this.control1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button1.Image = global::System_Devices.Properties.Resources.icons8_database_import_filled_25px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1027, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 38);
            this.button1.TabIndex = 61;
            this.button1.Text = "Query Devices";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_first.FlatAppearance.BorderSize = 0;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_first.Image = global::System_Devices.Properties.Resources.icons8_first_30px;
            this.btn_first.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_first.Location = new System.Drawing.Point(761, 62);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(43, 31);
            this.btn_first.TabIndex = 46;
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
            this.btn_last.Location = new System.Drawing.Point(921, 62);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(43, 31);
            this.btn_last.TabIndex = 45;
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
            this.btn_right.Location = new System.Drawing.Point(875, 62);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(43, 31);
            this.btn_right.TabIndex = 44;
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
            this.btn_left.Location = new System.Drawing.Point(812, 62);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(43, 31);
            this.btn_left.TabIndex = 41;
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
            this.btn_delet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_delet.Image = global::System_Devices.Properties.Resources.icons8_delete_25px;
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.Location = new System.Drawing.Point(463, 308);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(101, 38);
            this.btn_delet.TabIndex = 40;
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
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_new.Image = global::System_Devices.Properties.Resources.icons8_plus_25px;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(345, 308);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(101, 38);
            this.btn_new.TabIndex = 39;
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
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_update.Image = global::System_Devices.Properties.Resources.icons8_update_file_filled_25px;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(224, 308);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 38);
            this.btn_update.TabIndex = 38;
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
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_save.Image = global::System_Devices.Properties.Resources.icons8_save_filled_30px_1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(98, 308);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 38);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.groupBox_dev);
            this.Controls.Add(this.heder1);
            this.Controls.Add(this.control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Devices";
            this.Load += new System.EventHandler(this.Form_Devices_Load);
            this.groupBox_dev.ResumeLayout(false);
            this.groupBox_dev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private control control1;
        private heder heder1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox_dev;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox textBox_sales;
        private System.Windows.Forms.TextBox textBox_man;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_issus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dasc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_device;
        private System.Windows.Forms.Button button1;
    }
}