using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qly_thuquan
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
            btnHome.Click += (s, e) => showUserControl(new ucTrangChu());
            btnQlyThanhVien.Click += (s, e) => showUserControl(new ucQlyThanhVien());
            btnQlyThietBi.Click += (s, e) => showUserControl(new ucQlyThietBi());
            btnMuonThietBi.Click += (s, e) => showUserControl(new ucMuonDatCho());
            btnThongKe.Click += (s, e) => showUserControl(new ucThongKe());
            btnVaoThuQuan.Click += (s, e) => showUserControl(new ucVaoThuQuan());
            btnViPham.Click += (s, e) => showUserControl(new ucViPham());
            btnHistoryLogin.Click += (s, e) => showUserControl(new ucHistoryLogin());
        }
        private void showUserControl(UserControl uc)
        {
            pnLeft.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnLeft.Controls.Add(uc);
        }
    }
}
