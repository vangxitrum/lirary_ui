
namespace LibraryApp
{
    partial class DashbroadScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.genreRP = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.genreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookRP = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genreRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRP)).BeginInit();
            this.SuspendLayout();
            // 
            // genreRP
            // 
            this.genreRP.AllowCustomTheming = false;
            this.genreRP.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.genreRP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.genreRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genreRP.BackgroundColor = System.Drawing.Color.White;
            this.genreRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreRP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.genreRP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genreRP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.genreRP.ColumnHeadersHeight = 40;
            this.genreRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreID,
            this.genreName,
            this.issuedTime,
            this.ratio});
            this.genreRP.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.genreRP.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.genreRP.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.genreRP.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.genreRP.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.genreRP.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.genreRP.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.genreRP.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.genreRP.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.genreRP.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.genreRP.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.genreRP.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.genreRP.CurrentTheme.Name = null;
            this.genreRP.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.genreRP.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.genreRP.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.genreRP.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.genreRP.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.genreRP.DefaultCellStyle = dataGridViewCellStyle3;
            this.genreRP.EnableHeadersVisualStyles = false;
            this.genreRP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.genreRP.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.genreRP.HeaderBgColor = System.Drawing.Color.Empty;
            this.genreRP.HeaderForeColor = System.Drawing.Color.White;
            this.genreRP.Location = new System.Drawing.Point(-1, 52);
            this.genreRP.Margin = new System.Windows.Forms.Padding(4);
            this.genreRP.Name = "genreRP";
            this.genreRP.RowHeadersVisible = false;
            this.genreRP.RowHeadersWidth = 51;
            this.genreRP.RowTemplate.Height = 40;
            this.genreRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genreRP.Size = new System.Drawing.Size(1500, 287);
            this.genreRP.TabIndex = 0;
            this.genreRP.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // genreID
            // 
            this.genreID.DividerWidth = 1;
            this.genreID.HeaderText = "Mã thể loại";
            this.genreID.MinimumWidth = 6;
            this.genreID.Name = "genreID";
            this.genreID.ReadOnly = true;
            // 
            // genreName
            // 
            this.genreName.DividerWidth = 1;
            this.genreName.HeaderText = "Tên thể loại";
            this.genreName.MinimumWidth = 6;
            this.genreName.Name = "genreName";
            this.genreName.ReadOnly = true;
            // 
            // issuedTime
            // 
            this.issuedTime.DividerWidth = 1;
            this.issuedTime.HeaderText = "Tổng số lần mượn";
            this.issuedTime.MinimumWidth = 6;
            this.issuedTime.Name = "issuedTime";
            // 
            // ratio
            // 
            this.ratio.DividerWidth = 1;
            this.ratio.HeaderText = "Tỷ lệ";
            this.ratio.MinimumWidth = 6;
            this.ratio.Name = "ratio";
            this.ratio.ReadOnly = true;
            // 
            // bookRP
            // 
            this.bookRP.AllowCustomTheming = false;
            this.bookRP.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bookRP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bookRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookRP.BackgroundColor = System.Drawing.Color.White;
            this.bookRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookRP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookRP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookRP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bookRP.ColumnHeadersHeight = 40;
            this.bookRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bID,
            this.bName,
            this.issuedDate,
            this.overdueDate});
            this.bookRP.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bookRP.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookRP.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookRP.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bookRP.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bookRP.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bookRP.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookRP.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bookRP.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bookRP.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bookRP.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bookRP.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bookRP.CurrentTheme.Name = null;
            this.bookRP.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bookRP.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookRP.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookRP.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bookRP.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookRP.DefaultCellStyle = dataGridViewCellStyle6;
            this.bookRP.EnableHeadersVisualStyles = false;
            this.bookRP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookRP.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bookRP.HeaderBgColor = System.Drawing.Color.Empty;
            this.bookRP.HeaderForeColor = System.Drawing.Color.White;
            this.bookRP.Location = new System.Drawing.Point(-1, 379);
            this.bookRP.Margin = new System.Windows.Forms.Padding(4);
            this.bookRP.Name = "bookRP";
            this.bookRP.RowHeadersVisible = false;
            this.bookRP.RowHeadersWidth = 51;
            this.bookRP.RowTemplate.Height = 40;
            this.bookRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookRP.Size = new System.Drawing.Size(1500, 270);
            this.bookRP.TabIndex = 0;
            this.bookRP.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bID
            // 
            this.bID.DividerWidth = 1;
            this.bID.HeaderText = "Mã sách";
            this.bID.MinimumWidth = 6;
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            // 
            // bName
            // 
            this.bName.DividerWidth = 1;
            this.bName.HeaderText = "Tên sách";
            this.bName.MinimumWidth = 6;
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            // 
            // issuedDate
            // 
            this.issuedDate.DividerWidth = 1;
            this.issuedDate.HeaderText = "Tổng số ngày mượn";
            this.issuedDate.MinimumWidth = 6;
            this.issuedDate.Name = "issuedDate";
            this.issuedDate.ReadOnly = true;
            // 
            // overdueDate
            // 
            this.overdueDate.DividerWidth = 1;
            this.overdueDate.HeaderText = "Tổng số ngày trả trễ";
            this.overdueDate.MinimumWidth = 6;
            this.overdueDate.Name = "overdueDate";
            this.overdueDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Báo cáo sách";
            // 
            // DashbroadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookRP);
            this.Controls.Add(this.genreRP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashbroadScreen";
            this.Text = "DashbroadScreen";
            ((System.ComponentModel.ISupportInitialize)(this.genreRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView genreRP;
        private Bunifu.UI.WinForms.BunifuDataGridView bookRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn bID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueDate;
    }
}