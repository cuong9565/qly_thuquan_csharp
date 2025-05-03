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
using qly_thuquan.Controllers;
using qly_thuquan.Model;
using qly_thuquan.Models;

namespace qly_thuquan
{
    public partial class ucVaoThuQuan : UserControl
    {
        public ucVaoThuQuan()
        {
            InitializeComponent();

            load();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id = txbTypeId.Text;
            try
            {
                // Kiem tra co tai khoan khong khong
                ThanhVien tv = ThanhVienController.getInstance().getById(id);
                DateTime dt = DateTime.Now;

                // Kiem tra co vi pham khong
                if (false)
                {
                    return;
                }

                // Nếu mà đúng
                VaoTQController.getInstance().insert(tv.GetId(), dt);
                load();
                txbId.Text = tv.GetId();
                txbLName.Text = tv.GetlName();
                txbFName.Text = tv.GetfName();
                txbEmail.Text = tv.GetEmail();
                txbPhone.Text = tv.GetPhone();
                txbDateCreate.Text = tv.GetDateCreate().ToString("dd/MM/yyyy");
                txbTime.Text = dt.ToString("dd/MM/yyyy hh:mm:ss tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load()
        {
            txbTypeId.Text = "";
            txbId.Text = "";
            txbLName.Text = "";
            txbFName.Text = "";
            txbEmail.Text = "";
            txbPhone.Text = "";
            txbDateCreate.Text = "";
            txbTime.Text = "";
        }

        private void txbTypeId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnConfirm_Click(null, null);
            }
        }
    }
}
