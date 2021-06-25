
namespace LibraryApp
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logOutBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.returnBookBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.issuedBookBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.readersBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.booksBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dashBoardBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1222, 61);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
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
            this.exitButton.ImageSize = new System.Drawing.Size(43, 45);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(48, 50);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(1163, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(48, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 5;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.sidePanel.Controls.Add(this.logOutBt);
            this.sidePanel.Controls.Add(this.returnBookBt);
            this.sidePanel.Controls.Add(this.issuedBookBt);
            this.sidePanel.Controls.Add(this.readersBt);
            this.sidePanel.Controls.Add(this.booksBt);
            this.sidePanel.Controls.Add(this.dashBoardBt);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 61);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(150, 547);
            this.sidePanel.TabIndex = 1;
            // 
            // logOutBt
            // 
            this.logOutBt.AllowAnimations = true;
            this.logOutBt.AllowMouseEffects = true;
            this.logOutBt.AllowToggling = false;
            this.logOutBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBt.AnimationSpeed = 200;
            this.logOutBt.AutoGenerateColors = false;
            this.logOutBt.AutoRoundBorders = false;
            this.logOutBt.AutoSizeLeftIcon = true;
            this.logOutBt.AutoSizeRightIcon = true;
            this.logOutBt.BackColor = System.Drawing.Color.Transparent;
            this.logOutBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.logOutBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutBt.BackgroundImage")));
            this.logOutBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logOutBt.ButtonText = "Log out";
            this.logOutBt.ButtonTextMarginLeft = 0;
            this.logOutBt.ColorContrastOnClick = 45;
            this.logOutBt.ColorContrastOnHover = 45;
            this.logOutBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.logOutBt.CustomizableEdges = borderEdges1;
            this.logOutBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logOutBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.logOutBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logOutBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.logOutBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.logOutBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logOutBt.ForeColor = System.Drawing.Color.White;
            this.logOutBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.logOutBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.logOutBt.IconMarginLeft = 11;
            this.logOutBt.IconPadding = 10;
            this.logOutBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.logOutBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.logOutBt.IconSize = 25;
            this.logOutBt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.logOutBt.IdleBorderRadius = 1;
            this.logOutBt.IdleBorderThickness = 1;
            this.logOutBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.logOutBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("logOutBt.IdleIconLeftImage")));
            this.logOutBt.IdleIconRightImage = null;
            this.logOutBt.IndicateFocus = false;
            this.logOutBt.Location = new System.Drawing.Point(0, 440);
            this.logOutBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.logOutBt.OnDisabledState.BorderRadius = 1;
            this.logOutBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logOutBt.OnDisabledState.BorderThickness = 1;
            this.logOutBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logOutBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.logOutBt.OnDisabledState.IconLeftImage = null;
            this.logOutBt.OnDisabledState.IconRightImage = null;
            this.logOutBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logOutBt.onHoverState.BorderRadius = 1;
            this.logOutBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logOutBt.onHoverState.BorderThickness = 1;
            this.logOutBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logOutBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.logOutBt.onHoverState.IconLeftImage = null;
            this.logOutBt.onHoverState.IconRightImage = null;
            this.logOutBt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.logOutBt.OnIdleState.BorderRadius = 1;
            this.logOutBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logOutBt.OnIdleState.BorderThickness = 1;
            this.logOutBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.logOutBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.logOutBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("logOutBt.OnIdleState.IconLeftImage")));
            this.logOutBt.OnIdleState.IconRightImage = null;
            this.logOutBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.logOutBt.OnPressedState.BorderRadius = 1;
            this.logOutBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.logOutBt.OnPressedState.BorderThickness = 1;
            this.logOutBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.logOutBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.logOutBt.OnPressedState.IconLeftImage = null;
            this.logOutBt.OnPressedState.IconRightImage = null;
            this.logOutBt.Size = new System.Drawing.Size(150, 33);
            this.logOutBt.TabIndex = 6;
            this.logOutBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOutBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.logOutBt.TextMarginLeft = 0;
            this.logOutBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.logOutBt.UseDefaultRadiusAndThickness = true;
            // 
            // returnBookBt
            // 
            this.returnBookBt.AllowAnimations = true;
            this.returnBookBt.AllowMouseEffects = true;
            this.returnBookBt.AllowToggling = false;
            this.returnBookBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.returnBookBt.AnimationSpeed = 200;
            this.returnBookBt.AutoGenerateColors = false;
            this.returnBookBt.AutoRoundBorders = false;
            this.returnBookBt.AutoSizeLeftIcon = true;
            this.returnBookBt.AutoSizeRightIcon = true;
            this.returnBookBt.BackColor = System.Drawing.Color.Transparent;
            this.returnBookBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.returnBookBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBookBt.BackgroundImage")));
            this.returnBookBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnBookBt.ButtonText = "Return book";
            this.returnBookBt.ButtonTextMarginLeft = 0;
            this.returnBookBt.ColorContrastOnClick = 45;
            this.returnBookBt.ColorContrastOnHover = 45;
            this.returnBookBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.returnBookBt.CustomizableEdges = borderEdges2;
            this.returnBookBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.returnBookBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.returnBookBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnBookBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.returnBookBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.returnBookBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnBookBt.ForeColor = System.Drawing.Color.White;
            this.returnBookBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBookBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.returnBookBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.returnBookBt.IconMarginLeft = 11;
            this.returnBookBt.IconPadding = 10;
            this.returnBookBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnBookBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.returnBookBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.returnBookBt.IconSize = 25;
            this.returnBookBt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.returnBookBt.IdleBorderRadius = 1;
            this.returnBookBt.IdleBorderThickness = 1;
            this.returnBookBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.returnBookBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("returnBookBt.IdleIconLeftImage")));
            this.returnBookBt.IdleIconRightImage = null;
            this.returnBookBt.IndicateFocus = false;
            this.returnBookBt.Location = new System.Drawing.Point(-4, 393);
            this.returnBookBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBookBt.Name = "returnBookBt";
            this.returnBookBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.returnBookBt.OnDisabledState.BorderRadius = 1;
            this.returnBookBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnBookBt.OnDisabledState.BorderThickness = 1;
            this.returnBookBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnBookBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.returnBookBt.OnDisabledState.IconLeftImage = null;
            this.returnBookBt.OnDisabledState.IconRightImage = null;
            this.returnBookBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.returnBookBt.onHoverState.BorderRadius = 1;
            this.returnBookBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnBookBt.onHoverState.BorderThickness = 1;
            this.returnBookBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.returnBookBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.returnBookBt.onHoverState.IconLeftImage = null;
            this.returnBookBt.onHoverState.IconRightImage = null;
            this.returnBookBt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.returnBookBt.OnIdleState.BorderRadius = 1;
            this.returnBookBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnBookBt.OnIdleState.BorderThickness = 1;
            this.returnBookBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.returnBookBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.returnBookBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("returnBookBt.OnIdleState.IconLeftImage")));
            this.returnBookBt.OnIdleState.IconRightImage = null;
            this.returnBookBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.returnBookBt.OnPressedState.BorderRadius = 1;
            this.returnBookBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnBookBt.OnPressedState.BorderThickness = 1;
            this.returnBookBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.returnBookBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.returnBookBt.OnPressedState.IconLeftImage = null;
            this.returnBookBt.OnPressedState.IconRightImage = null;
            this.returnBookBt.Size = new System.Drawing.Size(150, 33);
            this.returnBookBt.TabIndex = 5;
            this.returnBookBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnBookBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.returnBookBt.TextMarginLeft = 0;
            this.returnBookBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.returnBookBt.UseDefaultRadiusAndThickness = true;
            this.returnBookBt.Click += new System.EventHandler(this.returnBookBt_Click);
            // 
            // issuedBookBt
            // 
            this.issuedBookBt.AllowAnimations = true;
            this.issuedBookBt.AllowMouseEffects = true;
            this.issuedBookBt.AllowToggling = false;
            this.issuedBookBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.issuedBookBt.AnimationSpeed = 200;
            this.issuedBookBt.AutoGenerateColors = false;
            this.issuedBookBt.AutoRoundBorders = false;
            this.issuedBookBt.AutoSizeLeftIcon = true;
            this.issuedBookBt.AutoSizeRightIcon = true;
            this.issuedBookBt.BackColor = System.Drawing.Color.Transparent;
            this.issuedBookBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.issuedBookBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("issuedBookBt.BackgroundImage")));
            this.issuedBookBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.issuedBookBt.ButtonText = "Issued Book";
            this.issuedBookBt.ButtonTextMarginLeft = 0;
            this.issuedBookBt.ColorContrastOnClick = 45;
            this.issuedBookBt.ColorContrastOnHover = 45;
            this.issuedBookBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.issuedBookBt.CustomizableEdges = borderEdges3;
            this.issuedBookBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.issuedBookBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.issuedBookBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.issuedBookBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.issuedBookBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.issuedBookBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.issuedBookBt.ForeColor = System.Drawing.Color.White;
            this.issuedBookBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuedBookBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.issuedBookBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.issuedBookBt.IconMarginLeft = 11;
            this.issuedBookBt.IconPadding = 10;
            this.issuedBookBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issuedBookBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.issuedBookBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.issuedBookBt.IconSize = 25;
            this.issuedBookBt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.issuedBookBt.IdleBorderRadius = 1;
            this.issuedBookBt.IdleBorderThickness = 1;
            this.issuedBookBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.issuedBookBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("issuedBookBt.IdleIconLeftImage")));
            this.issuedBookBt.IdleIconRightImage = null;
            this.issuedBookBt.IndicateFocus = false;
            this.issuedBookBt.Location = new System.Drawing.Point(-2, 347);
            this.issuedBookBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issuedBookBt.Name = "issuedBookBt";
            this.issuedBookBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.issuedBookBt.OnDisabledState.BorderRadius = 1;
            this.issuedBookBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.issuedBookBt.OnDisabledState.BorderThickness = 1;
            this.issuedBookBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.issuedBookBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.issuedBookBt.OnDisabledState.IconLeftImage = null;
            this.issuedBookBt.OnDisabledState.IconRightImage = null;
            this.issuedBookBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.issuedBookBt.onHoverState.BorderRadius = 1;
            this.issuedBookBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.issuedBookBt.onHoverState.BorderThickness = 1;
            this.issuedBookBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.issuedBookBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.issuedBookBt.onHoverState.IconLeftImage = null;
            this.issuedBookBt.onHoverState.IconRightImage = null;
            this.issuedBookBt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.issuedBookBt.OnIdleState.BorderRadius = 1;
            this.issuedBookBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.issuedBookBt.OnIdleState.BorderThickness = 1;
            this.issuedBookBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.issuedBookBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.issuedBookBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("issuedBookBt.OnIdleState.IconLeftImage")));
            this.issuedBookBt.OnIdleState.IconRightImage = null;
            this.issuedBookBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.issuedBookBt.OnPressedState.BorderRadius = 1;
            this.issuedBookBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.issuedBookBt.OnPressedState.BorderThickness = 1;
            this.issuedBookBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.issuedBookBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.issuedBookBt.OnPressedState.IconLeftImage = null;
            this.issuedBookBt.OnPressedState.IconRightImage = null;
            this.issuedBookBt.Size = new System.Drawing.Size(150, 33);
            this.issuedBookBt.TabIndex = 2;
            this.issuedBookBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.issuedBookBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.issuedBookBt.TextMarginLeft = 0;
            this.issuedBookBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.issuedBookBt.UseDefaultRadiusAndThickness = true;
            this.issuedBookBt.Click += new System.EventHandler(this.issuedBookBt_Click);
            // 
            // readersBt
            // 
            this.readersBt.AllowAnimations = true;
            this.readersBt.AllowMouseEffects = true;
            this.readersBt.AllowToggling = false;
            this.readersBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.readersBt.AnimationSpeed = 200;
            this.readersBt.AutoGenerateColors = false;
            this.readersBt.AutoRoundBorders = false;
            this.readersBt.AutoSizeLeftIcon = true;
            this.readersBt.AutoSizeRightIcon = true;
            this.readersBt.BackColor = System.Drawing.Color.Transparent;
            this.readersBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.readersBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("readersBt.BackgroundImage")));
            this.readersBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.readersBt.ButtonText = "Readers";
            this.readersBt.ButtonTextMarginLeft = 0;
            this.readersBt.ColorContrastOnClick = 45;
            this.readersBt.ColorContrastOnHover = 45;
            this.readersBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.readersBt.CustomizableEdges = borderEdges4;
            this.readersBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.readersBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.readersBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.readersBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.readersBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.readersBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readersBt.ForeColor = System.Drawing.Color.White;
            this.readersBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.readersBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.readersBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.readersBt.IconMarginLeft = 11;
            this.readersBt.IconPadding = 10;
            this.readersBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.readersBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.readersBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.readersBt.IconSize = 25;
            this.readersBt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.readersBt.IdleBorderRadius = 1;
            this.readersBt.IdleBorderThickness = 1;
            this.readersBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.readersBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("readersBt.IdleIconLeftImage")));
            this.readersBt.IdleIconRightImage = null;
            this.readersBt.IndicateFocus = false;
            this.readersBt.Location = new System.Drawing.Point(-2, 301);
            this.readersBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readersBt.Name = "readersBt";
            this.readersBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.readersBt.OnDisabledState.BorderRadius = 1;
            this.readersBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.readersBt.OnDisabledState.BorderThickness = 1;
            this.readersBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.readersBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.readersBt.OnDisabledState.IconLeftImage = null;
            this.readersBt.OnDisabledState.IconRightImage = null;
            this.readersBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.readersBt.onHoverState.BorderRadius = 1;
            this.readersBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.readersBt.onHoverState.BorderThickness = 1;
            this.readersBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.readersBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.readersBt.onHoverState.IconLeftImage = null;
            this.readersBt.onHoverState.IconRightImage = null;
            this.readersBt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.readersBt.OnIdleState.BorderRadius = 1;
            this.readersBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.readersBt.OnIdleState.BorderThickness = 1;
            this.readersBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.readersBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.readersBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("readersBt.OnIdleState.IconLeftImage")));
            this.readersBt.OnIdleState.IconRightImage = null;
            this.readersBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.readersBt.OnPressedState.BorderRadius = 1;
            this.readersBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.readersBt.OnPressedState.BorderThickness = 1;
            this.readersBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.readersBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.readersBt.OnPressedState.IconLeftImage = null;
            this.readersBt.OnPressedState.IconRightImage = null;
            this.readersBt.Size = new System.Drawing.Size(150, 33);
            this.readersBt.TabIndex = 3;
            this.readersBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.readersBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.readersBt.TextMarginLeft = 0;
            this.readersBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.readersBt.UseDefaultRadiusAndThickness = true;
            this.readersBt.Click += new System.EventHandler(this.readersBt_Click);
            // 
            // booksBt
            // 
            this.booksBt.AllowAnimations = true;
            this.booksBt.AllowMouseEffects = true;
            this.booksBt.AllowToggling = false;
            this.booksBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.booksBt.AnimationSpeed = 200;
            this.booksBt.AutoGenerateColors = false;
            this.booksBt.AutoRoundBorders = false;
            this.booksBt.AutoSizeLeftIcon = true;
            this.booksBt.AutoSizeRightIcon = true;
            this.booksBt.BackColor = System.Drawing.Color.Transparent;
            this.booksBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.booksBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("booksBt.BackgroundImage")));
            this.booksBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.booksBt.ButtonText = "Books";
            this.booksBt.ButtonTextMarginLeft = 0;
            this.booksBt.ColorContrastOnClick = 45;
            this.booksBt.ColorContrastOnHover = 45;
            this.booksBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.booksBt.CustomizableEdges = borderEdges5;
            this.booksBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.booksBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.booksBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.booksBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.booksBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.booksBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.booksBt.ForeColor = System.Drawing.Color.White;
            this.booksBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.booksBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.booksBt.IconMarginLeft = 11;
            this.booksBt.IconPadding = 10;
            this.booksBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.booksBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.booksBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.booksBt.IconSize = 25;
            this.booksBt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.booksBt.IdleBorderRadius = 1;
            this.booksBt.IdleBorderThickness = 1;
            this.booksBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.booksBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("booksBt.IdleIconLeftImage")));
            this.booksBt.IdleIconRightImage = null;
            this.booksBt.IndicateFocus = false;
            this.booksBt.Location = new System.Drawing.Point(-2, 254);
            this.booksBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.booksBt.Name = "booksBt";
            this.booksBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.booksBt.OnDisabledState.BorderRadius = 1;
            this.booksBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.booksBt.OnDisabledState.BorderThickness = 1;
            this.booksBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.booksBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.booksBt.OnDisabledState.IconLeftImage = null;
            this.booksBt.OnDisabledState.IconRightImage = null;
            this.booksBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.booksBt.onHoverState.BorderRadius = 1;
            this.booksBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.booksBt.onHoverState.BorderThickness = 1;
            this.booksBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.booksBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.booksBt.onHoverState.IconLeftImage = null;
            this.booksBt.onHoverState.IconRightImage = null;
            this.booksBt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.booksBt.OnIdleState.BorderRadius = 1;
            this.booksBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.booksBt.OnIdleState.BorderThickness = 1;
            this.booksBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.booksBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.booksBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("booksBt.OnIdleState.IconLeftImage")));
            this.booksBt.OnIdleState.IconRightImage = null;
            this.booksBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.booksBt.OnPressedState.BorderRadius = 1;
            this.booksBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.booksBt.OnPressedState.BorderThickness = 1;
            this.booksBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.booksBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.booksBt.OnPressedState.IconLeftImage = null;
            this.booksBt.OnPressedState.IconRightImage = null;
            this.booksBt.Size = new System.Drawing.Size(150, 33);
            this.booksBt.TabIndex = 2;
            this.booksBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.booksBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.booksBt.TextMarginLeft = 0;
            this.booksBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.booksBt.UseDefaultRadiusAndThickness = true;
            this.booksBt.Click += new System.EventHandler(this.booksBt_Click);
            // 
            // dashBoardBt
            // 
            this.dashBoardBt.AllowAnimations = true;
            this.dashBoardBt.AllowMouseEffects = true;
            this.dashBoardBt.AllowToggling = false;
            this.dashBoardBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dashBoardBt.AnimationSpeed = 200;
            this.dashBoardBt.AutoGenerateColors = false;
            this.dashBoardBt.AutoRoundBorders = false;
            this.dashBoardBt.AutoSizeLeftIcon = true;
            this.dashBoardBt.AutoSizeRightIcon = true;
            this.dashBoardBt.BackColor = System.Drawing.Color.Transparent;
            this.dashBoardBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.dashBoardBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashBoardBt.BackgroundImage")));
            this.dashBoardBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.dashBoardBt.ButtonText = "Dashboard";
            this.dashBoardBt.ButtonTextMarginLeft = 0;
            this.dashBoardBt.ColorContrastOnClick = 45;
            this.dashBoardBt.ColorContrastOnHover = 45;
            this.dashBoardBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.dashBoardBt.CustomizableEdges = borderEdges6;
            this.dashBoardBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dashBoardBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dashBoardBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dashBoardBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.dashBoardBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.dashBoardBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashBoardBt.ForeColor = System.Drawing.Color.White;
            this.dashBoardBt.IconLeftAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashBoardBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.dashBoardBt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.dashBoardBt.IconMarginLeft = 11;
            this.dashBoardBt.IconPadding = 10;
            this.dashBoardBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashBoardBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.dashBoardBt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dashBoardBt.IconSize = 50;
            this.dashBoardBt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.dashBoardBt.IdleBorderRadius = 1;
            this.dashBoardBt.IdleBorderThickness = 1;
            this.dashBoardBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.dashBoardBt.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("dashBoardBt.IdleIconLeftImage")));
            this.dashBoardBt.IdleIconRightImage = null;
            this.dashBoardBt.IndicateFocus = false;
            this.dashBoardBt.Location = new System.Drawing.Point(-2, 199);
            this.dashBoardBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashBoardBt.Name = "dashBoardBt";
            this.dashBoardBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dashBoardBt.OnDisabledState.BorderRadius = 1;
            this.dashBoardBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.dashBoardBt.OnDisabledState.BorderThickness = 1;
            this.dashBoardBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dashBoardBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.dashBoardBt.OnDisabledState.IconLeftImage = null;
            this.dashBoardBt.OnDisabledState.IconRightImage = null;
            this.dashBoardBt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.dashBoardBt.onHoverState.BorderRadius = 1;
            this.dashBoardBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.dashBoardBt.onHoverState.BorderThickness = 1;
            this.dashBoardBt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.dashBoardBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.dashBoardBt.onHoverState.IconLeftImage = null;
            this.dashBoardBt.onHoverState.IconRightImage = null;
            this.dashBoardBt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.dashBoardBt.OnIdleState.BorderRadius = 1;
            this.dashBoardBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.dashBoardBt.OnIdleState.BorderThickness = 1;
            this.dashBoardBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.dashBoardBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.dashBoardBt.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("dashBoardBt.OnIdleState.IconLeftImage")));
            this.dashBoardBt.OnIdleState.IconRightImage = null;
            this.dashBoardBt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.dashBoardBt.OnPressedState.BorderRadius = 1;
            this.dashBoardBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.dashBoardBt.OnPressedState.BorderThickness = 1;
            this.dashBoardBt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.dashBoardBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.dashBoardBt.OnPressedState.IconLeftImage = null;
            this.dashBoardBt.OnPressedState.IconRightImage = null;
            this.dashBoardBt.Size = new System.Drawing.Size(150, 33);
            this.dashBoardBt.TabIndex = 1;
            this.dashBoardBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashBoardBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashBoardBt.TextMarginLeft = 0;
            this.dashBoardBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.dashBoardBt.UseDefaultRadiusAndThickness = true;
            this.dashBoardBt.Click += new System.EventHandler(this.dashBoardBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LibraryApp.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(25, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(150, 61);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1072, 547);
            this.mainPanel.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 608);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton issuedBookBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton readersBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton booksBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton dashBoardBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton returnBookBt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton logOutBt;
    }
}