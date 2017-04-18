namespace Nursery_Production_Software
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stylMan = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lnkSystem = new MetroFramework.Controls.MetroLink();
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.plSystem = new MetroFramework.Controls.MetroPanel();
            this.lnLogout = new MetroFramework.Controls.MetroLink();
            this.lnLock = new MetroFramework.Controls.MetroLink();
            this.lnExit = new MetroFramework.Controls.MetroLink();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDBPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDBUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.lblHost = new MetroFramework.Controls.MetroLabel();
            this.lblDb = new MetroFramework.Controls.MetroLabel();
            this.txtDb = new MetroFramework.Controls.MetroTextBox();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.stylMan)).BeginInit();
            this.plSystem.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpConnection.SuspendLayout();
            this.mtpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylMan
            // 
            this.stylMan.Owner = this;
            // 
            // lnkSystem
            // 
            this.lnkSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSystem.Image = ((System.Drawing.Image)(resources.GetObject("lnkSystem.Image")));
            this.lnkSystem.ImageSize = 32;
            this.lnkSystem.Location = new System.Drawing.Point(1138, 8);
            this.lnkSystem.Name = "lnkSystem";
            this.lnkSystem.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkSystem.NoFocusImage")));
            this.lnkSystem.Size = new System.Drawing.Size(42, 39);
            this.lnkSystem.TabIndex = 13;
            this.lnkSystem.UseSelectable = true;
            this.lnkSystem.Click += new System.EventHandler(this.lnkSystem_Click);
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSettings.Image = ((System.Drawing.Image)(resources.GetObject("lnkSettings.Image")));
            this.lnkSettings.ImageSize = 32;
            this.lnkSettings.Location = new System.Drawing.Point(1186, 8);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkSettings.NoFocusImage")));
            this.lnkSettings.Size = new System.Drawing.Size(42, 39);
            this.lnkSettings.TabIndex = 14;
            this.lnkSettings.UseSelectable = true;
            this.lnkSettings.Click += new System.EventHandler(this.lnkSettings_Click);
            // 
            // plSystem
            // 
            this.plSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSystem.Controls.Add(this.lnLogout);
            this.plSystem.Controls.Add(this.lnLock);
            this.plSystem.Controls.Add(this.lnExit);
            this.plSystem.HorizontalScrollbarBarColor = true;
            this.plSystem.HorizontalScrollbarHighlightOnWheel = false;
            this.plSystem.HorizontalScrollbarSize = 10;
            this.plSystem.Location = new System.Drawing.Point(1105, 53);
            this.plSystem.Name = "plSystem";
            this.plSystem.Size = new System.Drawing.Size(123, 92);
            this.plSystem.TabIndex = 15;
            this.plSystem.VerticalScrollbarBarColor = true;
            this.plSystem.VerticalScrollbarHighlightOnWheel = false;
            this.plSystem.VerticalScrollbarSize = 10;
            this.plSystem.Visible = false;
            this.plSystem.Leave += new System.EventHandler(this.plSystem_Leave);
            // 
            // lnLogout
            // 
            this.lnLogout.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnLogout.Image = ((System.Drawing.Image)(resources.GetObject("lnLogout.Image")));
            this.lnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnLogout.ImageSize = 24;
            this.lnLogout.Location = new System.Drawing.Point(10, 32);
            this.lnLogout.Name = "lnLogout";
            this.lnLogout.Size = new System.Drawing.Size(110, 23);
            this.lnLogout.TabIndex = 4;
            this.lnLogout.Text = "LOGOUT";
            this.lnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnLogout.UseSelectable = true;
            this.lnLogout.Click += new System.EventHandler(this.lnLogout_Click);
            // 
            // lnLock
            // 
            this.lnLock.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnLock.Image = ((System.Drawing.Image)(resources.GetObject("lnLock.Image")));
            this.lnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnLock.ImageSize = 24;
            this.lnLock.Location = new System.Drawing.Point(4, 3);
            this.lnLock.Name = "lnLock";
            this.lnLock.Size = new System.Drawing.Size(112, 23);
            this.lnLock.TabIndex = 3;
            this.lnLock.Text = "LOCK";
            this.lnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnLock.UseSelectable = true;
            // 
            // lnExit
            // 
            this.lnExit.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnExit.Image = ((System.Drawing.Image)(resources.GetObject("lnExit.Image")));
            this.lnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnExit.ImageSize = 24;
            this.lnExit.Location = new System.Drawing.Point(6, 60);
            this.lnExit.Name = "lnExit";
            this.lnExit.Size = new System.Drawing.Size(112, 26);
            this.lnExit.TabIndex = 2;
            this.lnExit.Text = "EXIT";
            this.lnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnExit.UseSelectable = true;
            this.lnExit.Click += new System.EventHandler(this.lnExit_Click);
            // 
            // mtcSettings
            // 
            this.mtcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Controls.Add(this.mtpTheme);
            this.mtcSettings.Location = new System.Drawing.Point(13, 57);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 1;
            this.mtcSettings.Size = new System.Drawing.Size(1209, 674);
            this.mtcSettings.TabIndex = 16;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.Controls.Add(this.metroLabel5);
            this.mtpConnection.Controls.Add(this.txtDBPass);
            this.mtpConnection.Controls.Add(this.metroLabel4);
            this.mtpConnection.Controls.Add(this.txtDBUser);
            this.mtpConnection.Controls.Add(this.metroLabel3);
            this.mtpConnection.Controls.Add(this.lblPort);
            this.mtpConnection.Controls.Add(this.lblHost);
            this.mtpConnection.Controls.Add(this.lblDb);
            this.mtpConnection.Controls.Add(this.txtDb);
            this.mtpConnection.Controls.Add(this.txtPort);
            this.mtpConnection.Controls.Add(this.txtHost);
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 35);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(229, 363);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&connection";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(3, 293);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Password:";
            // 
            // txtDBPass
            // 
            this.txtDBPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDBPass.CustomButton.Image = null;
            this.txtDBPass.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtDBPass.CustomButton.Name = "";
            this.txtDBPass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDBPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBPass.CustomButton.TabIndex = 1;
            this.txtDBPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBPass.CustomButton.UseSelectable = true;
            this.txtDBPass.CustomButton.Visible = false;
            this.txtDBPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDBPass.Lines = new string[0];
            this.txtDBPass.Location = new System.Drawing.Point(3, 321);
            this.txtDBPass.MaxLength = 32767;
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.PasswordChar = '*';
            this.txtDBPass.PromptText = "Optional";
            this.txtDBPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBPass.SelectedText = "";
            this.txtDBPass.SelectionLength = 0;
            this.txtDBPass.SelectionStart = 0;
            this.txtDBPass.ShortcutsEnabled = true;
            this.txtDBPass.Size = new System.Drawing.Size(209, 30);
            this.txtDBPass.TabIndex = 21;
            this.txtDBPass.UseSelectable = true;
            this.txtDBPass.WaterMark = "Optional";
            this.txtDBPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(3, 232);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Username:";
            // 
            // txtDBUser
            // 
            this.txtDBUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDBUser.CustomButton.Image = null;
            this.txtDBUser.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtDBUser.CustomButton.Name = "";
            this.txtDBUser.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDBUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBUser.CustomButton.TabIndex = 1;
            this.txtDBUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBUser.CustomButton.UseSelectable = true;
            this.txtDBUser.CustomButton.Visible = false;
            this.txtDBUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDBUser.Lines = new string[0];
            this.txtDBUser.Location = new System.Drawing.Point(3, 260);
            this.txtDBUser.MaxLength = 32767;
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.PasswordChar = '\0';
            this.txtDBUser.PromptText = "Optional";
            this.txtDBUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBUser.SelectedText = "";
            this.txtDBUser.SelectionLength = 0;
            this.txtDBUser.SelectionStart = 0;
            this.txtDBUser.ShortcutsEnabled = true;
            this.txtDBUser.Size = new System.Drawing.Size(209, 30);
            this.txtDBUser.TabIndex = 19;
            this.txtDBUser.UseSelectable = true;
            this.txtDBUser.WaterMark = "Optional";
            this.txtDBUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(0, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(226, 39);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "System Database Setup";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPort.AutoSize = true;
            this.lblPort.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPort.Location = new System.Drawing.Point(3, 110);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 25);
            this.lblPort.TabIndex = 17;
            this.lblPort.Text = "Port:";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHost.AutoSize = true;
            this.lblHost.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHost.Location = new System.Drawing.Point(3, 49);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(65, 25);
            this.lblHost.TabIndex = 16;
            this.lblHost.Text = "Server:";
            // 
            // lblDb
            // 
            this.lblDb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDb.AutoSize = true;
            this.lblDb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDb.Location = new System.Drawing.Point(3, 171);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(86, 25);
            this.lblDb.TabIndex = 15;
            this.lblDb.Text = "Database:";
            // 
            // txtDb
            // 
            this.txtDb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDb.CustomButton.Image = null;
            this.txtDb.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtDb.CustomButton.Name = "";
            this.txtDb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDb.CustomButton.TabIndex = 1;
            this.txtDb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDb.CustomButton.UseSelectable = true;
            this.txtDb.CustomButton.Visible = false;
            this.txtDb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDb.Lines = new string[0];
            this.txtDb.Location = new System.Drawing.Point(3, 199);
            this.txtDb.MaxLength = 32767;
            this.txtDb.Name = "txtDb";
            this.txtDb.PasswordChar = '\0';
            this.txtDb.PromptText = "JANS";
            this.txtDb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDb.SelectedText = "";
            this.txtDb.SelectionLength = 0;
            this.txtDb.SelectionStart = 0;
            this.txtDb.ShortcutsEnabled = true;
            this.txtDb.Size = new System.Drawing.Size(209, 30);
            this.txtDb.TabIndex = 14;
            this.txtDb.UseSelectable = true;
            this.txtDb.WaterMark = "JANS";
            this.txtDb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPort
            // 
            this.txtPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(3, 138);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PromptText = "1433";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(94, 30);
            this.txtPort.TabIndex = 13;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMark = "1433";
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtHost.CustomButton.Image = null;
            this.txtHost.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtHost.CustomButton.Name = "";
            this.txtHost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHost.CustomButton.TabIndex = 1;
            this.txtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHost.CustomButton.UseSelectable = true;
            this.txtHost.CustomButton.Visible = false;
            this.txtHost.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(3, 77);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.PromptText = "postgres.domain.com";
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.ShortcutsEnabled = true;
            this.txtHost.Size = new System.Drawing.Size(209, 30);
            this.txtHost.TabIndex = 12;
            this.txtHost.UseSelectable = true;
            this.txtHost.WaterMark = "postgres.domain.com";
            this.txtHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtpTheme
            // 
            this.mtpTheme.Controls.Add(this.mrbLight);
            this.mtpTheme.Controls.Add(this.mrbDark);
            this.mtpTheme.Controls.Add(this.metroLabel2);
            this.mtpTheme.Controls.Add(this.metroLabel1);
            this.mtpTheme.Controls.Add(this.flpSettings);
            this.mtpTheme.HorizontalScrollbarBarColor = true;
            this.mtpTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpTheme.HorizontalScrollbarSize = 10;
            this.mtpTheme.Location = new System.Drawing.Point(4, 38);
            this.mtpTheme.Name = "mtpTheme";
            this.mtpTheme.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.mtpTheme.Size = new System.Drawing.Size(1201, 632);
            this.mtpTheme.TabIndex = 1;
            this.mtpTheme.Text = "&theme";
            this.mtpTheme.VerticalScrollbarBarColor = true;
            this.mtpTheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpTheme.VerticalScrollbarSize = 10;
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbLight.Location = new System.Drawing.Point(72, 33);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(56, 19);
            this.mrbLight.TabIndex = 6;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "&Light";
            this.mrbLight.UseSelectable = true;
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDark.Location = new System.Drawing.Point(3, 33);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(54, 19);
            this.mrbDark.TabIndex = 5;
            this.mrbDark.Text = "&Dark";
            this.mrbDark.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme";
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSettings.Location = new System.Drawing.Point(0, 80);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(1201, 552);
            this.flpSettings.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 742);
            this.ControlBox = false;
            this.Controls.Add(this.mtcSettings);
            this.Controls.Add(this.plSystem);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.lnkSystem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "JANS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.stylMan)).EndInit();
            this.plSystem.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpConnection.ResumeLayout(false);
            this.mtpConnection.PerformLayout();
            this.mtpTheme.ResumeLayout(false);
            this.mtpTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager stylMan;
        private MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Controls.MetroLink lnkSystem;
        private MetroFramework.Controls.MetroPanel plSystem;
        private MetroFramework.Controls.MetroLink lnExit;
        private MetroFramework.Controls.MetroLink lnLogout;
        private MetroFramework.Controls.MetroLink lnLock;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDBPass;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDBUser;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroLabel lblHost;
        private MetroFramework.Controls.MetroLabel lblDb;
        private MetroFramework.Controls.MetroTextBox txtDb;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
    }
}