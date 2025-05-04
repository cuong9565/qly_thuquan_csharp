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
    public partial class ucViPham : UserControl
    {
        public ucViPham()
        {
            InitializeComponent();
            dtgvThanhVien.DataSource = bdsThanhVien;
            dtgvViPham.DataSource = bdsViPham;

            // btnXuLy
            Binding bdXuLy = new Binding("Enabled", bdsViPham, "Trạng thái", true, DataSourceUpdateMode.OnPropertyChanged);
            bdXuLy.Format += (s, e) => {
                e.Value = (e.Value == null || (e.Value as string) == "Đã xử lý") ? false : true;
            };
            btnXuLy.DataBindings.Add(bdXuLy);

            // btnAdd
            Binding bdAdd = new Binding("Enabled", bdsThanhVien, "Mã số", true, DataSourceUpdateMode.OnPropertyChanged);
            bdAdd.Format += (s, e) =>
            {
                e.Value = (e.Value == null) ? false : true;
            };
            btnAdd.DataBindings.Add(bdAdd);

            // btnUpdate
            Binding bdUpdate = new Binding("Enabled", bdsViPham, "Mã số", true, DataSourceUpdateMode.OnPropertyChanged);
            bdUpdate.Format += (s, e) =>
            {
                e.Value = (e.Value == null) ? false : true;
            };
            btnUpdate.DataBindings.Add(bdUpdate);

            // btnDelete
            Binding bdDelete = new Binding("Enabled", bdsViPham, "Mã số", true, DataSourceUpdateMode.OnPropertyChanged);
            bdDelete.Format += (s, e) =>
            {
                e.Value = (e.Value == null) ? false : true;
            };
            btnDelete.DataBindings.Add(bdDelete);

            // cbUpdateVP
            Binding bdNameVP = new Binding("SelectedItem", bdsViPham, "Tên vi phạm", true, DataSourceUpdateMode.Never);
            cbUpdateNameVP.DataBindings.Add(bdNameVP);

            // nmudUpdateVP
            Binding bdPrice = new Binding("Value", bdsViPham, "Mức phạt", true, DataSourceUpdateMode.Never);
            nmudUpdateVP.DataBindings.Add(bdPrice);

            // cbStateVP
            Binding bdState = new Binding("SelectedItem", bdsViPham, "Trạng thái", true, DataSourceUpdateMode.Never);
            cbUpdateStateVP.DataBindings.Add(bdState);

            cbAddVP.SelectedIndex = 0;
            cbUpdateNameVP.SelectedIndex = 0;
            cbUpdateStateVP.SelectedIndex = 0;
            load();
        }
        public void load(string str = null)
        {
            try
            {
                string idTV = "";
                if (str == null) bdsThanhVien.DataSource = ThanhVienController.getInstance().getDTById(txbIdTV.Text);
                else bdsThanhVien.DataSource = ThanhVienController.getInstance().getDTById(str);

                if (dtgvThanhVien.RowCount > 0)
                        idTV = (string)dtgvThanhVien.Rows[0].Cells[0].Value;   
                bdsViPham.DataSource = ViPhamController.getInstance().loadByIdTV(idTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            load();
            txbIdTV.Text = "";
        }

        private void txbIdTV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(null, null);
            }
        }

        private void cbAddVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAddVP.SelectedItem.ToString() == "Khóa thẻ vĩnh viễn")
            {
                nmudAddVP.Value = 0;
                nmudAddVP.Enabled = false;
            }
            else {
                nmudAddVP.Enabled = true;
            }
        }

        private void cbUpdateNameVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUpdateNameVP.SelectedItem.ToString() == "Khóa thẻ vĩnh viễn")
            {
                nmudUpdateVP.Value = 0;
                nmudUpdateVP.Enabled = false;

                cbUpdateStateVP.SelectedItem = "Chưa xử lý";
                cbUpdateStateVP.Enabled = false;
            }
            else
            {
                nmudUpdateVP.Enabled = true;
                cbUpdateStateVP.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string idTV = (string)dtgvThanhVien.Rows[0].Cells[0].Value;
                string nameVP = (string)cbAddVP.SelectedItem.ToString();
                double price = (double)nmudAddVP.Value;
                ViPhamController.getInstance().insert(idTV, nameVP, price);
                MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load(idTV);
                cbAddVP.SelectedIndex = 0;
                nmudAddVP.Value = 0;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dtgvViPham.SelectedRows[0].Index;

                int id = (int)dtgvViPham.Rows[row].Cells[0].Value;
                string idTV = (string)dtgvThanhVien.Rows[0].Cells[0].Value;

                string nameVP = (string)cbUpdateNameVP.SelectedItem.ToString();
                double price = (double)nmudUpdateVP.Value;
                DateTime dateCreate = (DateTime)dtgvViPham.Rows[row].Cells["Thời gian vi phạm"].Value;

                string state = (string)cbUpdateStateVP.SelectedItem.ToString();
                ViPhamController.getInstance().update(id, nameVP, price, state, dateCreate);
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load(idTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dtgvViPham.SelectedRows[0].Index;
                int id = (int)dtgvViPham.Rows[row].Cells[0].Value;
                string idTV = (string)dtgvThanhVien.Rows[0].Cells[0].Value;
                ViPhamController.getInstance().delete(id);
                MessageBox.Show("Xóa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load(idTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dtgvViPham.SelectedRows[0].Index;
                int id = (int)dtgvViPham.Rows[row].Cells[0].Value;
                string idTV = (string)dtgvThanhVien.Rows[0].Cells[0].Value;
                string nameVP = (string)cbUpdateNameVP.SelectedItem.ToString();
                DateTime dateCreate = (DateTime)dtgvViPham.Rows[row].Cells["Thời gian vi phạm"].Value;

                ViPhamController.getInstance().XuLy(id, nameVP, "Đã xử lý", dateCreate);
                MessageBox.Show("Xử lý vi phạm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load(idTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
