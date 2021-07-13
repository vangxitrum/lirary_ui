
namespace LibraryApp
{
    partial class UserIssuedBookScreen
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
            this.bookData = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            this.SuspendLayout();
            // 
            // bookData
            // 
            this.bookData.AllowCustomTheming = false;
            this.bookData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bookData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookData.BackgroundColor = System.Drawing.Color.White;
            this.bookData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookData.ColumnHeadersHeight = 40;
            this.bookData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.bookName,
            this.Status,
            this.Price,
            this.issuedDate});
            this.bookData.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bookData.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookData.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bookData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bookData.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bookData.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookData.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bookData.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bookData.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bookData.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bookData.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bookData.CurrentTheme.Name = null;
            this.bookData.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bookData.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookData.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookData.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bookData.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookData.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookData.EnableHeadersVisualStyles = false;
            this.bookData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookData.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bookData.HeaderBgColor = System.Drawing.Color.Empty;
            this.bookData.HeaderForeColor = System.Drawing.Color.White;
            this.bookData.Location = new System.Drawing.Point(-1, 0);
            this.bookData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookData.Name = "bookData";
            this.bookData.RowHeadersVisible = false;
            this.bookData.RowHeadersWidth = 51;
            this.bookData.RowTemplate.Height = 40;
            this.bookData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookData.Size = new System.Drawing.Size(1356, 654);
            this.bookData.TabIndex = 28;
            this.bookData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DividerWidth = 1;
            this.ID.HeaderText = "Mã Sách";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 116;
            // 
            // bookName
            // 
            this.bookName.DividerWidth = 1;
            this.bookName.HeaderText = "Tên sách";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DividerWidth = 1;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DividerWidth = 1;
            this.Price.HeaderText = "Trị giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // issuedDate
            // 
            this.issuedDate.DividerWidth = 1;
            this.issuedDate.HeaderText = "Ngày mượn";
            this.issuedDate.MinimumWidth = 6;
            this.issuedDate.Name = "issuedDate";
            this.issuedDate.ReadOnly = true;
            this.issuedDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.issuedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserIssuedBookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 650);
            this.Controls.Add(this.bookData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserIssuedBookScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserIssuedBookScreen";
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView bookData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDate;
    }
}