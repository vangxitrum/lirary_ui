
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.genreRP = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bookRP = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.genreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.genreRP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.genreRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genreRP.BackgroundColor = System.Drawing.Color.White;
            this.genreRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreRP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.genreRP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genreRP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.genreRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.genreRP.DefaultCellStyle = dataGridViewCellStyle9;
            this.genreRP.EnableHeadersVisualStyles = false;
            this.genreRP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.genreRP.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.genreRP.HeaderBgColor = System.Drawing.Color.Empty;
            this.genreRP.HeaderForeColor = System.Drawing.Color.White;
            this.genreRP.Location = new System.Drawing.Point(-1, 35);
            this.genreRP.Name = "genreRP";
            this.genreRP.RowHeadersVisible = false;
            this.genreRP.RowTemplate.Height = 40;
            this.genreRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genreRP.Size = new System.Drawing.Size(1090, 233);
            this.genreRP.TabIndex = 0;
            this.genreRP.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bookRP
            // 
            this.bookRP.AllowCustomTheming = false;
            this.bookRP.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.bookRP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bookRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookRP.BackgroundColor = System.Drawing.Color.White;
            this.bookRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookRP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookRP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookRP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.bookRP.ColumnHeadersHeight = 20;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookRP.DefaultCellStyle = dataGridViewCellStyle12;
            this.bookRP.EnableHeadersVisualStyles = false;
            this.bookRP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookRP.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bookRP.HeaderBgColor = System.Drawing.Color.Empty;
            this.bookRP.HeaderForeColor = System.Drawing.Color.White;
            this.bookRP.Location = new System.Drawing.Point(-1, 308);
            this.bookRP.Name = "bookRP";
            this.bookRP.RowHeadersVisible = false;
            this.bookRP.RowTemplate.Height = 40;
            this.bookRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookRP.Size = new System.Drawing.Size(1090, 219);
            this.bookRP.TabIndex = 0;
            this.bookRP.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // genreID
            // 
            this.genreID.DividerWidth = 1;
            this.genreID.HeaderText = "Genre ID";
            this.genreID.Name = "genreID";
            this.genreID.ReadOnly = true;
            // 
            // genreName
            // 
            this.genreName.DividerWidth = 1;
            this.genreName.HeaderText = "Name";
            this.genreName.Name = "genreName";
            this.genreName.ReadOnly = true;
            // 
            // issuedTime
            // 
            this.issuedTime.DividerWidth = 1;
            this.issuedTime.HeaderText = "Issued Time";
            this.issuedTime.Name = "issuedTime";
            // 
            // ratio
            // 
            this.ratio.DividerWidth = 1;
            this.ratio.HeaderText = "Ratio";
            this.ratio.Name = "ratio";
            this.ratio.ReadOnly = true;
            // 
            // bID
            // 
            this.bID.DividerWidth = 1;
            this.bID.HeaderText = "Book ID";
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            // 
            // bName
            // 
            this.bName.DividerWidth = 1;
            this.bName.HeaderText = "Name";
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            // 
            // issuedDate
            // 
            this.issuedDate.DividerWidth = 1;
            this.issuedDate.HeaderText = "Issued Date";
            this.issuedDate.Name = "issuedDate";
            this.issuedDate.ReadOnly = true;
            // 
            // overdueDate
            // 
            this.overdueDate.DividerWidth = 1;
            this.overdueDate.HeaderText = "Overdue Date";
            this.overdueDate.Name = "overdueDate";
            this.overdueDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENRE REPORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "BOOK REPORT";
            // 
            // DashbroadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookRP);
            this.Controls.Add(this.genreRP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn genreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn bID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}