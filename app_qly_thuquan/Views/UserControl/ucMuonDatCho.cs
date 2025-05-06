using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qly_thuquan.Controllers;
using qly_thuquan.Models;

namespace qly_thuquan
{
    public partial class ucMuonDatCho : UserControl
    {
        public ucMuonDatCho()
        {
            InitializeComponent();
            dtgvMuonTra.DataSource = bds;
            load();
        }
        public void load()
        {
            try
            {
                bds.DataSource = MuonTraTBController.getInstance().LoadDataTable();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            checkBox1_CheckedChanged(null, null);
        }

        private void btnConfirmMuon_Click(object sender, EventArgs e)
        {
            try
            {
                string idTV = txbIdTVMuon.Text;
                string idTB = txbIdTBMuon.Text;
                MuonTraTBController.getInstance().Muon(idTV, idTB);
                txbIdTBMuon.Text = "";
                txbIdTVMuon.Text = "";
                MessageBox.Show("Đã ghi nhận thời gian mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmTra_Click(object sender, EventArgs e)
        {
            try
            {
                string idTB = txbIdTBTra.Text;
                MuonTraTBController.getInstance().Tra(idTB);
                txbIdTBTra.Text = "";
                MessageBox.Show("Đã ghi nhận thời gian trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            if (checkBox1.Checked) ls.Add($"[Trạng thái] = '{checkBox1.Text}'");
            if (checkBox2.Checked) ls.Add($"[Trạng thái] = '{checkBox2.Text}'");
            if (checkBox3.Checked) ls.Add($"[Trạng thái] = '{checkBox3.Text}'");
            if (checkBox4.Checked) ls.Add($"[Trạng thái] = '{checkBox4.Text}'");
            if(ls.Count > 0) bds.Filter = string.Join(" OR ", ls);
            else bds.Filter = "";
        }
    }
}
