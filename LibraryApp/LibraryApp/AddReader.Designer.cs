
namespace LibraryApp
{
    partial class AddReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReader));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readerTypeSet = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDayTaker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.saveBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.emailTaker = new Bunifu.UI.WinForms.BunifuTextBox();
            this.addressTaker = new Bunifu.UI.WinForms.BunifuTextBox();
            this.nameTaker = new Bunifu.UI.WinForms.BunifuTextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(378, 85);
            this.topPanel.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.ActiveImage = null;
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowBuffering = false;
            this.exitButton.AllowToggling = false;
            this.exitButton.AllowZooming = true;
            this.exitButton.AllowZoomingOnFocus = false;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("exitButton.ErrorImage")));
            this.exitButton.FadeWhenInactive = false;
            this.exitButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.exitButton.Image = global::LibraryApp.Properties.Resources.exit;
            this.exitButton.ImageActive = null;
            this.exitButton.ImageLocation = null;
            this.exitButton.ImageMargin = 5;
            this.exitButton.ImageSize = new System.Drawing.Size(28, 26);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(33, 31);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(334, 26);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(33, 31);
            this.exitButton.TabIndex = 2;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 5;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Reader";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(485, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(59, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date of birth";
            // 
            // readerTypeSet
            // 
            this.readerTypeSet.BackColor = System.Drawing.Color.Transparent;
            this.readerTypeSet.BackgroundColor = System.Drawing.Color.White;
            this.readerTypeSet.BorderColor = System.Drawing.Color.Silver;
            this.readerTypeSet.BorderRadius = 1;
            this.readerTypeSet.Color = System.Drawing.Color.Silver;
            this.readerTypeSet.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.readerTypeSet.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.readerTypeSet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.readerTypeSet.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.readerTypeSet.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.readerTypeSet.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.readerTypeSet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.readerTypeSet.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.readerTypeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readerTypeSet.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.readerTypeSet.FillDropDown = true;
            this.readerTypeSet.FillIndicator = false;
            this.readerTypeSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readerTypeSet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readerTypeSet.ForeColor = System.Drawing.Color.Black;
            this.readerTypeSet.FormattingEnabled = true;
            this.readerTypeSet.Icon = null;
            this.readerTypeSet.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.readerTypeSet.IndicatorColor = System.Drawing.Color.Gray;
            this.readerTypeSet.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.readerTypeSet.ItemBackColor = System.Drawing.Color.White;
            this.readerTypeSet.ItemBorderColor = System.Drawing.Color.White;
            this.readerTypeSet.ItemForeColor = System.Drawing.Color.Black;
            this.readerTypeSet.ItemHeight = 26;
            this.readerTypeSet.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.readerTypeSet.ItemHighLightForeColor = System.Drawing.Color.White;
            this.readerTypeSet.ItemTopMargin = 3;
            this.readerTypeSet.Location = new System.Drawing.Point(62, 188);
            this.readerTypeSet.Name = "readerTypeSet";
            this.readerTypeSet.Size = new System.Drawing.Size(260, 32);
            this.readerTypeSet.TabIndex = 22;
            this.readerTypeSet.Text = null;
            this.readerTypeSet.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.readerTypeSet.TextLeftMargin = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(59, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reader Type";
            // 
            // birthDayTaker
            // 
            this.birthDayTaker.BackColor = System.Drawing.Color.White;
            this.birthDayTaker.BorderRadius = 1;
            this.birthDayTaker.Color = System.Drawing.Color.Silver;
            this.birthDayTaker.CustomFormat = "yyyy-MM-dd";
            this.birthDayTaker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.birthDayTaker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.birthDayTaker.DisabledColor = System.Drawing.Color.Gray;
            this.birthDayTaker.DisplayWeekNumbers = false;
            this.birthDayTaker.DPHeight = 0;
            this.birthDayTaker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.birthDayTaker.FillDatePicker = false;
            this.birthDayTaker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthDayTaker.ForeColor = System.Drawing.Color.Black;
            this.birthDayTaker.Icon = ((System.Drawing.Image)(resources.GetObject("birthDayTaker.Icon")));
            this.birthDayTaker.IconColor = System.Drawing.Color.Gray;
            this.birthDayTaker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.birthDayTaker.LeftTextMargin = 5;
            this.birthDayTaker.Location = new System.Drawing.Point(62, 374);
            this.birthDayTaker.MinimumSize = new System.Drawing.Size(4, 32);
            this.birthDayTaker.Name = "birthDayTaker";
            this.birthDayTaker.Size = new System.Drawing.Size(260, 32);
            this.birthDayTaker.TabIndex = 19;
            // 
            // saveBt
            // 
            this.saveBt.AllowAnimations = true;
            this.saveBt.AllowMouseEffects = true;
            this.saveBt.AllowToggling = false;
            this.saveBt.AnimationSpeed = 200;
            this.saveBt.AutoGenerateColors = false;
            this.saveBt.AutoRoundBorders = false;
            this.saveBt.AutoSizeLeftIcon = true;
            this.saveBt.AutoSizeRightIcon = true;
            this.saveBt.BackColor = System.Drawing.Color.Transparent;
            this.saveBt.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.saveBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBt.BackgroundImage")));
            this.saveBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBt.ButtonText = "save";
            this.saveBt.ButtonTextMarginLeft = 0;
            this.saveBt.ColorContrastOnClick = 45;
            this.saveBt.ColorContrastOnHover = 45;
            this.saveBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.saveBt.CustomizableEdges = borderEdges2;
            this.saveBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBt.ForeColor = System.Drawing.Color.White;
            this.saveBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveBt.IconMarginLeft = 11;
            this.saveBt.IconPadding = 10;
            this.saveBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveBt.IconSize = 25;
            this.saveBt.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.saveBt.IdleBorderRadius = 1;
            this.saveBt.IdleBorderThickness = 1;
            this.saveBt.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.saveBt.IdleIconLeftImage = null;
            this.saveBt.IdleIconRightImage = null;
            this.saveBt.IndicateFocus = false;
            this.saveBt.Location = new System.Drawing.Point(139, 435);
            this.saveBt.Name = "saveBt";
            this.saveBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBt.OnDisabledState.BorderRadius = 1;
            this.saveBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBt.OnDisabledState.BorderThickness = 1;
            this.saveBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBt.OnDisabledState.IconLeftImage = null;
            this.saveBt.OnDisabledState.IconRightImage = null;
            this.saveBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveBt.onHoverState.BorderRadius = 1;
            this.saveBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBt.onHoverState.BorderThickness = 1;
            this.saveBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveBt.onHoverState.IconLeftImage = null;
            this.saveBt.onHoverState.IconRightImage = null;
            this.saveBt.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.saveBt.OnIdleState.BorderRadius = 1;
            this.saveBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBt.OnIdleState.BorderThickness = 1;
            this.saveBt.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.saveBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveBt.OnIdleState.IconLeftImage = null;
            this.saveBt.OnIdleState.IconRightImage = null;
            this.saveBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveBt.OnPressedState.BorderRadius = 1;
            this.saveBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBt.OnPressedState.BorderThickness = 1;
            this.saveBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveBt.OnPressedState.IconLeftImage = null;
            this.saveBt.OnPressedState.IconRightImage = null;
            this.saveBt.Size = new System.Drawing.Size(96, 26);
            this.saveBt.TabIndex = 18;
            this.saveBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBt.TextMarginLeft = 0;
            this.saveBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveBt.UseDefaultRadiusAndThickness = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // emailTaker
            // 
            this.emailTaker.AcceptsReturn = false;
            this.emailTaker.AcceptsTab = false;
            this.emailTaker.AnimationSpeed = 200;
            this.emailTaker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailTaker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailTaker.BackColor = System.Drawing.Color.White;
            this.emailTaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailTaker.BackgroundImage")));
            this.emailTaker.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.emailTaker.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.emailTaker.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.emailTaker.BorderColorIdle = System.Drawing.Color.Silver;
            this.emailTaker.BorderRadius = 1;
            this.emailTaker.BorderThickness = 1;
            this.emailTaker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTaker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTaker.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.emailTaker.DefaultText = "";
            this.emailTaker.FillColor = System.Drawing.Color.White;
            this.emailTaker.HideSelection = true;
            this.emailTaker.IconLeft = null;
            this.emailTaker.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTaker.IconPadding = 10;
            this.emailTaker.IconRight = null;
            this.emailTaker.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTaker.Lines = new string[0];
            this.emailTaker.Location = new System.Drawing.Point(62, 298);
            this.emailTaker.MaxLength = 32767;
            this.emailTaker.MinimumSize = new System.Drawing.Size(1, 1);
            this.emailTaker.Modified = false;
            this.emailTaker.Multiline = false;
            this.emailTaker.Name = "emailTaker";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailTaker.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.emailTaker.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailTaker.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailTaker.OnIdleState = stateProperties16;
            this.emailTaker.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.emailTaker.PasswordChar = '\0';
            this.emailTaker.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailTaker.PlaceholderText = "Email";
            this.emailTaker.ReadOnly = false;
            this.emailTaker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTaker.SelectedText = "";
            this.emailTaker.SelectionLength = 0;
            this.emailTaker.SelectionStart = 0;
            this.emailTaker.ShortcutsEnabled = true;
            this.emailTaker.Size = new System.Drawing.Size(260, 37);
            this.emailTaker.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.emailTaker.TabIndex = 12;
            this.emailTaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTaker.TextMarginBottom = 0;
            this.emailTaker.TextMarginLeft = 3;
            this.emailTaker.TextMarginTop = 0;
            this.emailTaker.TextPlaceholder = "Email";
            this.emailTaker.UseSystemPasswordChar = false;
            this.emailTaker.WordWrap = true;
            // 
            // addressTaker
            // 
            this.addressTaker.AcceptsReturn = false;
            this.addressTaker.AcceptsTab = false;
            this.addressTaker.AnimationSpeed = 200;
            this.addressTaker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addressTaker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addressTaker.BackColor = System.Drawing.Color.White;
            this.addressTaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addressTaker.BackgroundImage")));
            this.addressTaker.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.addressTaker.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addressTaker.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addressTaker.BorderColorIdle = System.Drawing.Color.Silver;
            this.addressTaker.BorderRadius = 1;
            this.addressTaker.BorderThickness = 1;
            this.addressTaker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTaker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTaker.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.addressTaker.DefaultText = "";
            this.addressTaker.FillColor = System.Drawing.Color.White;
            this.addressTaker.HideSelection = true;
            this.addressTaker.IconLeft = null;
            this.addressTaker.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTaker.IconPadding = 10;
            this.addressTaker.IconRight = null;
            this.addressTaker.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTaker.Lines = new string[0];
            this.addressTaker.Location = new System.Drawing.Point(62, 240);
            this.addressTaker.MaxLength = 32767;
            this.addressTaker.MinimumSize = new System.Drawing.Size(1, 1);
            this.addressTaker.Modified = false;
            this.addressTaker.Multiline = false;
            this.addressTaker.Name = "addressTaker";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addressTaker.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.addressTaker.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addressTaker.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addressTaker.OnIdleState = stateProperties20;
            this.addressTaker.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addressTaker.PasswordChar = '\0';
            this.addressTaker.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.addressTaker.PlaceholderText = "Address";
            this.addressTaker.ReadOnly = false;
            this.addressTaker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressTaker.SelectedText = "";
            this.addressTaker.SelectionLength = 0;
            this.addressTaker.SelectionStart = 0;
            this.addressTaker.ShortcutsEnabled = true;
            this.addressTaker.Size = new System.Drawing.Size(260, 37);
            this.addressTaker.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.addressTaker.TabIndex = 11;
            this.addressTaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTaker.TextMarginBottom = 0;
            this.addressTaker.TextMarginLeft = 3;
            this.addressTaker.TextMarginTop = 0;
            this.addressTaker.TextPlaceholder = "Address";
            this.addressTaker.UseSystemPasswordChar = false;
            this.addressTaker.WordWrap = true;
            // 
            // nameTaker
            // 
            this.nameTaker.AcceptsReturn = false;
            this.nameTaker.AcceptsTab = false;
            this.nameTaker.AnimationSpeed = 200;
            this.nameTaker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTaker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTaker.BackColor = System.Drawing.Color.White;
            this.nameTaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTaker.BackgroundImage")));
            this.nameTaker.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.nameTaker.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nameTaker.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.nameTaker.BorderColorIdle = System.Drawing.Color.Silver;
            this.nameTaker.BorderRadius = 1;
            this.nameTaker.BorderThickness = 1;
            this.nameTaker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTaker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTaker.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nameTaker.DefaultText = "";
            this.nameTaker.FillColor = System.Drawing.Color.White;
            this.nameTaker.HideSelection = true;
            this.nameTaker.IconLeft = null;
            this.nameTaker.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTaker.IconPadding = 10;
            this.nameTaker.IconRight = null;
            this.nameTaker.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTaker.Lines = new string[0];
            this.nameTaker.Location = new System.Drawing.Point(62, 116);
            this.nameTaker.MaxLength = 32767;
            this.nameTaker.MinimumSize = new System.Drawing.Size(1, 1);
            this.nameTaker.Modified = false;
            this.nameTaker.Multiline = false;
            this.nameTaker.Name = "nameTaker";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTaker.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nameTaker.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTaker.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTaker.OnIdleState = stateProperties24;
            this.nameTaker.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.nameTaker.PasswordChar = '\0';
            this.nameTaker.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.nameTaker.PlaceholderText = "Name";
            this.nameTaker.ReadOnly = false;
            this.nameTaker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTaker.SelectedText = "";
            this.nameTaker.SelectionLength = 0;
            this.nameTaker.SelectionStart = 0;
            this.nameTaker.ShortcutsEnabled = true;
            this.nameTaker.Size = new System.Drawing.Size(260, 37);
            this.nameTaker.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.nameTaker.TabIndex = 9;
            this.nameTaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTaker.TextMarginBottom = 0;
            this.nameTaker.TextMarginLeft = 3;
            this.nameTaker.TextMarginTop = 0;
            this.nameTaker.TextPlaceholder = "Name";
            this.nameTaker.UseSystemPasswordChar = false;
            this.nameTaker.WordWrap = true;
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(378, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.readerTypeSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthDayTaker);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.emailTaker);
            this.Controls.Add(this.addressTaker);
            this.Controls.Add(this.nameTaker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReader";
            this.Text = "AddReader";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDatePicker birthDayTaker;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBt;
        private Bunifu.UI.WinForms.BunifuTextBox emailTaker;
        private Bunifu.UI.WinForms.BunifuTextBox addressTaker;
        private Bunifu.UI.WinForms.BunifuTextBox nameTaker;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown readerTypeSet;
        private System.Windows.Forms.Label label4;
    }
}