namespace System_Devices
{
    partial class Form_categ
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
            this.groupBox_categ = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label_numCat = new System.Windows.Forms.Label();
            this.label_nameCateg = new System.Windows.Forms.Label();
            this.dataGrid_cat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.control1 = new System_Devices.control();
            this.heder1 = new System_Devices.heder();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox_categ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_categ
            // 
            this.groupBox_categ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox_categ.Controls.Add(this.textBox_name);
            this.groupBox_categ.Controls.Add(this.textBox_num);
            this.groupBox_categ.Controls.Add(this.label_numCat);
            this.groupBox_categ.Controls.Add(this.label_nameCateg);
            this.groupBox_categ.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_categ.Location = new System.Drawing.Point(381, 142);
            this.groupBox_categ.Name = "groupBox_categ";
            this.groupBox_categ.Size = new System.Drawing.Size(577, 189);
            this.groupBox_categ.TabIndex = 2;
            this.groupBox_categ.TabStop = false;
            this.groupBox_categ.Text = "CATEGROIES";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_name.Location = new System.Drawing.Point(240, 115);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(286, 35);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_num
            // 
            this.textBox_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBox_num.Location = new System.Drawing.Point(240, 61);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(132, 35);
            this.textBox_num.TabIndex = 3;
            // 
            // label_numCat
            // 
            this.label_numCat.AutoSize = true;
            this.label_numCat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_numCat.Location = new System.Drawing.Point(61, 67);
            this.label_numCat.Name = "label_numCat";
            this.label_numCat.Size = new System.Drawing.Size(150, 21);
            this.label_numCat.TabIndex = 2;
            this.label_numCat.Text = "Category Number :";
            // 
            // label_nameCateg
            // 
            this.label_nameCateg.AutoSize = true;
            this.label_nameCateg.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_nameCateg.Location = new System.Drawing.Point(68, 122);
            this.label_nameCateg.Name = "label_nameCateg";
            this.label_nameCateg.Size = new System.Drawing.Size(135, 21);
            this.label_nameCateg.TabIndex = 1;
            this.label_nameCateg.Text = "Category Name :";
            // 
            // dataGrid_cat
            // 
            this.dataGrid_cat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGrid_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cat.Location = new System.Drawing.Point(465, 438);
            this.dataGrid_cat.Name = "dataGrid_cat";
            this.dataGrid_cat.RowTemplate.Height = 26;
            this.dataGrid_cat.Size = new System.Drawing.Size(490, 234);
            this.dataGrid_cat.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(465, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 42);
            this.panel1.TabIndex = 14;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_Refresh.Image = global::System_Devices.Properties.Resources.icons8_recurring_appointment_filled_25px;
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(451, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(36, 31);
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
            this.label1.Location = new System.Drawing.Point(131, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGROIES DATA";
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(-5, 37);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(263, 663);
            this.control1.TabIndex = 4;
            // 
            // heder1
            // 
            this.heder1.Location = new System.Drawing.Point(1, -1);
            this.heder1.Name = "heder1";
            this.heder1.Size = new System.Drawing.Size(1200, 38);
            this.heder1.TabIndex = 3;
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
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_first.FlatAppearance.BorderSize = 0;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btn_first.Image = global::System_Devices.Properties.Resources.icons8_first_30px;
            this.btn_first.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_first.Location = new System.Drawing.Point(612, 350);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(43, 31);
            this.btn_first.TabIndex = 17;
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
            this.btn_last.Location = new System.Drawing.Point(772, 350);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(43, 31);
            this.btn_last.TabIndex = 16;
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
            this.btn_right.Location = new System.Drawing.Point(726, 350);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(43, 31);
            this.btn_right.TabIndex = 15;
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
            this.btn_left.Location = new System.Drawing.Point(663, 350);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(43, 31);
            this.btn_left.TabIndex = 12;
            this.btn_left.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Location = new System.Drawing.Point(916, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 29);
            this.panel2.TabIndex = 63;
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
            this.btn_delet.Location = new System.Drawing.Point(1003, 281);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(101, 38);
            this.btn_delet.TabIndex = 67;
            this.btn_delet.Text = "Delete";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click_1);
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
            this.btn_new.Location = new System.Drawing.Point(1003, 235);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(101, 38);
            this.btn_new.TabIndex = 66;
            this.btn_new.Text = "       New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click_1);
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
            this.btn_update.Location = new System.Drawing.Point(1003, 188);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 38);
            this.btn_update.TabIndex = 65;
            this.btn_update.Text = "  Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
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
            this.btn_save.Location = new System.Drawing.Point(1003, 142);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 38);
            this.btn_save.TabIndex = 64;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // Form_categ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_cat);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.heder1);
            this.Controls.Add(this.groupBox_categ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_categ";
            this.Load += new System.EventHandler(this.Form_categ_Load);
            this.groupBox_categ.ResumeLayout(false);
            this.groupBox_categ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_categ;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label_numCat;
        private System.Windows.Forms.Label label_nameCateg;
        private heder heder1;
        private control control1;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.DataGridView dataGrid_cat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
    }
}