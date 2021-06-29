
namespace LibraryApp
{
    partial class UserMainScreen
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainScreen));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logOutBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.readersBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.booksBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(150, 61);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1017, 509);
            this.mainPanel.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.bunifuImageButton1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(150, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1017, 61);
            this.topPanel.TabIndex = 3;
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
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.sidePanel.Controls.Add(this.logOutBt);
            this.sidePanel.Controls.Add(this.readersBt);
            this.sidePanel.Controls.Add(this.booksBt);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(150, 570);
            this.sidePanel.TabIndex = 4;
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
            this.logOutBt.Location = new System.Drawing.Point(-2, 362);
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
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.readersBt.CustomizableEdges = borderEdges2;
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
            this.readersBt.Location = new System.Drawing.Point(-2, 312);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.booksBt.CustomizableEdges = borderEdges3;
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
            this.booksBt.Location = new System.Drawing.Point(-2, 266);
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
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::LibraryApp.Properties.Resources.exit;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 5;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(43, 45);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(48, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(958, 11);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(48, 50);
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 5;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // UserMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 570);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserMainScreen";
            this.Text = "UserMainScreen";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton logOutBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton readersBt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton booksBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}