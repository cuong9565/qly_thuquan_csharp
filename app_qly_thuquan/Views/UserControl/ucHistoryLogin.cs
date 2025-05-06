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
    public partial class ucHistoryLogin : UserControl
    {
        public ucHistoryLogin()
        {
            InitializeComponent();
            dtgvVaoTQ.DataSource = bds;
            cbSearch.SelectedIndex = 0;
            load();
        }
        public void load()
        {
            try
            {
                bds.DataSource = VaoTQController.getInstance().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textSearchChanged(null, null);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbSearch.Text = "";
            cbSearch.SelectedIndex = 0;
            load();
        }
        private void textSearchChanged(object sender, EventArgs e)
        {
            string txt = txbSearch.Text.Trim();
            string col = cbSearch.SelectedItem.ToString();
            bds.Filter = $"CONVERT([{col}], 'System.String') LIKE '%{txt}%'";
        }
    }
}
