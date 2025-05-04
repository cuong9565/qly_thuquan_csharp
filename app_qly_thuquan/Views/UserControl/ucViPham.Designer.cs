namespace qly_thuquan
{
    partial class ucViPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbIdTV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvViPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvThanhVien = new System.Windows.Forms.DataGridView();
            this.cbAddVP = new System.Windows.Forms.ComboBox();
            this.bdsThanhVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsViPham = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUpdateNameVP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateStateVP = new System.Windows.Forms.ComboBox();
            this.nmudUpdateVP = new System.Windows.Forms.NumericUpDown();
            this.nmudAddVP = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudUpdateVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAddVP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xử lý vi phạm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmudAddVP);
            this.groupBox1.Controls.Add(this.nmudUpdateVP);
            this.groupBox1.Controls.Add(this.cbUpdateStateVP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbUpdateNameVP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAddVP);
            this.groupBox1.Controls.Add(this.btnXuLy);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(244, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 221);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txbIdTV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // txbIdTV
            // 
            this.txbIdTV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdTV.Location = new System.Drawing.Point(19, 56);
            this.txbIdTV.Name = "txbIdTV";
            this.txbIdTV.Size = new System.Drawing.Size(141, 30);
            this.txbIdTV.TabIndex = 4;
            this.txbIdTV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbIdTV_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã sinh viên";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(166, 36);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(72, 69);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác  nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Enabled = false;
            this.btnXuLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Location = new System.Drawing.Point(539, 36);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(150, 50);
            this.btnXuLy.TabIndex = 2;
            this.btnXuLy.Text = "Xử lý vi phạm";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(433, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(211, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvViPham);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1000, 349);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách vi phạm";
            // 
            // dtgvViPham
            // 
            this.dtgvViPham.AllowUserToAddRows = false;
            this.dtgvViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvViPham.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvViPham.Location = new System.Drawing.Point(54, 34);
            this.dtgvViPham.MultiSelect = false;
            this.dtgvViPham.Name = "dtgvViPham";
            this.dtgvViPham.RowHeadersWidth = 51;
            this.dtgvViPham.RowTemplate.Height = 24;
            this.dtgvViPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvViPham.Size = new System.Drawing.Size(887, 290);
            this.dtgvViPham.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvThanhVien);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1000, 115);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thành viên";
            // 
            // dtgvThanhVien
            // 
            this.dtgvThanhVien.AllowUserToAddRows = false;
            this.dtgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThanhVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvThanhVien.Location = new System.Drawing.Point(60, 21);
            this.dtgvThanhVien.MultiSelect = false;
            this.dtgvThanhVien.Name = "dtgvThanhVien";
            this.dtgvThanhVien.RowHeadersWidth = 51;
            this.dtgvThanhVien.RowTemplate.Height = 24;
            this.dtgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThanhVien.Size = new System.Drawing.Size(881, 82);
            this.dtgvThanhVien.TabIndex = 10;
            // 
            // cbAddVP
            // 
            this.cbAddVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddVP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddVP.FormattingEnabled = true;
            this.cbAddVP.Items.AddRange(new object[] {
            "Khóa thẻ 1 tháng",
            "Khóa thẻ 2 tháng",
            "Khóa thẻ vĩnh viễn",
            "Bồi thường"});
            this.cbAddVP.Location = new System.Drawing.Point(10, 85);
            this.cbAddVP.Name = "cbAddVP";
            this.cbAddVP.Size = new System.Drawing.Size(162, 25);
            this.cbAddVP.TabIndex = 8;
            this.cbAddVP.SelectedIndexChanged += new System.EventHandler(this.cbAddVP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên vi phạm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mức phạt";
            // 
            // cbUpdateNameVP
            // 
            this.cbUpdateNameVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateNameVP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateNameVP.FormattingEnabled = true;
            this.cbUpdateNameVP.Items.AddRange(new object[] {
            "Khóa thẻ 1 tháng",
            "Khóa thẻ 2 tháng",
            "Khóa thẻ vĩnh viễn",
            "Bồi thường"});
            this.cbUpdateNameVP.Location = new System.Drawing.Point(211, 85);
            this.cbUpdateNameVP.Name = "cbUpdateNameVP";
            this.cbUpdateNameVP.Size = new System.Drawing.Size(162, 25);
            this.cbUpdateNameVP.TabIndex = 8;
            this.cbUpdateNameVP.SelectedIndexChanged += new System.EventHandler(this.cbUpdateNameVP_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên vi phạm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mức phạt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trạng thái";
            // 
            // cbUpdateStateVP
            // 
            this.cbUpdateStateVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateStateVP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateStateVP.FormattingEnabled = true;
            this.cbUpdateStateVP.Items.AddRange(new object[] {
            "Đã xử lý",
            "Chưa xử lý"});
            this.cbUpdateStateVP.Location = new System.Drawing.Point(211, 190);
            this.cbUpdateStateVP.Name = "cbUpdateStateVP";
            this.cbUpdateStateVP.Size = new System.Drawing.Size(162, 25);
            this.cbUpdateStateVP.TabIndex = 11;
            // 
            // nmudUpdateVP
            // 
            this.nmudUpdateVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudUpdateVP.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmudUpdateVP.Location = new System.Drawing.Point(211, 135);
            this.nmudUpdateVP.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmudUpdateVP.Name = "nmudUpdateVP";
            this.nmudUpdateVP.Size = new System.Drawing.Size(162, 27);
            this.nmudUpdateVP.TabIndex = 12;
            // 
            // nmudAddVP
            // 
            this.nmudAddVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudAddVP.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmudAddVP.Location = new System.Drawing.Point(10, 135);
            this.nmudAddVP.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmudAddVP.Name = "nmudAddVP";
            this.nmudAddVP.Size = new System.Drawing.Size(162, 27);
            this.nmudAddVP.TabIndex = 13;
            // 
            // ucViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Name = "ucViPham";
            this.Size = new System.Drawing.Size(1000, 800);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudUpdateVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAddVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvViPham;
        private System.Windows.Forms.BindingSource bdsThanhVien;
        private System.Windows.Forms.BindingSource bdsViPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbIdTV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvThanhVien;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.ComboBox cbAddVP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUpdateStateVP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUpdateNameVP;
        private System.Windows.Forms.NumericUpDown nmudAddVP;
        private System.Windows.Forms.NumericUpDown nmudUpdateVP;
    }
}
