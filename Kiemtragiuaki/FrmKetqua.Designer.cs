namespace Kiemtragiuaki
{
    partial class FrmKetqua
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Kiemtragiuaki.DatabaseBangdiembongdaDataSetTableAdapters.TableAdapterManager();
            this.bangDiemThiDauTableAdapter = new Kiemtragiuaki.DatabaseBangdiembongdaDataSetTableAdapters.BangDiemThiDauTableAdapter();
            this.bangDiemThiDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBangdiembongdaDataSet = new Kiemtragiuaki.DatabaseBangdiembongdaDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbbang = new System.Windows.Forms.Label();
            this.bangDiemThiDauBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemThiDauDataGridView = new System.Windows.Forms.DataGridView();
            this.pnbangdiem = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnxemchitiet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBangdiembongdaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauDataGridView)).BeginInit();
            this.pnbangdiem.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnxemchitiet);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbbang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(94, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 90);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(152, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quốc Gia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(410, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 90);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(321, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tỉ Số";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemThiDauTableAdapter = this.bangDiemThiDauTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kiemtragiuaki.DatabaseBangdiembongdaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bangDiemThiDauTableAdapter
            // 
            this.bangDiemThiDauTableAdapter.ClearBeforeFill = true;
            // 
            // bangDiemThiDauBindingSource
            // 
            this.bangDiemThiDauBindingSource.DataMember = "BangDiemThiDau";
            // 
            // databaseBangdiembongdaDataSet
            // 
            this.databaseBangdiembongdaDataSet.DataSetName = "DatabaseBangdiembongdaDataSet";
            this.databaseBangdiembongdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource1, "TiSo", true));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource1, "TenDoiDoiThu", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource1, "TenDoi", true));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "....";
            // 
            // lbbang
            // 
            this.lbbang.AutoSize = true;
            this.lbbang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource1, "TenBang", true));
            this.lbbang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbang.Location = new System.Drawing.Point(34, 39);
            this.lbbang.Name = "lbbang";
            this.lbbang.Size = new System.Drawing.Size(23, 17);
            this.lbbang.TabIndex = 1;
            this.lbbang.Text = "...";
            // 
            // bangDiemThiDauBindingSource1
            // 
            this.bangDiemThiDauBindingSource1.DataMember = "BangDiemThiDau";
            this.bangDiemThiDauBindingSource1.DataSource = this.databaseBangdiembongdaDataSet;
            // 
            // bangDiemThiDauDataGridView
            // 
            this.bangDiemThiDauDataGridView.AutoGenerateColumns = false;
            this.bangDiemThiDauDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDiemThiDauDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bangDiemThiDauDataGridView.DataSource = this.bangDiemThiDauBindingSource1;
            this.bangDiemThiDauDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bangDiemThiDauDataGridView.Location = new System.Drawing.Point(0, 40);
            this.bangDiemThiDauDataGridView.Name = "bangDiemThiDauDataGridView";
            this.bangDiemThiDauDataGridView.RowTemplate.Height = 24;
            this.bangDiemThiDauDataGridView.Size = new System.Drawing.Size(338, 143);
            this.bangDiemThiDauDataGridView.TabIndex = 1;
            // 
            // pnbangdiem
            // 
            this.pnbangdiem.Controls.Add(this.panel5);
            this.pnbangdiem.Controls.Add(this.bangDiemThiDauDataGridView);
            this.pnbangdiem.Location = new System.Drawing.Point(567, 12);
            this.pnbangdiem.Name = "pnbangdiem";
            this.pnbangdiem.Size = new System.Drawing.Size(338, 183);
            this.pnbangdiem.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDoi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đội";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoTranDaThiDau";
            this.dataGridViewTextBoxColumn6.HeaderText = "T";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HieuSo";
            this.dataGridViewTextBoxColumn7.HeaderText = "+/-";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Diem";
            this.dataGridViewTextBoxColumn8.HeaderText = "Đ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 40);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(36, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bảng Điểm";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(271, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 90);
            this.panel6.TabIndex = 6;
            // 
            // btnxemchitiet
            // 
            this.btnxemchitiet.BackColor = System.Drawing.Color.Transparent;
            this.btnxemchitiet.Location = new System.Drawing.Point(420, 36);
            this.btnxemchitiet.Name = "btnxemchitiet";
            this.btnxemchitiet.Size = new System.Drawing.Size(124, 23);
            this.btnxemchitiet.TabIndex = 7;
            this.btnxemchitiet.Text = "Xem chi tiết";
            this.btnxemchitiet.UseVisualStyleBackColor = false;
            this.btnxemchitiet.Click += new System.EventHandler(this.btnxemchitiet_Click);
            // 
            // FrmKetqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 198);
            this.Controls.Add(this.pnbangdiem);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKetqua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Trận Đấu";
            this.Load += new System.EventHandler(this.FrmKetqua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBangdiembongdaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauDataGridView)).EndInit();
            this.pnbangdiem.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource1;
        private DatabaseBangdiembongdaDataSet databaseBangdiembongdaDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbbang;
        private DatabaseBangdiembongdaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseBangdiembongdaDataSetTableAdapters.BangDiemThiDauTableAdapter bangDiemThiDauTableAdapter;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource;
        private System.Windows.Forms.DataGridView bangDiemThiDauDataGridView;
        private System.Windows.Forms.Panel pnbangdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxemchitiet;
        private System.Windows.Forms.Panel panel6;
    }
}