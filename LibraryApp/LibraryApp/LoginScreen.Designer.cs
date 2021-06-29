
namespace LibraryApp
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.LoginDragPanel = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LoginDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordTaker = new Bunifu.UI.WinForms.BunifuTextBox();
            this.userNameTaker = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginDragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginDragPanel
            // 
            this.LoginDragPanel.BackColor = System.Drawing.Color.Black;
            this.LoginDragPanel.Controls.Add(this.bunifuLabel1);
            this.LoginDragPanel.Controls.Add(this.exitButton);
            this.LoginDragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginDragPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginDragPanel.Name = "LoginDragPanel";
            this.LoginDragPanel.Size = new System.Drawing.Size(420, 85);
            this.LoginDragPanel.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(26, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(67, 37);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Login";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.exitButton.ImageSize = new System.Drawing.Size(42, 44);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(47, 49);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(357, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(47, 49);
            this.exitButton.TabIndex = 0;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 5;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LoginDrag
            // 
            this.LoginDrag.Fixed = true;
            this.LoginDrag.Horizontal = true;
            this.LoginDrag.TargetControl = this.LoginDragPanel;
            this.LoginDrag.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIGN UP HERE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginBt
            // 
            this.loginBt.ActiveBorderThickness = 1;
            this.loginBt.ActiveCornerRadius = 20;
            this.loginBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginBt.ActiveForecolor = System.Drawing.Color.White;
            this.loginBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginBt.BackColor = System.Drawing.Color.White;
            this.loginBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBt.BackgroundImage")));
            this.loginBt.ButtonText = "Login";
            this.loginBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginBt.IdleBorderThickness = 1;
            this.loginBt.IdleCornerRadius = 20;
            this.loginBt.IdleFillColor = System.Drawing.Color.White;
            this.loginBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.loginBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginBt.Location = new System.Drawing.Point(111, 391);
            this.loginBt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(204, 41);
            this.loginBt.TabIndex = 4;
            this.loginBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // passwordTaker
            // 
            this.passwordTaker.AcceptsReturn = false;
            this.passwordTaker.AcceptsTab = false;
            this.passwordTaker.AnimationSpeed = 200;
            this.passwordTaker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTaker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTaker.BackColor = System.Drawing.Color.White;
            this.passwordTaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTaker.BackgroundImage")));
            this.passwordTaker.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passwordTaker.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTaker.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordTaker.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordTaker.BorderRadius = 1;
            this.passwordTaker.BorderThickness = 1;
            this.passwordTaker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTaker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTaker.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passwordTaker.DefaultText = "";
            this.passwordTaker.FillColor = System.Drawing.Color.White;
            this.passwordTaker.HideSelection = true;
            this.passwordTaker.IconLeft = null;
            this.passwordTaker.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTaker.IconPadding = 10;
            this.passwordTaker.IconRight = null;
            this.passwordTaker.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTaker.Lines = new string[0];
            this.passwordTaker.Location = new System.Drawing.Point(72, 327);
            this.passwordTaker.MaxLength = 32767;
            this.passwordTaker.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordTaker.Modified = false;
            this.passwordTaker.Multiline = false;
            this.passwordTaker.Name = "passwordTaker";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTaker.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordTaker.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTaker.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTaker.OnIdleState = stateProperties4;
            this.passwordTaker.Padding = new System.Windows.Forms.Padding(3);
            this.passwordTaker.PasswordChar = '●';
            this.passwordTaker.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTaker.PlaceholderText = "Password";
            this.passwordTaker.ReadOnly = false;
            this.passwordTaker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTaker.SelectedText = "";
            this.passwordTaker.SelectionLength = 0;
            this.passwordTaker.SelectionStart = 0;
            this.passwordTaker.ShortcutsEnabled = true;
            this.passwordTaker.Size = new System.Drawing.Size(292, 37);
            this.passwordTaker.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.passwordTaker.TabIndex = 3;
            this.passwordTaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTaker.TextMarginBottom = 0;
            this.passwordTaker.TextMarginLeft = 3;
            this.passwordTaker.TextMarginTop = 0;
            this.passwordTaker.TextPlaceholder = "Password";
            this.passwordTaker.UseSystemPasswordChar = true;
            this.passwordTaker.WordWrap = true;
            this.passwordTaker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTaker_KeyPress);
            // 
            // userNameTaker
            // 
            this.userNameTaker.AcceptsReturn = false;
            this.userNameTaker.AcceptsTab = false;
            this.userNameTaker.AnimationSpeed = 200;
            this.userNameTaker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNameTaker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNameTaker.BackColor = System.Drawing.Color.White;
            this.userNameTaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNameTaker.BackgroundImage")));
            this.userNameTaker.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.userNameTaker.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameTaker.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userNameTaker.BorderColorIdle = System.Drawing.Color.Silver;
            this.userNameTaker.BorderRadius = 1;
            this.userNameTaker.BorderThickness = 1;
            this.userNameTaker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userNameTaker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTaker.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.userNameTaker.DefaultText = "";
            this.userNameTaker.FillColor = System.Drawing.Color.White;
            this.userNameTaker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameTaker.HideSelection = true;
            this.userNameTaker.IconLeft = null;
            this.userNameTaker.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTaker.IconPadding = 10;
            this.userNameTaker.IconRight = null;
            this.userNameTaker.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTaker.Lines = new string[0];
            this.userNameTaker.Location = new System.Drawing.Point(72, 270);
            this.userNameTaker.MaxLength = 32767;
            this.userNameTaker.MinimumSize = new System.Drawing.Size(1, 1);
            this.userNameTaker.Modified = false;
            this.userNameTaker.Multiline = false;
            this.userNameTaker.Name = "userNameTaker";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTaker.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.userNameTaker.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTaker.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTaker.OnIdleState = stateProperties8;
            this.userNameTaker.Padding = new System.Windows.Forms.Padding(3);
            this.userNameTaker.PasswordChar = '\0';
            this.userNameTaker.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTaker.PlaceholderText = "User";
            this.userNameTaker.ReadOnly = false;
            this.userNameTaker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTaker.SelectedText = "";
            this.userNameTaker.SelectionLength = 0;
            this.userNameTaker.SelectionStart = 0;
            this.userNameTaker.ShortcutsEnabled = true;
            this.userNameTaker.Size = new System.Drawing.Size(292, 37);
            this.userNameTaker.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.userNameTaker.TabIndex = 2;
            this.userNameTaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTaker.TextMarginBottom = 0;
            this.userNameTaker.TextMarginLeft = 3;
            this.userNameTaker.TextMarginTop = 0;
            this.userNameTaker.TextPlaceholder = "User";
            this.userNameTaker.UseSystemPasswordChar = false;
            this.userNameTaker.WordWrap = true;
            this.userNameTaker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTaker_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryApp.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(142, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.passwordTaker);
            this.Controls.Add(this.userNameTaker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginDragPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginScreen_KeyPress);
            this.LoginDragPanel.ResumeLayout(false);
            this.LoginDragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginDragPanel;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuDragControl LoginDrag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox userNameTaker;
        private Bunifu.UI.WinForms.BunifuTextBox passwordTaker;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

