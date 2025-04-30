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
using qly_thuquan.Model;

namespace qly_thuquan
{
    public partial class fSuaThanhVien : Form
    {
        ucQlyThanhVien fParent;
        ThanhVien tv;
        public fSuaThanhVien(ucQlyThanhVien fParent, ThanhVien tv)
        {
            InitializeComponent();
            this.fParent = fParent;
            this.tv = tv;
            txbId.Text = tv.GetId().ToString();
            txbFName.Text = tv.GetfName();
            txbLName.Text = tv.GetlName();
            txbDateCreate.Text = tv.GetDateCreate().ToString("dd/MM/yyyy");
            txbEmail.Text = tv.GetEmail();
            txbPhone.Text = tv.GetPhone();
            txbPassword.Text = tv.GetPassword();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVienController.getInstance().update(int.Parse(txbId.Text), txbFName.Text, txbLName.Text, txbEmail.Text, txbPhone.Text);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fParent.load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
