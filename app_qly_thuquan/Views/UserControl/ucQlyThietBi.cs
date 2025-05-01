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
using OfficeOpenXml;
using qly_thuquan.Controller;
using qly_thuquan.Model;

namespace qly_thuquan
{
    public partial class ucQlyThietBi : UserControl
    {
        DataTable dt = new DataTable();
        public ucQlyThietBi()
        {
            InitializeComponent();
            cbSearch.SelectedIndex = 0;
            load();
        }

        public void load()
        {
            try
            {
                dt = ThietBiController.getInstance().getAll();
                dtgvThietBi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int id = (int)dtgvThietBi.Rows[row].Cells[0].Value;
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
                    int id = (int)dtgvThietBi.Rows[row].Cells[0].Value;
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
                                string name = worksheet.Cells[i, 1].Text;
                                ThietBiController.getInstance().insert(name);
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
    }
}
