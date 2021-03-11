namespace System_Devices
{
    partial class Form_queryDevices
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_dvi = new System.Windows.Forms.DataGridView();
            this.groupBox_dev = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.btn_delet = new System.Windows.Forms.Button();
            this.label_num = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.heder1 = new System_Devices.heder();
            this.control1 = new System_Devices.control();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dvi)).BeginInit();
            this.groupBox_dev.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(294, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 42);
            this.panel1.TabIndex = 49;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_Refresh.Image = global::System_Devices.Properties.Resources.icons8_recurring_appointment_filled_25px;
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(822, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(82, 31);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(343, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEVICES DATA";
            // 
            // dataGrid_dvi
            // 
            this.dataGrid_dvi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGrid_dvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_dvi.Location = new System.Drawing.Point(294, 301);
            this.dataGrid_dvi.Name = "dataGrid_dvi";
            this.dataGrid_dvi.RowTemplate.Height = 26;
            this.dataGrid_dvi.Size = new System.Drawing.Size(865, 387);
            this.dataGrid_dvi.TabIndex = 48;
            // 
            // groupBox_dev
            // 
            this.groupBox_dev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.groupBox_dev.Controls.Add(this.textBox_name);
            this.groupBox_dev.Controls.Add(this.textBox_num);
            this.groupBox_dev.Controls.Add(this.label_num);
            this.groupBox_dev.Controls.Add(this.label_name);
            this.groupBox_dev.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_dev.Location = new System.Drawing.Point(278, 43);
            this.groupBox_dev.Name = "groupBox_dev";
            this.groupBox_dev.Size = new System.Drawing.Size(418, 162);
            this.groupBox_dev.TabIndex = 57;
            this.groupBox_dev.TabStop = false;
            this.groupBox_dev.Text = "DEVICES";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_name.Location = new System.Drawing.Point(164, 98);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(223, 35);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_num
            // 
            this.textBox_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_num.Location = new System.Drawing.Point(164, 42);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(77, 35);
            this.textBox_num.TabIndex = 7;
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
            this.btn_delet.Location = new System.Drawing.Point(716, 138);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(101, 38);
            this.btn_delet.TabIndex = 58;
            this.btn_delet.Text = "Delete";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_num.Location = new System.Drawing.Point(24, 50);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(134, 21);
            this.label_num.TabIndex = 6;
            this.label_num.Text = "Device Number :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_name.Location = new System.Drawing.Point(33, 106);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(119, 21);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Device Name :";
            // 
            // heder1
            // 
            this.heder1.Location = new System.Drawing.Point(1, -1);
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
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_first.FlatAppearance.BorderSize = 0;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_first.Image = global::System_Devices.Properties.Resources.icons8_first_30px;
            this.btn_first.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_first.Location = new System.Drawing.Point(602, 223);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(43, 31);
            this.btn_first.TabIndex = 52;
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
            this.btn_last.Location = new System.Drawing.Point(762, 223);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(43, 31);
            this.btn_last.TabIndex = 51;
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
            this.btn_right.Location = new System.Drawing.Point(716, 223);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(43, 31);
            this.btn_right.TabIndex = 50;
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
            this.btn_left.Location = new System.Drawing.Point(653, 223);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(43, 31);
            this.btn_left.TabIndex = 47;
            this.btn_left.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(911, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 29);
            this.panel2.TabIndex = 65;
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_search.Location = new System.Drawing.Point(0, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(188, 24);
            this.textBox_search.TabIndex = 61;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.button1.Image = global::System_Devices.Properties.Resources.icons8_search_25px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(188, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 62;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_queryDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox_dev);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_dvi);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.heder1);
            this.Controls.Add(this.control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_queryDevices";
            this.Text = "Form_queryDevices";
            this.Load += new System.EventHandler(this.Form_queryDevices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dvi)).EndInit();
            this.groupBox_dev.ResumeLayout(false);
            this.groupBox_dev.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private control control1;
        private heder heder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_dvi;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.GroupBox groupBox_dev;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button1;
    }
}