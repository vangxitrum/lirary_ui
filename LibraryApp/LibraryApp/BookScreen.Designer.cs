
namespace LibraryApp
{
    partial class BookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookScreen));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bookData = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.searchBt = new Bunifu.UI.WinForms.BunifuImageButton();
            this.searchBar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.addButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.deleteBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.modifyBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            this.SuspendLayout();
            // 
            // bookData
            // 
            this.bookData.AllowCustomTheming = false;
            this.bookData.AllowUserToAddRows = false;
            this.bookData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bookData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookData.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.bID,
            this.bookName,
            this.genre,
            this.author,
            this.status,
            this.amount,
            this.position,
            this.publishedYear,
            this.publisher,
            this.price,
            this.authorID,
            this.genreID});
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
            this.bookData.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bookData.Location = new System.Drawing.Point(-1, 59);
            this.bookData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookData.Name = "bookData";
            this.bookData.RowHeadersVisible = false;
            this.bookData.RowHeadersWidth = 20;
            this.bookData.RowTemplate.Height = 40;
            this.bookData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookData.Size = new System.Drawing.Size(1500, 523);
            this.bookData.TabIndex = 0;
            this.bookData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bookData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookData_CellContentClick);
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
            this.searchBt.ImageSize = new System.Drawing.Size(28, 29);
            this.searchBt.ImageZoomSize = new System.Drawing.Size(29, 30);
            this.searchBt.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchBt.InitialImage")));
            this.searchBt.Location = new System.Drawing.Point(307, 14);
            this.searchBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBt.Name = "searchBt";
            this.searchBt.Rotation = 0;
            this.searchBt.ShowActiveImage = true;
            this.searchBt.ShowCursorChanges = true;
            this.searchBt.ShowImageBorders = true;
            this.searchBt.ShowSizeMarkers = false;
            this.searchBt.Size = new System.Drawing.Size(29, 30);
            this.searchBt.TabIndex = 5;
            this.searchBt.ToolTipText = "";
            this.searchBt.WaitOnLoad = false;
            this.searchBt.Zoom = 0;
            this.searchBt.ZoomSpeed = 10;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
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
            this.searchBar.Location = new System.Drawing.Point(63, 14);
            this.searchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.searchBar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBar.PlaceholderText = "Search here";
            this.searchBar.ReadOnly = false;
            this.searchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBar.SelectedText = "";
            this.searchBar.SelectionLength = 0;
            this.searchBar.SelectionStart = 0;
            this.searchBar.ShortcutsEnabled = true;
            this.searchBar.Size = new System.Drawing.Size(228, 30);
            this.searchBar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBar.TabIndex = 4;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBar.TextMarginBottom = 0;
            this.searchBar.TextMarginLeft = 3;
            this.searchBar.TextMarginTop = 0;
            this.searchBar.TextPlaceholder = "Search here";
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.WordWrap = true;
            this.searchBar.TextChange += new System.EventHandler(this.searchBar_TextChange);
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
            this.addButton.ButtonText = "Thêm sách";
            this.addButton.ButtonTextMarginLeft = 0;
            this.addButton.ColorContrastOnClick = 45;
            this.addButton.ColorContrastOnHover = 45;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.addButton.CustomizableEdges = borderEdges1;
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
            this.addButton.Location = new System.Drawing.Point(845, 599);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.addButton.Size = new System.Drawing.Size(149, 39);
            this.addButton.TabIndex = 3;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addButton.TextMarginLeft = 0;
            this.addButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.addButton.UseDefaultRadiusAndThickness = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.deleteBt.ButtonText = "Xóa sách";
            this.deleteBt.ButtonTextMarginLeft = 0;
            this.deleteBt.ColorContrastOnClick = 45;
            this.deleteBt.ColorContrastOnHover = 45;
            this.deleteBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.deleteBt.CustomizableEdges = borderEdges2;
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
            this.deleteBt.Location = new System.Drawing.Point(1249, 599);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.deleteBt.Size = new System.Drawing.Size(149, 39);
            this.deleteBt.TabIndex = 2;
            this.deleteBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBt.TextMarginLeft = 0;
            this.deleteBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.deleteBt.UseDefaultRadiusAndThickness = true;
            // 
            // modifyBt
            // 
            this.modifyBt.AllowAnimations = true;
            this.modifyBt.AllowMouseEffects = true;
            this.modifyBt.AllowToggling = false;
            this.modifyBt.AnimationSpeed = 200;
            this.modifyBt.AutoGenerateColors = false;
            this.modifyBt.AutoRoundBorders = false;
            this.modifyBt.AutoSizeLeftIcon = true;
            this.modifyBt.AutoSizeRightIcon = true;
            this.modifyBt.BackColor = System.Drawing.Color.Transparent;
            this.modifyBt.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.modifyBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifyBt.BackgroundImage")));
            this.modifyBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.modifyBt.ButtonText = "Sửa thông tin";
            this.modifyBt.ButtonTextMarginLeft = 0;
            this.modifyBt.ColorContrastOnClick = 45;
            this.modifyBt.ColorContrastOnHover = 45;
            this.modifyBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.modifyBt.CustomizableEdges = borderEdges3;
            this.modifyBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.modifyBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.modifyBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.modifyBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.modifyBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.modifyBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modifyBt.ForeColor = System.Drawing.Color.White;
            this.modifyBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.modifyBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.modifyBt.IconMarginLeft = 11;
            this.modifyBt.IconPadding = 10;
            this.modifyBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.modifyBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.modifyBt.IconSize = 25;
            this.modifyBt.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.modifyBt.IdleBorderRadius = 1;
            this.modifyBt.IdleBorderThickness = 1;
            this.modifyBt.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.modifyBt.IdleIconLeftImage = null;
            this.modifyBt.IdleIconRightImage = null;
            this.modifyBt.IndicateFocus = false;
            this.modifyBt.Location = new System.Drawing.Point(1047, 599);
            this.modifyBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyBt.Name = "modifyBt";
            this.modifyBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.modifyBt.OnDisabledState.BorderRadius = 1;
            this.modifyBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.modifyBt.OnDisabledState.BorderThickness = 1;
            this.modifyBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.modifyBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.modifyBt.OnDisabledState.IconLeftImage = null;
            this.modifyBt.OnDisabledState.IconRightImage = null;
            this.modifyBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.modifyBt.onHoverState.BorderRadius = 1;
            this.modifyBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.modifyBt.onHoverState.BorderThickness = 1;
            this.modifyBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.modifyBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.modifyBt.onHoverState.IconLeftImage = null;
            this.modifyBt.onHoverState.IconRightImage = null;
            this.modifyBt.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.modifyBt.OnIdleState.BorderRadius = 1;
            this.modifyBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.modifyBt.OnIdleState.BorderThickness = 1;
            this.modifyBt.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.modifyBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.modifyBt.OnIdleState.IconLeftImage = null;
            this.modifyBt.OnIdleState.IconRightImage = null;
            this.modifyBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.modifyBt.OnPressedState.BorderRadius = 1;
            this.modifyBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.modifyBt.OnPressedState.BorderThickness = 1;
            this.modifyBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.modifyBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.modifyBt.OnPressedState.IconLeftImage = null;
            this.modifyBt.OnPressedState.IconRightImage = null;
            this.modifyBt.Size = new System.Drawing.Size(149, 39);
            this.modifyBt.TabIndex = 1;
            this.modifyBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifyBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifyBt.TextMarginLeft = 0;
            this.modifyBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.modifyBt.UseDefaultRadiusAndThickness = true;
            this.modifyBt.Click += new System.EventHandler(this.modifyBt_Click);
            // 
            // bID
            // 
            this.bID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bID.DividerWidth = 1;
            this.bID.HeaderText = "Mã Sách";
            this.bID.MinimumWidth = 6;
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            this.bID.Width = 116;
            // 
            // bookName
            // 
            this.bookName.DividerWidth = 1;
            this.bookName.HeaderText = "Tên sách";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.genre.DividerWidth = 1;
            this.genre.HeaderText = "Thể loại";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Width = 112;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.author.DividerWidth = 1;
            this.author.HeaderText = "Tác giả";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 101;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.status.DividerWidth = 1;
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 130;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.amount.DividerWidth = 1;
            this.amount.HeaderText = "Số lượng";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 122;
            // 
            // position
            // 
            this.position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.position.DividerWidth = 1;
            this.position.HeaderText = "Vị trí";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Width = 83;
            // 
            // publishedYear
            // 
            this.publishedYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.publishedYear.DividerWidth = 1;
            this.publishedYear.HeaderText = "Năm suất bản";
            this.publishedYear.MinimumWidth = 6;
            this.publishedYear.Name = "publishedYear";
            this.publishedYear.ReadOnly = true;
            this.publishedYear.Width = 167;
            // 
            // publisher
            // 
            this.publisher.DividerWidth = 1;
            this.publisher.HeaderText = "Nhà xuất bản";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // price
            // 
            this.price.DividerWidth = 1;
            this.price.HeaderText = "Trị giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // authorID
            // 
            this.authorID.HeaderText = "aID";
            this.authorID.MinimumWidth = 6;
            this.authorID.Name = "authorID";
            this.authorID.Visible = false;
            // 
            // genreID
            // 
            this.genreID.HeaderText = "gID";
            this.genreID.MinimumWidth = 6;
            this.genreID.Name = "genreID";
            this.genreID.ReadOnly = true;
            this.genreID.Visible = false;
            // 
            // BookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 650);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.modifyBt);
            this.Controls.Add(this.bookData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookScreen";
            this.Text = "BookScreen";
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton modifyBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addButton;
        private Bunifu.UI.WinForms.BunifuTextBox searchBar;
        private Bunifu.UI.WinForms.BunifuImageButton searchBt;
        private Bunifu.UI.WinForms.BunifuDataGridView bookData;
        private System.Windows.Forms.DataGridViewTextBoxColumn bID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreID;
    }
}