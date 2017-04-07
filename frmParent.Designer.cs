namespace Nursery_Production_Software
{
    partial class frmParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            this.btnAccounting = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tleOrder = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnAccounting
            // 
            this.btnAccounting.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.accounting;
            this.btnAccounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounting.ForeColor = System.Drawing.Color.LightGray;
            this.btnAccounting.Location = new System.Drawing.Point(173, 236);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(91, 81);
            this.btnAccounting.TabIndex = 7;
            this.btnAccounting.UseVisualStyleBackColor = true;
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.shipping;
            this.btnShipping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipping.ForeColor = System.Drawing.Color.LightGray;
            this.btnShipping.Location = new System.Drawing.Point(173, 147);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(91, 81);
            this.btnShipping.TabIndex = 5;
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.inventory;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.LightGray;
            this.btnInventory.Location = new System.Drawing.Point(173, 60);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(91, 81);
            this.btnInventory.TabIndex = 4;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.production;
            this.btnProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduction.ForeColor = System.Drawing.Color.LightGray;
            this.btnProduction.Location = new System.Drawing.Point(74, 149);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(91, 81);
            this.btnProduction.TabIndex = 3;
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.history;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.LightGray;
            this.btnHistory.Location = new System.Drawing.Point(284, 50);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(91, 81);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPlanning
            // 
            this.btnPlanning.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.planning;
            this.btnPlanning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanning.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlanning.Location = new System.Drawing.Point(58, 60);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(91, 81);
            this.btnPlanning.TabIndex = 1;
            this.btnPlanning.UseVisualStyleBackColor = true;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::Nursery_Production_Software.Properties.Resources.ordering;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnOrder.Location = new System.Drawing.Point(58, 236);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(91, 81);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.AutoSize = true;
            this.metroTile1.Location = new System.Drawing.Point(591, 236);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(188, 137);
            this.metroTile1.TabIndex = 17;
            this.metroTile1.Text = "Reporting";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // tleOrder
            // 
            this.tleOrder.ActiveControl = null;
            this.tleOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tleOrder.AutoSize = true;
            this.tleOrder.Location = new System.Drawing.Point(591, 91);
            this.tleOrder.Name = "tleOrder";
            this.tleOrder.Size = new System.Drawing.Size(188, 137);
            this.tleOrder.TabIndex = 18;
            this.tleOrder.Tag = "1";
            this.tleOrder.Text = "Ordering";
            this.tleOrder.TileImage = ((System.Drawing.Image)(resources.GetObject("tleOrder.TileImage")));
            this.tleOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tleOrder.UseSelectable = true;
            this.tleOrder.UseTileImage = true;
            this.tleOrder.Click += new System.EventHandler(this.tleOrder_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(786, 380);
            this.Controls.Add(this.tleOrder);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnAccounting);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnPlanning);
            this.Controls.Add(this.btnOrder);
            this.Name = "frmParent";
            this.Text = "JANS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnAccounting;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile tleOrder;
    }
}

