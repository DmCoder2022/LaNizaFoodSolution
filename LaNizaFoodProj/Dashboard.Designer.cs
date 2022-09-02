namespace LaNizaFoodProj
{
    partial class Dashboard
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
            this.panelTabs = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUserDetails = new System.Windows.Forms.Button();
            this.btnFoodMenus = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelTabs.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelTabs.Controls.Add(this.btnCheckout);
            this.panelTabs.Controls.Add(this.btnFoodMenus);
            this.panelTabs.Controls.Add(this.btnUserDetails);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(200, 612);
            this.panelTabs.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Teal;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(951, 100);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(266, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LA NIZA FOOD";
            // 
            // btnUserDetails
            // 
            this.btnUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUserDetails.FlatAppearance.BorderSize = 0;
            this.btnUserDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnUserDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUserDetails.Location = new System.Drawing.Point(3, 102);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.Size = new System.Drawing.Size(194, 41);
            this.btnUserDetails.TabIndex = 0;
            this.btnUserDetails.Text = "User Details";
            this.btnUserDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDetails.UseVisualStyleBackColor = false;
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
            // 
            // btnFoodMenus
            // 
            this.btnFoodMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFoodMenus.FlatAppearance.BorderSize = 0;
            this.btnFoodMenus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFoodMenus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnFoodMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodMenus.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFoodMenus.Location = new System.Drawing.Point(3, 269);
            this.btnFoodMenus.Name = "btnFoodMenus";
            this.btnFoodMenus.Size = new System.Drawing.Size(194, 41);
            this.btnFoodMenus.TabIndex = 1;
            this.btnFoodMenus.Text = "Food Menus";
            this.btnFoodMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodMenus.UseVisualStyleBackColor = false;
            this.btnFoodMenus.Click += new System.EventHandler(this.btnFoodMenus_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCheckout.Location = new System.Drawing.Point(3, 431);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(194, 41);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(200, 100);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(951, 512);
            this.panelDisplay.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 612);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelTabs);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Niza Food App";
            this.panelTabs.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnFoodMenus;
        private System.Windows.Forms.Button btnUserDetails;
        private System.Windows.Forms.Panel panelDisplay;
    }
}

