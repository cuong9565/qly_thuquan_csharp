namespace qly_thuquan
{
    partial class ucHistoryLogin
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvVaoTQ = new System.Windows.Forms.DataGridView();
            this.bds = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVaoTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 100);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử vào thư quán";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSearch);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1000, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "MSSV",
            "Họ",
            "Tên",
            "Ngày đăng ký",
            "Email",
            "Số điện thoại",
            "Thời gian vào"});
            this.cbSearch.Location = new System.Drawing.Point(50, 35);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(150, 27);
            this.cbSearch.TabIndex = 7;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.textSearchChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(210, 35);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(200, 30);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.TextChanged += new System.EventHandler(this.textSearchChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(420, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvVaoTQ);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 600);
            this.panel3.TabIndex = 10;
            // 
            // dtgvVaoTQ
            // 
            this.dtgvVaoTQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvVaoTQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVaoTQ.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvVaoTQ.Location = new System.Drawing.Point(50, 50);
            this.dtgvVaoTQ.MultiSelect = false;
            this.dtgvVaoTQ.Name = "dtgvVaoTQ";
            this.dtgvVaoTQ.RowHeadersWidth = 51;
            this.dtgvVaoTQ.RowTemplate.Height = 24;
            this.dtgvVaoTQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVaoTQ.Size = new System.Drawing.Size(900, 488);
            this.dtgvVaoTQ.TabIndex = 0;
            // 
            // ucHistoryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Name = "ucHistoryLogin";
            this.Size = new System.Drawing.Size(1000, 800);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVaoTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvVaoTQ;
        private System.Windows.Forms.BindingSource bds;
    }
}
