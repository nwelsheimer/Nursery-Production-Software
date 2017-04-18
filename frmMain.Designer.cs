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
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.stylMan)).BeginInit();
            this.plSystem.SuspendLayout();
            this.mtcSettings.SuspendLayout();
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
            this.mtcSettings.SelectedIndex = 0;
            this.mtcSettings.Size = new System.Drawing.Size(1209, 674);
            this.mtcSettings.TabIndex = 16;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 38);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(1201, 632);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&connection";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // mtpTheme
            // 
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
            this.mtpTheme.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
    }
}