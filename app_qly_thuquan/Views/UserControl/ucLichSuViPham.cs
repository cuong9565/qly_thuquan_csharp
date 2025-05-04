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
    public partial class ucLichSuViPham : UserControl
    {
        public ucLichSuViPham()
        {
            InitializeComponent();
            cbSearch.SelectedIndex = 0;

            dtgvThanhVien.DataSource = bdsThanhVien;
            dtgvViPham.DataSource = bdsViPham;

            dtgvThanhVien.SelectionChanged += (s, e) =>
            {
                string idTV = "";
                if (dtgvThanhVien.RowCount > 0)
                    idTV = (string)dtgvThanhVien.CurrentRow.Cells[0].Value;
                loadVP(idTV);
            };
            
            load();
        }
        public void load()
        {
            try
            {
                bdsThanhVien.DataSource = ThanhVienController.getInstance().getAll();            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txbSearch_TextChanged(null, null);
        }
        public void loadVP(string idTV)
        {
            try
            {
                bdsViPham.DataSource = ViPhamController.getInstance().loadByIdTV(idTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            txbSearch.Text = "";
            load();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txbSearch.Text.Trim();
            string col = cbSearch.SelectedItem.ToString();
            bdsThanhVien.Filter = $"[{col}] like '%{txt}%'";
        }
    }
}
