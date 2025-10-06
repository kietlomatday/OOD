namespace TranQuocKiet_1150080101_BTT6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnFood1 = new System.Windows.Forms.Button();
            this.btnFood2 = new System.Windows.Forms.Button();
            this.btnFood3 = new System.Windows.Forms.Button();
            this.btnFood4 = new System.Windows.Forms.Button();
            this.btnFood5 = new System.Windows.Forms.Button();
            this.btnFood6 = new System.Windows.Forms.Button();
            this.btnFood7 = new System.Windows.Forms.Button();
            this.btnFood8 = new System.Windows.Forms.Button();
            this.btnFood9 = new System.Windows.Forms.Button();
            this.btnFood10 = new System.Windows.Forms.Button();
            this.btnFood11 = new System.Windows.Forms.Button();
            this.btnFood12 = new System.Windows.Forms.Button();
            this.btnFood13 = new System.Windows.Forms.Button();
            this.btnFood14 = new System.Windows.Forms.Button();
            this.btnBunBoHue = new System.Windows.Forms.Button();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(650, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(180, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(463, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quán ăn nhanh Hưng Thịnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::TranQuocKiet_1150080101_BTT6.Properties.Resources.hamburger1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 90);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(161, 23);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Danh sách món ăn:";
            // 
            // btnFood1
            // 
            this.btnFood1.Location = new System.Drawing.Point(15, 115);
            this.btnFood1.Name = "btnFood1";
            this.btnFood1.Size = new System.Drawing.Size(130, 35);
            this.btnFood1.TabIndex = 7;
            this.btnFood1.Text = "Cơm chiên trứng";
            this.btnFood1.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood2
            // 
            this.btnFood2.Location = new System.Drawing.Point(165, 115);
            this.btnFood2.Name = "btnFood2";
            this.btnFood2.Size = new System.Drawing.Size(130, 35);
            this.btnFood2.TabIndex = 8;
            this.btnFood2.Text = "Bánh mỳ ốp la";
            this.btnFood2.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood3
            // 
            this.btnFood3.Location = new System.Drawing.Point(315, 115);
            this.btnFood3.Name = "btnFood3";
            this.btnFood3.Size = new System.Drawing.Size(130, 35);
            this.btnFood3.TabIndex = 9;
            this.btnFood3.Text = "Coca";
            this.btnFood3.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood4
            // 
            this.btnFood4.Location = new System.Drawing.Point(465, 115);
            this.btnFood4.Name = "btnFood4";
            this.btnFood4.Size = new System.Drawing.Size(130, 35);
            this.btnFood4.TabIndex = 10;
            this.btnFood4.Text = "Lipton";
            this.btnFood4.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood5
            // 
            this.btnFood5.Location = new System.Drawing.Point(15, 165);
            this.btnFood5.Name = "btnFood5";
            this.btnFood5.Size = new System.Drawing.Size(130, 35);
            this.btnFood5.TabIndex = 11;
            this.btnFood5.Text = "Ốc rang muối";
            this.btnFood5.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood6
            // 
            this.btnFood6.Location = new System.Drawing.Point(165, 165);
            this.btnFood6.Name = "btnFood6";
            this.btnFood6.Size = new System.Drawing.Size(130, 35);
            this.btnFood6.TabIndex = 12;
            this.btnFood6.Text = "Khoai tây chiên";
            this.btnFood6.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood7
            // 
            this.btnFood7.Location = new System.Drawing.Point(315, 165);
            this.btnFood7.Name = "btnFood7";
            this.btnFood7.Size = new System.Drawing.Size(130, 35);
            this.btnFood7.TabIndex = 13;
            this.btnFood7.Text = "7 up";
            this.btnFood7.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood8
            // 
            this.btnFood8.Location = new System.Drawing.Point(465, 165);
            this.btnFood8.Name = "btnFood8";
            this.btnFood8.Size = new System.Drawing.Size(130, 35);
            this.btnFood8.TabIndex = 14;
            this.btnFood8.Text = "Cam";
            this.btnFood8.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood9
            // 
            this.btnFood9.Location = new System.Drawing.Point(15, 215);
            this.btnFood9.Name = "btnFood9";
            this.btnFood9.Size = new System.Drawing.Size(130, 35);
            this.btnFood9.TabIndex = 15;
            this.btnFood9.Text = "Mỳ xào hải sản";
            this.btnFood9.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood10
            // 
            this.btnFood10.Location = new System.Drawing.Point(165, 215);
            this.btnFood10.Name = "btnFood10";
            this.btnFood10.Size = new System.Drawing.Size(130, 35);
            this.btnFood10.TabIndex = 16;
            this.btnFood10.Text = "Cá viên chiên";
            this.btnFood10.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood11
            // 
            this.btnFood11.Location = new System.Drawing.Point(315, 215);
            this.btnFood11.Name = "btnFood11";
            this.btnFood11.Size = new System.Drawing.Size(130, 35);
            this.btnFood11.TabIndex = 17;
            this.btnFood11.Text = "Pepsi";
            this.btnFood11.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood12
            // 
            this.btnFood12.Location = new System.Drawing.Point(465, 215);
            this.btnFood12.Name = "btnFood12";
            this.btnFood12.Size = new System.Drawing.Size(130, 35);
            this.btnFood12.TabIndex = 18;
            this.btnFood12.Text = "Cafe";
            this.btnFood12.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood13
            // 
            this.btnFood13.Location = new System.Drawing.Point(15, 265);
            this.btnFood13.Name = "btnFood13";
            this.btnFood13.Size = new System.Drawing.Size(130, 35);
            this.btnFood13.TabIndex = 19;
            this.btnFood13.Text = "Buger bò nướng";
            this.btnFood13.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnFood14
            // 
            this.btnFood14.Location = new System.Drawing.Point(165, 265);
            this.btnFood14.Name = "btnFood14";
            this.btnFood14.Size = new System.Drawing.Size(130, 35);
            this.btnFood14.TabIndex = 20;
            this.btnFood14.Text = "Đùi gà rán";
            this.btnFood14.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnBunBoHue
            // 
            this.btnBunBoHue.Location = new System.Drawing.Point(315, 265);
            this.btnBunBoHue.Name = "btnBunBoHue";
            this.btnBunBoHue.Size = new System.Drawing.Size(130, 35);
            this.btnBunBoHue.TabIndex = 21;
            this.btnBunBoHue.Text = "Bún bò Huế";
            this.btnBunBoHue.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(350, 330);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(121, 28);
            this.cmbTable.TabIndex = 2;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(270, 333);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(75, 20);
            this.lblTable.TabIndex = 3;
            this.lblTable.Text = "Chọn bàn:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(500, 325);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 30);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 380);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.Size = new System.Drawing.Size(626, 200);
            this.dgvOrderList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.btnFood1);
            this.Controls.Add(this.btnFood2);
            this.Controls.Add(this.btnFood3);
            this.Controls.Add(this.btnFood4);
            this.Controls.Add(this.btnFood5);
            this.Controls.Add(this.btnFood6);
            this.Controls.Add(this.btnFood7);
            this.Controls.Add(this.btnFood8);
            this.Controls.Add(this.btnFood9);
            this.Controls.Add(this.btnFood10);
            this.Controls.Add(this.btnFood11);
            this.Controls.Add(this.btnFood12);
            this.Controls.Add(this.btnFood13);
            this.Controls.Add(this.btnFood14);
            this.Controls.Add(this.btnBunBoHue);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu;

        // Khai báo 15 nút món ăn/thức uống
        private System.Windows.Forms.Button btnFood1;
        private System.Windows.Forms.Button btnFood2;
        private System.Windows.Forms.Button btnFood3;
        private System.Windows.Forms.Button btnFood4;
        private System.Windows.Forms.Button btnFood5;
        private System.Windows.Forms.Button btnFood6;
        private System.Windows.Forms.Button btnFood7;
        private System.Windows.Forms.Button btnFood8;
        private System.Windows.Forms.Button btnFood9;
        private System.Windows.Forms.Button btnFood10;
        private System.Windows.Forms.Button btnFood11;
        private System.Windows.Forms.Button btnFood12;
        private System.Windows.Forms.Button btnFood13;
        private System.Windows.Forms.Button btnFood14;
        private System.Windows.Forms.Button btnBunBoHue;

        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvOrderList;
    }
}