namespace LaNizaFoodProj
{
    partial class UserControlCheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.listBoxUserOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(14, 14);
            this.txtCustomerInfo.Multiline = true;
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.ReadOnly = true;
            this.txtCustomerInfo.Size = new System.Drawing.Size(913, 66);
            this.txtCustomerInfo.TabIndex = 0;
            // 
            // listBoxUserOrders
            // 
            this.listBoxUserOrders.FormattingEnabled = true;
            this.listBoxUserOrders.ItemHeight = 31;
            this.listBoxUserOrders.Location = new System.Drawing.Point(14, 111);
            this.listBoxUserOrders.Name = "listBoxUserOrders";
            this.listBoxUserOrders.Size = new System.Drawing.Size(913, 221);
            this.listBoxUserOrders.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Price:";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalPriceValue.Location = new System.Drawing.Point(144, 360);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(0, 31);
            this.lblTotalPriceValue.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadSummary
            // 
            this.btnLoadSummary.Location = new System.Drawing.Point(647, 350);
            this.btnLoadSummary.Name = "btnLoadSummary";
            this.btnLoadSummary.Size = new System.Drawing.Size(280, 41);
            this.btnLoadSummary.TabIndex = 5;
            this.btnLoadSummary.Text = "Load Summary/Refresh";
            this.btnLoadSummary.UseVisualStyleBackColor = true;
            this.btnLoadSummary.Click += new System.EventHandler(this.btnLoadSummary_Click);
            // 
            // UserControlCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnLoadSummary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalPriceValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUserOrders);
            this.Controls.Add(this.txtCustomerInfo);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserControlCheckout";
            this.Size = new System.Drawing.Size(951, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.ListBox listBoxUserOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadSummary;
    }
}
