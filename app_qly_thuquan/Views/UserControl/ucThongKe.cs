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

namespace qly_thuquan
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
            dtpkFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpkTo.Value = dtpkFrom.Value.AddMonths(1).AddDays(-1);
            load();
        }
        public void load()
        {
            lbVPDaXuLy.Text = "Số lượng vi phạm đã xử lý: " + ViPhamController.getInstance().NumVPDaXuLy();
            lbVPDangXuLy.Text = "Số lượng vi phạm đang xử lý: " + ViPhamController.getInstance().NumVPChuaXuLy();
            lbVPBoiThuong.Text = "Số tiền đã được bồi thường: " + ViPhamController.getInstance().NumVPBoiThuong() + "đ";
            lbNumTV.Text = "Số thành viên: " + ThanhVienController.getInstance().NumTV();
            lbNumTB.Text = "Số lượng thiết bị: " + ThietBiController.getInstance().NumTB();
            // Theo gio
            lbNumVao.Text = "Số lượng thành viên vào thư quán: " + VaoTQController.getInstance().NumVao(dtpkFrom.Value, dtpkTo.Value);
            lbNumDat.Text = "Số lượng thiết bị được đặt chỗ: " + MuonTraTBController.getInstance().NumDat(dtpkFrom.Value, dtpkTo.Value);
            lbNumMuon.Text = "Số lượng thiết bị đang được mượn: " + MuonTraTBController.getInstance().NumMuon(dtpkFrom.Value, dtpkTo.Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
