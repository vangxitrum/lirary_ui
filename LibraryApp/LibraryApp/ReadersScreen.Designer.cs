
namespace LibraryApp
{
    partial class ReadersScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadersScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.readerData = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchBt = new Bunifu.UI.WinForms.BunifuImageButton();
            this.searchBar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.deleteBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.readerData)).BeginInit();
            this.SuspendLayout();
            // 
            // readerData
            // 
            this.readerData.AllowCustomTheming = false;
            this.readerData.AllowUserToAddRows = false;
            this.readerData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.readerData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.readerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.readerData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.readerData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readerData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.readerData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.readerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.readerData.ColumnHeadersHeight = 40;
            this.readerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.readerName,
            this.type,
            this.dateofBirth,
            this.address,
            this.rEmail,
            this.signInDate,
            this.Debt});
            this.readerData.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.readerData.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.readerData.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.readerData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.readerData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.readerData.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.readerData.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.readerData.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.readerData.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.readerData.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.readerData.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.readerData.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.readerData.CurrentTheme.Name = null;
            this.readerData.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.readerData.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.readerData.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.readerData.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.readerData.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.readerData.DefaultCellStyle = dataGridViewCellStyle3;
            this.readerData.EnableHeadersVisualStyles = false;
            this.readerData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.readerData.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.readerData.HeaderBgColor = System.Drawing.Color.Empty;
            this.readerData.HeaderForeColor = System.Drawing.Color.White;
            this.readerData.Location = new System.Drawing.Point(0, 57);
            this.readerData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readerData.Name = "readerData";
            this.readerData.RowHeadersVisible = false;
            this.readerData.RowHeadersWidth = 30;
            this.readerData.RowTemplate.Height = 40;
            this.readerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readerData.Size = new System.Drawing.Size(1070, 425);
            this.readerData.TabIndex = 6;
            this.readerData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DividerWidth = 1;
            this.ID.HeaderText = "ID          ";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 90;
            // 
            // readerName
            // 
            this.readerName.DividerWidth = 1;
            this.readerName.HeaderText = "Name";
            this.readerName.MinimumWidth = 6;
            this.readerName.Name = "readerName";
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.type.DividerWidth = 1;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 69;
            // 
            // dateofBirth
            // 
            this.dateofBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dateofBirth.DividerWidth = 1;
            this.dateofBirth.HeaderText = "Date of birth";
            this.dateofBirth.MinimumWidth = 6;
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Width = 127;
            // 
            // address
            // 
            this.address.DividerWidth = 1;
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // rEmail
            // 
            this.rEmail.DividerWidth = 1;
            this.rEmail.HeaderText = "Email";
            this.rEmail.MinimumWidth = 6;
            this.rEmail.Name = "rEmail";
            // 
            // signInDate
            // 
            this.signInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.signInDate.DividerWidth = 1;
            this.signInDate.HeaderText = "Sign in date";
            this.signInDate.MinimumWidth = 6;
            this.signInDate.Name = "signInDate";
            this.signInDate.Width = 120;
            // 
            // Debt
            // 
            this.Debt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Debt.DividerWidth = 1;
            this.Debt.HeaderText = "Debt";
            this.Debt.MinimumWidth = 6;
            this.Debt.Name = "Debt";
            this.Debt.Width = 70;
            // 
            // payBt
            // 
            this.payBt.AllowAnimations = true;
            this.payBt.AllowMouseEffects = true;
            this.payBt.AllowToggling = false;
            this.payBt.AnimationSpeed = 200;
            this.payBt.AutoGenerateColors = false;
            this.payBt.AutoRoundBorders = false;
            this.payBt.AutoSizeLeftIcon = true;
            this.payBt.AutoSizeRightIcon = true;
            this.payBt.BackColor = System.Drawing.Color.Transparent;
            this.payBt.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.payBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payBt.BackgroundImage")));
            this.payBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.payBt.ButtonText = "Pay off Debt";
            this.payBt.ButtonTextMarginLeft = 0;
            this.payBt.ColorContrastOnClick = 45;
            this.payBt.ColorContrastOnHover = 45;
            this.payBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.payBt.CustomizableEdges = borderEdges1;
            this.payBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.payBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.payBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.payBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.payBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.payBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payBt.ForeColor = System.Drawing.Color.White;
            this.payBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.payBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.payBt.IconMarginLeft = 11;
            this.payBt.IconPadding = 10;
            this.payBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.payBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.payBt.IconSize = 25;
            this.payBt.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.payBt.IdleBorderRadius = 1;
            this.payBt.IdleBorderThickness = 1;
            this.payBt.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.payBt.IdleIconLeftImage = null;
            this.payBt.IdleIconRightImage = null;
            this.payBt.IndicateFocus = false;
            this.payBt.Location = new System.Drawing.Point(806, 488);
            this.payBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.payBt.Name = "payBt";
            this.payBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.payBt.OnDisabledState.BorderRadius = 1;
            this.payBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.payBt.OnDisabledState.BorderThickness = 1;
            this.payBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.payBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.payBt.OnDisabledState.IconLeftImage = null;
            this.payBt.OnDisabledState.IconRightImage = null;
            this.payBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.payBt.onHoverState.BorderRadius = 1;
            this.payBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.payBt.onHoverState.BorderThickness = 1;
            this.payBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.payBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.payBt.onHoverState.IconLeftImage = null;
            this.payBt.onHoverState.IconRightImage = null;
            this.payBt.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.payBt.OnIdleState.BorderRadius = 1;
            this.payBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.payBt.OnIdleState.BorderThickness = 1;
            this.payBt.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.payBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.payBt.OnIdleState.IconLeftImage = null;
            this.payBt.OnIdleState.IconRightImage = null;
            this.payBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.payBt.OnPressedState.BorderRadius = 1;
            this.payBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.payBt.OnPressedState.BorderThickness = 1;
            this.payBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.payBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.payBt.OnPressedState.IconLeftImage = null;
            this.payBt.OnPressedState.IconRightImage = null;
            this.payBt.Size = new System.Drawing.Size(112, 32);
            this.payBt.TabIndex = 12;
            this.payBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.payBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.payBt.TextMarginLeft = 0;
            this.payBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.payBt.UseDefaultRadiusAndThickness = true;
            this.payBt.Click += new System.EventHandler(this.payBt_Click);
            // 
            // addButton
            // 
            this.addButton.AllowAnimations = true;
            this.addButton.AllowMouseEffects = true;
            this.addButton.AllowToggling = false;
            this.addButton.AnimationSpeed = 200;
            this.addButton.AutoGenerateColors = false;
            this.addButton.AutoRoundBorders = false;
            this.addButton.AutoSizeLeftIcon = true;
            this.addButton.AutoSizeRightIcon = true;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.ButtonText = "Add";
            this.addButton.ButtonTextMarginLeft = 0;
            this.addButton.ColorContrastOnClick = 45;
            this.addButton.ColorContrastOnHover = 45;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.addButton.CustomizableEdges = borderEdges2;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addButton.IconMarginLeft = 11;
            this.addButton.IconPadding = 10;
            this.addButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addButton.IconSize = 25;
            this.addButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.addButton.IdleBorderRadius = 1;
            this.addButton.IdleBorderThickness = 1;
            this.addButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.addButton.IdleIconLeftImage = null;
            this.addButton.IdleIconRightImage = null;
            this.addButton.IndicateFocus = false;
            this.addButton.Location = new System.Drawing.Point(676, 488);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addButton.OnDisabledState.BorderRadius = 1;
            this.addButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.OnDisabledState.BorderThickness = 1;
            this.addButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addButton.OnDisabledState.IconLeftImage = null;
            this.addButton.OnDisabledState.IconRightImage = null;
            this.addButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addButton.onHoverState.BorderRadius = 1;
            this.addButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.onHoverState.BorderThickness = 1;
            this.addButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addButton.onHoverState.IconLeftImage = null;
            this.addButton.onHoverState.IconRightImage = null;
            this.addButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.addButton.OnIdleState.BorderRadius = 1;
            this.addButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.OnIdleState.BorderThickness = 1;
            this.addButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.addButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addButton.OnIdleState.IconLeftImage = null;
            this.addButton.OnIdleState.IconRightImage = null;
            this.addButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addButton.OnPressedState.BorderRadius = 1;
            this.addButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.OnPressedState.BorderThickness = 1;
            this.addButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addButton.OnPressedState.IconLeftImage = null;
            this.addButton.OnPressedState.IconRightImage = null;
            this.addButton.Size = new System.Drawing.Size(112, 32);
            this.addButton.TabIndex = 12;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addButton.TextMarginLeft = 0;
            this.addButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.addButton.UseDefaultRadiusAndThickness = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchBt
            // 
            this.searchBt.ActiveImage = null;
            this.searchBt.AllowAnimations = true;
            this.searchBt.AllowBuffering = false;
            this.searchBt.AllowToggling = false;
            this.searchBt.AllowZooming = true;
            this.searchBt.AllowZoomingOnFocus = false;
            this.searchBt.BackColor = System.Drawing.Color.Transparent;
            this.searchBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBt.ErrorImage = ((System.Drawing.Image)(resources.GetObject("searchBt.ErrorImage")));
            this.searchBt.FadeWhenInactive = false;
            this.searchBt.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.searchBt.Image = ((System.Drawing.Image)(resources.GetObject("searchBt.Image")));
            this.searchBt.ImageActive = null;
            this.searchBt.ImageLocation = null;
            this.searchBt.ImageMargin = 0;
            this.searchBt.ImageSize = new System.Drawing.Size(21, 23);
            this.searchBt.ImageZoomSize = new System.Drawing.Size(22, 24);
            this.searchBt.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchBt.InitialImage")));
            this.searchBt.Location = new System.Drawing.Point(230, 10);
            this.searchBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBt.Name = "searchBt";
            this.searchBt.Rotation = 0;
            this.searchBt.ShowActiveImage = true;
            this.searchBt.ShowCursorChanges = true;
            this.searchBt.ShowImageBorders = true;
            this.searchBt.ShowSizeMarkers = false;
            this.searchBt.Size = new System.Drawing.Size(22, 24);
            this.searchBt.TabIndex = 11;
            this.searchBt.ToolTipText = "";
            this.searchBt.WaitOnLoad = false;
            this.searchBt.Zoom = 0;
            this.searchBt.ZoomSpeed = 10;
            // 
            // searchBar
            // 
            this.searchBar.AcceptsReturn = false;
            this.searchBar.AcceptsTab = false;
            this.searchBar.AnimationSpeed = 200;
            this.searchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBar.BackColor = System.Drawing.Color.Transparent;
            this.searchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBar.BackgroundImage")));
            this.searchBar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchBar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchBar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchBar.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchBar.BorderRadius = 1;
            this.searchBar.BorderThickness = 1;
            this.searchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.searchBar.DefaultText = "";
            this.searchBar.FillColor = System.Drawing.Color.White;
            this.searchBar.HideSelection = true;
            this.searchBar.IconLeft = null;
            this.searchBar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.IconPadding = 10;
            this.searchBar.IconRight = null;
            this.searchBar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.Lines = new string[0];
            this.searchBar.Location = new System.Drawing.Point(47, 10);
            this.searchBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBar.MaxLength = 32767;
            this.searchBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBar.Modified = false;
            this.searchBar.Multiline = false;
            this.searchBar.Name = "searchBar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBar.OnIdleState = stateProperties4;
            this.searchBar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBar.PlaceholderText = "Search here";
            this.searchBar.ReadOnly = false;
            this.searchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBar.SelectedText = "";
            this.searchBar.SelectionLength = 0;
            this.searchBar.SelectionStart = 0;
            this.searchBar.ShortcutsEnabled = true;
            this.searchBar.Size = new System.Drawing.Size(171, 24);
            this.searchBar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBar.TabIndex = 10;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBar.TextMarginBottom = 0;
            this.searchBar.TextMarginLeft = 3;
            this.searchBar.TextMarginTop = 0;
            this.searchBar.TextPlaceholder = "Search here";
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.WordWrap = true;
            // 
            // deleteBt
            // 
            this.deleteBt.AllowAnimations = true;
            this.deleteBt.AllowMouseEffects = true;
            this.deleteBt.AllowToggling = false;
            this.deleteBt.AnimationSpeed = 200;
            this.deleteBt.AutoGenerateColors = false;
            this.deleteBt.AutoRoundBorders = false;
            this.deleteBt.AutoSizeLeftIcon = true;
            this.deleteBt.AutoSizeRightIcon = true;
            this.deleteBt.BackColor = System.Drawing.Color.Transparent;
            this.deleteBt.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.deleteBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBt.BackgroundImage")));
            this.deleteBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBt.ButtonText = "Delete";
            this.deleteBt.ButtonTextMarginLeft = 0;
            this.deleteBt.ColorContrastOnClick = 45;
            this.deleteBt.ColorContrastOnHover = 45;
            this.deleteBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.deleteBt.CustomizableEdges = borderEdges3;
            this.deleteBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.deleteBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBt.ForeColor = System.Drawing.Color.White;
            this.deleteBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deleteBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deleteBt.IconMarginLeft = 11;
            this.deleteBt.IconPadding = 10;
            this.deleteBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deleteBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deleteBt.IconSize = 25;
            this.deleteBt.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.deleteBt.IdleBorderRadius = 1;
            this.deleteBt.IdleBorderThickness = 1;
            this.deleteBt.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.deleteBt.IdleIconLeftImage = null;
            this.deleteBt.IdleIconRightImage = null;
            this.deleteBt.IndicateFocus = false;
            this.deleteBt.Location = new System.Drawing.Point(937, 486);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteBt.OnDisabledState.BorderRadius = 1;
            this.deleteBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBt.OnDisabledState.BorderThickness = 1;
            this.deleteBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteBt.OnDisabledState.IconLeftImage = null;
            this.deleteBt.OnDisabledState.IconRightImage = null;
            this.deleteBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.deleteBt.onHoverState.BorderRadius = 1;
            this.deleteBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBt.onHoverState.BorderThickness = 1;
            this.deleteBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.deleteBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.deleteBt.onHoverState.IconLeftImage = null;
            this.deleteBt.onHoverState.IconRightImage = null;
            this.deleteBt.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.deleteBt.OnIdleState.BorderRadius = 1;
            this.deleteBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBt.OnIdleState.BorderThickness = 1;
            this.deleteBt.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.deleteBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deleteBt.OnIdleState.IconLeftImage = null;
            this.deleteBt.OnIdleState.IconRightImage = null;
            this.deleteBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.deleteBt.OnPressedState.BorderRadius = 1;
            this.deleteBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBt.OnPressedState.BorderThickness = 1;
            this.deleteBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.deleteBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deleteBt.OnPressedState.IconLeftImage = null;
            this.deleteBt.OnPressedState.IconRightImage = null;
            this.deleteBt.Size = new System.Drawing.Size(112, 32);
            this.deleteBt.TabIndex = 8;
            this.deleteBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBt.TextMarginLeft = 0;
            this.deleteBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.deleteBt.UseDefaultRadiusAndThickness = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // ReadersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 528);
            this.Controls.Add(this.payBt);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.readerData);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.deleteBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReadersScreen";
            this.Text = "ReadersScreen";
            ((System.ComponentModel.ISupportInitialize)(this.readerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView readerData;
        private Bunifu.UI.WinForms.BunifuImageButton searchBt;
        private Bunifu.UI.WinForms.BunifuTextBox searchBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton payBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn signInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
    }
}