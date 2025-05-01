using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qly_thuquan.Controller;

namespace qly_thuquan
{
    public partial class fThemThanhVien : Form
    {
        ucQlyThanhVien fParent;
        public fThemThanhVien(ucQlyThanhVien fParent)
        {
            InitializeComponent();
            this.fParent = fParent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVienController.getInstance().insert(txbId.Text, txbFName.Text, txbLName.Text, txbEmail.Text, txbPhone.Text);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fParent.load();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
