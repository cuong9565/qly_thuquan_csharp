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
    public partial class fSuaThietBi : Form
    {
        ucQlyThietBi fParent;
        ThietBi tb;
        public fSuaThietBi(ucQlyThietBi fParent, ThietBi tb)
        {
            InitializeComponent();
            this.fParent = fParent;
            this.tb = tb;
            txbId.Text = tb.getId() + "";
            txbName.Text = tb.getName() + "";
            cbbState.Text = tb.getState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ThietBiController.getInstance().update(txbId.Text, txbName.Text, cbbState.SelectedItem.ToString());
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
