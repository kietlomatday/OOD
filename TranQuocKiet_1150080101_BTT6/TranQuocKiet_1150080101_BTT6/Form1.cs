using System;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace TranQuocKiet_1150080101_BTT6
{
    public partial class Form1 : Form
    {
        private DataTable orderTable;

        public Form1()
        {
            InitializeComponent();
            InitializeOrderTable();
            InitializeTableComboBox();
        }

        private void InitializeOrderTable()
        {
            orderTable = new DataTable();
            orderTable.Columns.Add("Món ăn", typeof(string));
            orderTable.Columns.Add("Số lượng", typeof(int));

            dgvOrderList.DataSource = orderTable;
            dgvOrderList.Columns["Món ăn"].ReadOnly = true;
            dgvOrderList.Columns["Số lượng"].ReadOnly = true;
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.RowHeadersVisible = false;
            dgvOrderList.AllowUserToAddRows = false;
        }

        private void InitializeTableComboBox()
        {
            cmbTable.Items.AddRange(new object[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4", "Bàn 5", "Bàn 6" });
            if (cmbTable.Items.Count > 0)
            {
                cmbTable.SelectedIndex = 0;
            }
        }

        // Sự kiện chung cho TẤT CẢ các nút món ăn
        private void btnMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string itemName = btn.Text;

            DataRow[] foundRows = orderTable.Select($"[Món ăn] = '{itemName}'");

            if (foundRows.Length > 0)
            {
                DataRow row = foundRows[0];
                int currentQuantity = (int)row["Số lượng"];
                row["Số lượng"] = currentQuantity + 1;
            }
            else
            {
                orderTable.Rows.Add(itemName, 1);
            }
        }

        // Sự kiện cho nút "Order" (Ghi ra tệp)
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbTable.SelectedItem == null || orderTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn và ít nhất một món ăn để Order.", "Lỗi Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tableName = cmbTable.SelectedItem.ToString();
            string fileName = $"Order_{tableName}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"--- ORDER TỪ {tableName} ---");
                    sw.WriteLine($"Mã SV: 1150080118 - Phạm Minh Thoại");
                    sw.WriteLine($"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    sw.WriteLine(new string('=', 40));
                    sw.WriteLine($"{"Món ăn",-25} | {"Số lượng",-10}");
                    sw.WriteLine(new string('-', 40));

                    foreach (DataRow row in orderTable.Rows)
                    {
                        string itemName = row["Món ăn"].ToString();
                        int quantity = (int)row["Số lượng"];
                        sw.WriteLine($"{itemName,-25} | {quantity,-10}");
                    }
                    sw.WriteLine(new string('=', 40));
                }

                MessageBox.Show($"Order cho {tableName} đã được ghi vào tệp:\n{fileName}", "Order Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderTable.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi tệp: {ex.Message}\nCó thể tệp đang bị khóa bởi chương trình khác.", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện cho nút "Xóa"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (orderTable.Rows.Count > 0)
            {
                var result = MessageBox.Show("Xác nhận xóa tất cả các món đã chọn?", "Xóa Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    orderTable.Clear();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}