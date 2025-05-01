using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx;
using OfficeOpenXml;
using qly_thuquan.Controller;
using qly_thuquan.Model;

namespace qly_thuquan
{
    public partial class ucQlyThietBi : UserControl
    {
        public ucQlyThietBi()
        {
            InitializeComponent();
            cbSearch.SelectedIndex = 0;
            dtgvThietBi.DataSource = bds;
            load();
        }

        public void load()
        {
            try
            {
                bds.DataSource = ThietBiController.getInstance().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txbSearch_TextChanged(null, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemThietBi f = new fThemThietBi(this);
            f.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = dtgvThietBi.SelectedRows[0].Index;
            if (row >= 0)
            {
                string id = (string)dtgvThietBi.Rows[row].Cells[0].Value;
                ThietBi tb = ThietBiController.getInstance().getById(id);
                fSuaThietBi f = new fSuaThietBi(this, tb);
                f.ShowDialog();
            }
            else MessageBox.Show("Vui lòng chọn thông tin cần đổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = dtgvThietBi.SelectedRows[0].Index;
            if (row >= 0)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string id = (string)dtgvThietBi.Rows[row].Cells[0].Value;
                    ThietBiController.getInstance().delete(id);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            else MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (ofdImportExcel.ShowDialog() == DialogResult.OK)
            {
                DialogResult choose = MessageBox.Show("Bạn có chắc muốn nhập thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choose == DialogResult.Yes)
                {
                    int res = 0;
                    StringBuilder error = new StringBuilder();
                    FileInfo fileInfo = new FileInfo(ofdImportExcel.FileName);

                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int m = worksheet.Dimension.End.Row;
                        int n = worksheet.Dimension.End.Column;
                        for (int i = 3; i <= m; i++)
                        {
                            try
                            {
                                string id = worksheet.Cells[i, 1].Text;
                                string name = worksheet.Cells[i, 2].Text;
                                ThietBiController.getInstance().insert(id, name);
                                res++;
                            }
                            catch (Exception ex)
                            {
                                error.AppendLine(ex.Message);
                            }
                        }
                    }
                    if (error.Length > 0) MessageBox.Show(error.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show($"Đã thêm {res} thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbSearch.Text = "";
            cbSearch.SelectedIndex = 0;
            load();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txbSearch.Text.Trim();
            string col = cbSearch.SelectedItem.ToString();
            bds.Filter = $"[{col}] like '%{txt}%'";
        }

        private void btnDeleteMore_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    int res = ThietBiController.getInstance().deleteByTopId(txbDeleteMore.Text);
                    MessageBox.Show($"Đã xóa {res} thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbDeleteMore.Text = "";
                    load();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
