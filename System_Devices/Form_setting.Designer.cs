namespace System_Devices
{
    partial class Form_setting
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
            this.control1 = new System_Devices.control();
            this.heder1 = new System_Devices.heder();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dataGrid_user = new System.Windows.Forms.DataGridView();
            this.groupBox_user = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_img = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_user)).BeginInit();
            this.groupBox_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(-5, 37);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(263, 663);
            this.control1.TabIndex = 0;
            // 
            // heder1
            // 
            this.heder1.Location = new System.Drawing.Point(1, -1);
            this.heder1.Name = "heder1";
            this.heder1.Size = new System.Drawing.Size(1200, 38);
            this.heder1.TabIndex = 1;
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_pass.Location = new System.Drawing.Point(221, 137);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(286, 35);
            this.textBox_pass.TabIndex = 33;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_title.Location = new System.Drawing.Point(49, 145);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(97, 21);
            this.label_title.TabIndex = 5;
            this.label_title.Text = " Password :";
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
            this.label_num.Size = new System.Drawing.Size(118, 21);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "User Number :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_name.Location = new System.Drawing.Point(49, 97);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(103, 21);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(194, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERS DATA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(429, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 42);
            this.panel1.TabIndex = 43;
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
            // 
            // dataGrid_user
            // 
            this.dataGrid_user.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGrid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_user.Location = new System.Drawing.Point(429, 403);
            this.dataGrid_user.Name = "dataGrid_user";
            this.dataGrid_user.RowTemplate.Height = 26;
            this.dataGrid_user.Size = new System.Drawing.Size(536, 234);
            this.dataGrid_user.TabIndex = 42;
            // 
            // groupBox_user
            // 
            this.groupBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.groupBox_user.Controls.Add(this.textBox_pass);
            this.groupBox_user.Controls.Add(this.label_title);
            this.groupBox_user.Controls.Add(this.textBox_name);
            this.groupBox_user.Controls.Add(this.textBox_num);
            this.groupBox_user.Controls.Add(this.label_num);
            this.groupBox_user.Controls.Add(this.label_name);
            this.groupBox_user.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_user.Location = new System.Drawing.Point(384, 55);
            this.groupBox_user.Name = "groupBox_user";
            this.groupBox_user.Size = new System.Drawing.Size(528, 206);
            this.groupBox_user.TabIndex = 36;
            this.groupBox_user.TabStop = false;
            this.groupBox_user.Text = "USER";
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_select.Image = global::System_Devices.Properties.Resources.icons8_edit_file_30px_1;
            this.btn_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_select.Location = new System.Drawing.Point(151, 3);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(43, 31);
            this.btn_select.TabIndex = 49;
            this.btn_select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // picture_user
            // 
            this.picture_user.Location = new System.Drawing.Point(11, 23);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(169, 162);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_user.TabIndex = 48;
            this.picture_user.TabStop = false;
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
            this.btn_delet.Location = new System.Drawing.Point(811, 291);
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
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_new.Image = global::System_Devices.Properties.Resources.icons8_plus_25px;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(701, 289);
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
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_update.Image = global::System_Devices.Properties.Resources.icons8_update_file_filled_25px;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(592, 289);
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
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_save.Image = global::System_Devices.Properties.Resources.icons8_save_25px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(485, 289);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 38);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_img
            // 
            this.textBox_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_img.Location = new System.Drawing.Point(1018, 499);
            this.textBox_img.Name = "textBox_img";
            this.textBox_img.ReadOnly = true;
            this.textBox_img.Size = new System.Drawing.Size(153, 24);
            this.textBox_img.TabIndex = 34;
            this.textBox_img.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.btn_select);
            this.panel2.Controls.Add(this.picture_user);
            this.panel2.Location = new System.Drawing.Point(977, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 192);
            this.panel2.TabIndex = 50;
            // 
            // Form_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.textBox_img);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_user);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.groupBox_user);
            this.Controls.Add(this.heder1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_setting";
            this.Load += new System.EventHandler(this.Form_setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_user)).EndInit();
            this.groupBox_user.ResumeLayout(false);
            this.groupBox_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private control control1;
        private heder heder1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_user;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox_user;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_img;
        private System.Windows.Forms.Panel panel2;
    }
}