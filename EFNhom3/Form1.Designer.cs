
namespace EFNhom3
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
            this.btnDanhSachLopHoc = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.gridDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDanhSachLopHoc
            // 
            this.btnDanhSachLopHoc.Location = new System.Drawing.Point(33, 85);
            this.btnDanhSachLopHoc.Name = "btnDanhSachLopHoc";
            this.btnDanhSachLopHoc.Size = new System.Drawing.Size(174, 54);
            this.btnDanhSachLopHoc.TabIndex = 1;
            this.btnDanhSachLopHoc.Text = "Danh Sách";
            this.btnDanhSachLopHoc.UseVisualStyleBackColor = true;
            this.btnDanhSachLopHoc.Click += new System.EventHandler(this.btnDanhSachLopHoc_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(225, 99);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(775, 22);
            this.txtKeyWord.TabIndex = 2;
            // 
            // gridDanhSach
            // 
            this.gridDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridDanhSach.Location = new System.Drawing.Point(33, 154);
            this.gridDanhSach.Name = "gridDanhSach";
            this.gridDanhSach.RowHeadersWidth = 51;
            this.gridDanhSach.RowTemplate.Height = 24;
            this.gridDanhSach.Size = new System.Drawing.Size(967, 395);
            this.gridDanhSach.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ML";
            this.Column1.HeaderText = "MaLop";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TL";
            this.Column2.HeaderText = "TenLop";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PH";
            this.Column3.HeaderText = "PhongHoc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SS";
            this.Column4.HeaderText = "SiSo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LoaiLop";
            this.Column5.HeaderText = "LoaiLop";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 571);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnDanhSachLopHoc);
            this.Controls.Add(this.gridDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDanhSachLopHoc;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.DataGridView gridDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

