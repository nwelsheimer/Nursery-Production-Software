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
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lnkSystem = new MetroFramework.Controls.MetroLink();
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.plSystem = new MetroFramework.Controls.MetroPanel();
            this.lnExit = new MetroFramework.Controls.MetroLink();
            this.lnLock = new MetroFramework.Controls.MetroLink();
            this.lnLogout = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.stylMan)).BeginInit();
            this.plSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylMan
            // 
            this.stylMan.Owner = this;
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogin.Location = new System.Drawing.Point(34, 84);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkSystem
            // 
            this.lnkSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSystem.Image = ((System.Drawing.Image)(resources.GetObject("lnkSystem.Image")));
            this.lnkSystem.ImageSize = 32;
            this.lnkSystem.Location = new System.Drawing.Point(627, 8);
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
            this.lnkSettings.Location = new System.Drawing.Point(675, 8);
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
            this.plSystem.Location = new System.Drawing.Point(594, 53);
            this.plSystem.Name = "plSystem";
            this.plSystem.Size = new System.Drawing.Size(123, 92);
            this.plSystem.TabIndex = 15;
            this.plSystem.VerticalScrollbarBarColor = true;
            this.plSystem.VerticalScrollbarHighlightOnWheel = false;
            this.plSystem.VerticalScrollbarSize = 10;
            this.plSystem.Visible = false;
            this.plSystem.Leave += new System.EventHandler(this.plSystem_Leave);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 527);
            this.ControlBox = false;
            this.Controls.Add(this.plSystem);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.lnkSystem);
            this.Controls.Add(this.btnLogin);
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
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager stylMan;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Controls.MetroLink lnkSystem;
        private MetroFramework.Controls.MetroPanel plSystem;
        private MetroFramework.Controls.MetroLink lnExit;
        private MetroFramework.Controls.MetroLink lnLogout;
        private MetroFramework.Controls.MetroLink lnLock;
    }
}