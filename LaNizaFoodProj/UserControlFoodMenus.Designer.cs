namespace LaNizaFoodProj
{
    partial class UserControlFoodMenus
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
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.comboBoxBreakfastMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxCombosMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxBurgersMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxChipsMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxSoftDrinksMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxMilkshakesMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxJuicesMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxHotDrinksMenu = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOrderDisplay = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(803, 241);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(138, 48);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // comboBoxBreakfastMenu
            // 
            this.comboBoxBreakfastMenu.FormattingEnabled = true;
            this.comboBoxBreakfastMenu.Location = new System.Drawing.Point(16, 167);
            this.comboBoxBreakfastMenu.Name = "comboBoxBreakfastMenu";
            this.comboBoxBreakfastMenu.Size = new System.Drawing.Size(206, 39);
            this.comboBoxBreakfastMenu.TabIndex = 2;
            this.comboBoxBreakfastMenu.Text = "Breakfast Menu";
            this.comboBoxBreakfastMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxBreakfastMenu_SelectedIndexChanged);
            // 
            // comboBoxCombosMenu
            // 
            this.comboBoxCombosMenu.FormattingEnabled = true;
            this.comboBoxCombosMenu.Location = new System.Drawing.Point(16, 259);
            this.comboBoxCombosMenu.Name = "comboBoxCombosMenu";
            this.comboBoxCombosMenu.Size = new System.Drawing.Size(206, 39);
            this.comboBoxCombosMenu.TabIndex = 3;
            this.comboBoxCombosMenu.Text = "Combos Menu";
            this.comboBoxCombosMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombosMenu_SelectedIndexChanged);
            // 
            // comboBoxBurgersMenu
            // 
            this.comboBoxBurgersMenu.FormattingEnabled = true;
            this.comboBoxBurgersMenu.Location = new System.Drawing.Point(16, 457);
            this.comboBoxBurgersMenu.Name = "comboBoxBurgersMenu";
            this.comboBoxBurgersMenu.Size = new System.Drawing.Size(206, 39);
            this.comboBoxBurgersMenu.TabIndex = 4;
            this.comboBoxBurgersMenu.Text = "Burgers Menu";
            this.comboBoxBurgersMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxBurgersMenu_SelectedIndexChanged);
            // 
            // comboBoxChipsMenu
            // 
            this.comboBoxChipsMenu.FormattingEnabled = true;
            this.comboBoxChipsMenu.Location = new System.Drawing.Point(16, 356);
            this.comboBoxChipsMenu.Name = "comboBoxChipsMenu";
            this.comboBoxChipsMenu.Size = new System.Drawing.Size(206, 39);
            this.comboBoxChipsMenu.TabIndex = 5;
            this.comboBoxChipsMenu.Text = "Chips Menu";
            this.comboBoxChipsMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxChipsMenu_SelectedIndexChanged);
            // 
            // comboBoxSoftDrinksMenu
            // 
            this.comboBoxSoftDrinksMenu.FormattingEnabled = true;
            this.comboBoxSoftDrinksMenu.Location = new System.Drawing.Point(304, 167);
            this.comboBoxSoftDrinksMenu.Name = "comboBoxSoftDrinksMenu";
            this.comboBoxSoftDrinksMenu.Size = new System.Drawing.Size(222, 39);
            this.comboBoxSoftDrinksMenu.TabIndex = 6;
            this.comboBoxSoftDrinksMenu.Text = "Soft Drinks Menu";
            this.comboBoxSoftDrinksMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxSoftDrinksMenu_SelectedIndexChanged);
            // 
            // comboBoxMilkshakesMenu
            // 
            this.comboBoxMilkshakesMenu.FormattingEnabled = true;
            this.comboBoxMilkshakesMenu.Location = new System.Drawing.Point(304, 259);
            this.comboBoxMilkshakesMenu.Name = "comboBoxMilkshakesMenu";
            this.comboBoxMilkshakesMenu.Size = new System.Drawing.Size(222, 39);
            this.comboBoxMilkshakesMenu.TabIndex = 7;
            this.comboBoxMilkshakesMenu.Text = "Milkshakes Menu";
            this.comboBoxMilkshakesMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMilkshakesMenu_SelectedIndexChanged);
            // 
            // comboBoxJuicesMenu
            // 
            this.comboBoxJuicesMenu.FormattingEnabled = true;
            this.comboBoxJuicesMenu.Location = new System.Drawing.Point(304, 356);
            this.comboBoxJuicesMenu.Name = "comboBoxJuicesMenu";
            this.comboBoxJuicesMenu.Size = new System.Drawing.Size(222, 39);
            this.comboBoxJuicesMenu.TabIndex = 8;
            this.comboBoxJuicesMenu.Text = "Juices Menu";
            this.comboBoxJuicesMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxJuicesMenu_SelectedIndexChanged);
            // 
            // comboBoxHotDrinksMenu
            // 
            this.comboBoxHotDrinksMenu.FormattingEnabled = true;
            this.comboBoxHotDrinksMenu.Location = new System.Drawing.Point(304, 457);
            this.comboBoxHotDrinksMenu.Name = "comboBoxHotDrinksMenu";
            this.comboBoxHotDrinksMenu.Size = new System.Drawing.Size(222, 39);
            this.comboBoxHotDrinksMenu.TabIndex = 9;
            this.comboBoxHotDrinksMenu.Text = "Hot Drinks Menu";
            this.comboBoxHotDrinksMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotDrinksMenu_SelectedIndexChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(803, 167);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 39);
            this.numericUpDownQuantity.TabIndex = 10;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(676, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantity:";
            // 
            // listBoxOrderDisplay
            // 
            this.listBoxOrderDisplay.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrderDisplay.FormattingEnabled = true;
            this.listBoxOrderDisplay.ItemHeight = 41;
            this.listBoxOrderDisplay.Location = new System.Drawing.Point(468, 17);
            this.listBoxOrderDisplay.Name = "listBoxOrderDisplay";
            this.listBoxOrderDisplay.Size = new System.Drawing.Size(473, 86);
            this.listBoxOrderDisplay.TabIndex = 12;
            // 
            // UserControlFoodMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.listBoxOrderDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxHotDrinksMenu);
            this.Controls.Add(this.comboBoxJuicesMenu);
            this.Controls.Add(this.comboBoxMilkshakesMenu);
            this.Controls.Add(this.comboBoxSoftDrinksMenu);
            this.Controls.Add(this.comboBoxChipsMenu);
            this.Controls.Add(this.comboBoxBurgersMenu);
            this.Controls.Add(this.comboBoxCombosMenu);
            this.Controls.Add(this.comboBoxBreakfastMenu);
            this.Controls.Add(this.btnAddOrder);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserControlFoodMenus";
            this.Size = new System.Drawing.Size(951, 512);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox comboBoxBreakfastMenu;
        private System.Windows.Forms.ComboBox comboBoxCombosMenu;
        private System.Windows.Forms.ComboBox comboBoxBurgersMenu;
        private System.Windows.Forms.ComboBox comboBoxChipsMenu;
        private System.Windows.Forms.ComboBox comboBoxSoftDrinksMenu;
        private System.Windows.Forms.ComboBox comboBoxMilkshakesMenu;
        private System.Windows.Forms.ComboBox comboBoxJuicesMenu;
        private System.Windows.Forms.ComboBox comboBoxHotDrinksMenu;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrderDisplay;
    }
}
