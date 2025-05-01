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
using System.Windows.Input;
using OfficeOpenXml;
using qly_thuquan.Controller;
using qly_thuquan.Model;


namespace qly_thuquan
{
    public partial class ucQlyThanhVien : UserControl
    {
        public ucQlyThanhVien()
        {
            InitializeComponent();
            cbSearch.SelectedIndex = 0;
            dtgvThanhVien.DataSource = bds;
            load();
        }

        public void load()
        {
            try
            {
                bds.DataSource = ThanhVienController.getInstance().getAll();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textSearchChanged(null, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemThanhVien f = new fThemThanhVien(this);
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = dtgvThanhVien.SelectedRows[0].Index;
            if (row >= 0)
            {
                string id = (string) dtgvThanhVien.Rows[row].Cells[0].Value;
                ThanhVien tv = ThanhVienController.getInstance().getById(id);
                fSuaThanhVien f = new fSuaThanhVien(this, tv);
                f.ShowDialog();
            }
            else MessageBox.Show("Vui lòng chọn thông tin cần đổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = dtgvThanhVien.SelectedRows[0].Index;
            if (row >= 0)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string id = (string)dtgvThanhVien.Rows[row].Cells[0].Value;
                    ThanhVienController.getInstance().delete(id);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            else MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteByYear_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult choose = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choose == DialogResult.Yes)
                {
                    int year = int.Parse(txbYear.Text);
                    int res = ThanhVienController.getInstance().deleteByYear(year);
                    MessageBox.Show($"Xóa thành công {res} thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbYear.Text = "";
                    load();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        for (int i = 3; i<=m; i++)
                        {
                            try
                            {
                                string id = worksheet.Cells[i, 1].Text;
                                string lName = worksheet.Cells[i, 2].Text;
                                string fName = worksheet.Cells[i, 3].Text;
                                string email = worksheet.Cells[i, 4].Text;
                                string phone = worksheet.Cells[i, 5].Text;
                                ThanhVienController.getInstance().insert(id, lName, fName, email, phone);
                                res++;
                            }
                            catch (Exception ex)
                            {
                                error.AppendLine(ex.Message);
                            }
                        }
                    }
                    if (error.Length>0) MessageBox.Show(error.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textSearchChanged(object sender, EventArgs e)
        {
            string txt = txbSearch.Text.Trim();
            string col = cbSearch.SelectedItem.ToString();
            bds.Filter = $"[{col}] like '%{txt}%'";
        }
    }
}
