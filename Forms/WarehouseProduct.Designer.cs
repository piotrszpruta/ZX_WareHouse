namespace ZX_WareHouse.Forms
{
    partial class WarehouseProduct
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
            label1 = new Label();
            ModelTextField = new TextBox();
            ProviderTextBox = new TextBox();
            NettoTextBox = new TextBox();
            UnitComboBox = new ComboBox();
            SaveProductToWarehouse = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            QuantityTextBox = new TextBox();
            VatComboBox = new ComboBox();
            IdLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 1;
            label1.Text = "Product manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelTextField
            // 
            ModelTextField.BackColor = Color.FromArgb(29, 29, 28);
            ModelTextField.BorderStyle = BorderStyle.FixedSingle;
            ModelTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ModelTextField.ForeColor = Color.White;
            ModelTextField.Location = new Point(26, 70);
            ModelTextField.Margin = new Padding(30);
            ModelTextField.Name = "ModelTextField";
            ModelTextField.PlaceholderText = "Model";
            ModelTextField.Size = new Size(168, 31);
            ModelTextField.TabIndex = 4;
            // 
            // ProviderTextBox
            // 
            ProviderTextBox.BackColor = Color.FromArgb(29, 29, 28);
            ProviderTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProviderTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProviderTextBox.ForeColor = Color.White;
            ProviderTextBox.Location = new Point(269, 70);
            ProviderTextBox.Margin = new Padding(30);
            ProviderTextBox.Name = "ProviderTextBox";
            ProviderTextBox.PlaceholderText = "Provider";
            ProviderTextBox.Size = new Size(168, 31);
            ProviderTextBox.TabIndex = 5;
            // 
            // NettoTextBox
            // 
            NettoTextBox.BackColor = Color.FromArgb(29, 29, 28);
            NettoTextBox.BorderStyle = BorderStyle.FixedSingle;
            NettoTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NettoTextBox.ForeColor = Color.White;
            NettoTextBox.Location = new Point(26, 134);
            NettoTextBox.Margin = new Padding(30);
            NettoTextBox.Name = "NettoTextBox";
            NettoTextBox.PlaceholderText = "Netto price";
            NettoTextBox.Size = new Size(168, 31);
            NettoTextBox.TabIndex = 7;
            // 
            // UnitComboBox
            // 
            UnitComboBox.BackColor = Color.FromArgb(29, 29, 28);
            UnitComboBox.FlatStyle = FlatStyle.Flat;
            UnitComboBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UnitComboBox.ForeColor = Color.White;
            UnitComboBox.FormattingEnabled = true;
            UnitComboBox.Items.AddRange(new object[] { "kilograms", "liters", "items" });
            UnitComboBox.Location = new Point(269, 199);
            UnitComboBox.Name = "UnitComboBox";
            UnitComboBox.Size = new Size(168, 31);
            UnitComboBox.TabIndex = 9;
            UnitComboBox.Text = "Units";
            // 
            // SaveProductToWarehouse
            // 
            SaveProductToWarehouse.BackColor = Color.FromArgb(29, 29, 28);
            SaveProductToWarehouse.FlatAppearance.BorderColor = Color.White;
            SaveProductToWarehouse.FlatAppearance.BorderSize = 2;
            SaveProductToWarehouse.FlatStyle = FlatStyle.Flat;
            SaveProductToWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveProductToWarehouse.ForeColor = Color.White;
            SaveProductToWarehouse.Location = new Point(146, 263);
            SaveProductToWarehouse.Name = "SaveProductToWarehouse";
            SaveProductToWarehouse.Size = new Size(168, 31);
            SaveProductToWarehouse.TabIndex = 10;
            SaveProductToWarehouse.Text = "Save";
            SaveProductToWarehouse.UseVisualStyleBackColor = false;
            SaveProductToWarehouse.Click += SaveProductToWarehouse_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(IdLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(QuantityTextBox);
            panel1.Controls.Add(VatComboBox);
            panel1.Controls.Add(SaveProductToWarehouse);
            panel1.Controls.Add(UnitComboBox);
            panel1.Controls.Add(NettoTextBox);
            panel1.Controls.Add(ProviderTextBox);
            panel1.Controls.Add(ModelTextField);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 308);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 182);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 18;
            label5.Text = "Units";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 116);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 17;
            label6.Text = "VAT (%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 50);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 16;
            label7.Text = "Provider";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 182);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 15;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 116);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 14;
            label3.Text = "Price (netto)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 50);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 13;
            label2.Text = "Model";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.BackColor = Color.FromArgb(29, 29, 28);
            QuantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTextBox.ForeColor = Color.White;
            QuantityTextBox.Location = new Point(26, 199);
            QuantityTextBox.Margin = new Padding(30);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.PlaceholderText = "Quantity";
            QuantityTextBox.Size = new Size(168, 31);
            QuantityTextBox.TabIndex = 12;
            // 
            // VatComboBox
            // 
            VatComboBox.BackColor = Color.FromArgb(29, 29, 28);
            VatComboBox.FlatStyle = FlatStyle.Flat;
            VatComboBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            VatComboBox.ForeColor = Color.White;
            VatComboBox.FormatString = "%";
            VatComboBox.FormattingEnabled = true;
            VatComboBox.Items.AddRange(new object[] { "8", "23" });
            VatComboBox.Location = new Point(269, 134);
            VatComboBox.Name = "VatComboBox";
            VatComboBox.Size = new Size(168, 31);
            VatComboBox.TabIndex = 11;
            VatComboBox.Text = "VAT (%)";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(399, 279);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(40, 15);
            IdLabel.TabIndex = 19;
            IdLabel.Text = "           ";
            // 
            // WarehouseProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 41);
            ClientSize = new Size(462, 308);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WarehouseProduct";
            Text = "Warehouse product";
            Load += WarehouseProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox ModelTextField;
        private TextBox ProviderTextBox;
        private TextBox NettoTextBox;
        private ComboBox UnitComboBox;
        private Button SaveProductToWarehouse;
        private Panel panel1;
        private ComboBox VatComboBox;
        private TextBox QuantityTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label IdLabel;
    }
}