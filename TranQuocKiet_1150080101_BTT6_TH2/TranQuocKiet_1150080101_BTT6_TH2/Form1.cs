using System;
using System.Windows.Forms;

// Đảm bảo namespace trùng với tên dự án của bạn
namespace TranQuocKiet_1150080101_BTT6_TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Thiết lập ListView ở chế độ Details và hiển thị lưới
            lvStudentList.View = View.Details;
            lvStudentList.GridLines = true;
            lvStudentList.FullRowSelect = true; // Cho phép chọn toàn bộ dòng

            // Thêm các cột vào ListView
            // Đảm bảo kích thước phù hợp với hình minh họa
            lvStudentList.Columns.Add("Họ tên", 150);
            lvStudentList.Columns.Add("Ngày sinh", 100);
            lvStudentList.Columns.Add("Lớp", 80);
            lvStudentList.Columns.Add("Địa chỉ", 200);
        }

        // ----------------------------------------------------------------------
        // Nút Thêm: Thêm thông tin sinh viên vào ListView
        // ----------------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Kiểm tra thông tin họ tên sinh viên không được rỗng
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Tạo một đối tượng ListViewItem mới và thêm SubItems
            ListViewItem item = new ListViewItem(txtHoTen.Text.Trim());
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txtLop.Text.Trim());
            item.SubItems.Add(txtDiaChi.Text.Trim());

            lvStudentList.Items.Add(item);

            // Xóa nội dung các ô input sau khi thêm
            ClearInputFields();
        }

        // ----------------------------------------------------------------------
        // Nút Xóa: Xóa dòng được chọn trên ListView
        // ----------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Yêu cầu: Kiểm tra người dùng đã chọn một dòng chưa
            if (lvStudentList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Lỗi Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Xóa dòng được chọn
                lvStudentList.SelectedItems[0].Remove();
                ClearInputFields();
            }
        }

        // ----------------------------------------------------------------------
        // Nút Sửa: Cập nhật thông tin dòng được chọn
        // ----------------------------------------------------------------------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvStudentList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.", "Lỗi Sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Lấy dòng được chọn
            ListViewItem selectedItem = lvStudentList.SelectedItems[0];

            // Cập nhật các SubItems
            selectedItem.Text = txtHoTen.Text.Trim(); // Cột 0 (Ho ten)
            selectedItem.SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString(); // Cột 1 (Ngay sinh)
            selectedItem.SubItems[2].Text = txtLop.Text.Trim(); // Cột 2 (Lop)
            selectedItem.SubItems[3].Text = txtDiaChi.Text.Trim(); // Cột 3 (Dia chi)

            MessageBox.Show("Thông tin sinh viên đã được cập nhật.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ----------------------------------------------------------------------
        // Nút Thoát: Thoát khỏi chương trình
        // ----------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Thoát khỏi Form 2
        }

        // ----------------------------------------------------------------------
        // Sự kiện SelectedIndexChanged: Hiển thị thông tin lên các ô input
        // ----------------------------------------------------------------------
        private void lvStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Yêu cầu: Khi chọn 1 dòng trên listview thì nội dung của dòng được chọn sẽ được thể hiện trên các ô "Thông tin chung sinh viên".
            if (lvStudentList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvStudentList.SelectedItems[0];

                txtHoTen.Text = selectedItem.SubItems[0].Text;

                DateTime selectedDate;
                if (DateTime.TryParse(selectedItem.SubItems[1].Text, out selectedDate))
                {
                    dtpNgaySinh.Value = selectedDate;
                }
                txtLop.Text = selectedItem.SubItems[2].Text;
                txtDiaChi.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                ClearInputFields();
            }
        }

        // Hàm hỗ trợ xóa các ô input
        private void ClearInputFields()
        {
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtLop.Clear();
            txtDiaChi.Clear();
            // Không nên focus nếu ClearInputFields được gọi sau khi xóa/sửa.
            // Để lại focus cho người dùng tùy ý.
        }
    }
}
