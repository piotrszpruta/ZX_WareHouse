namespace ZX_WareHouse.Forms
{
    partial class ReleaseForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseForm));
            SaveButton = new Button();
            CompanyTextField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ProductComboBox = new ComboBox();
            label3 = new Label();
            QuantityNumericValue = new NumericUpDown();
            QuantityStatusLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NipTextBox = new TextBox();
            label7 = new Label();
            AddressTextBox = new TextBox();
            AddProductToListButton = new Button();
            ProductGridView = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(29, 29, 28);
            SaveButton.FlatAppearance.BorderSize = 2;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(362, 425);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(132, 34);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CompanyTextField
            // 
            CompanyTextField.BackColor = Color.FromArgb(29, 29, 28);
            CompanyTextField.BorderStyle = BorderStyle.FixedSingle;
            CompanyTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyTextField.ForeColor = Color.White;
            CompanyTextField.Location = new Point(299, 96);
            CompanyTextField.Margin = new Padding(30);
            CompanyTextField.Name = "CompanyTextField";
            CompanyTextField.PlaceholderText = "Company";
            CompanyTextField.Size = new Size(195, 31);
            CompanyTextField.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 15;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 16;
            label2.Text = "External release";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductComboBox
            // 
            ProductComboBox.BackColor = Color.FromArgb(29, 29, 28);
            ProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductComboBox.FlatStyle = FlatStyle.Popup;
            ProductComboBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProductComboBox.ForeColor = Color.White;
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(12, 96);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(195, 31);
            ProductComboBox.TabIndex = 17;
            ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 18;
            label3.Text = "Quantity";
            // 
            // QuantityNumericValue
            // 
            QuantityNumericValue.BackColor = Color.FromArgb(29, 29, 28);
            QuantityNumericValue.BorderStyle = BorderStyle.FixedSingle;
            QuantityNumericValue.DecimalPlaces = 2;
            QuantityNumericValue.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityNumericValue.ForeColor = Color.White;
            QuantityNumericValue.Location = new Point(12, 161);
            QuantityNumericValue.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            QuantityNumericValue.Name = "QuantityNumericValue";
            QuantityNumericValue.Size = new Size(195, 31);
            QuantityNumericValue.TabIndex = 19;
            QuantityNumericValue.TextAlign = HorizontalAlignment.Center;
            // 
            // QuantityStatusLabel
            // 
            QuantityStatusLabel.AutoSize = true;
            QuantityStatusLabel.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityStatusLabel.ForeColor = SystemColors.ActiveBorder;
            QuantityStatusLabel.Location = new Point(176, 195);
            QuantityStatusLabel.Name = "QuantityStatusLabel";
            QuantityStatusLabel.Size = new Size(31, 15);
            QuantityStatusLabel.TabIndex = 20;
            QuantityStatusLabel.Text = "2506";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(299, 78);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 21;
            label4.Text = "Company name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(299, 41);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 22;
            label5.Text = "Receiver";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(299, 143);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 24;
            label6.Text = "NIP";
            // 
            // NipTextBox
            // 
            NipTextBox.BackColor = Color.FromArgb(29, 29, 28);
            NipTextBox.BorderStyle = BorderStyle.FixedSingle;
            NipTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NipTextBox.ForeColor = Color.White;
            NipTextBox.Location = new Point(299, 161);
            NipTextBox.Margin = new Padding(30);
            NipTextBox.Name = "NipTextBox";
            NipTextBox.PlaceholderText = "NIP";
            NipTextBox.Size = new Size(195, 31);
            NipTextBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(299, 213);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 26;
            label7.Text = "Address";
            // 
            // AddressTextBox
            // 
            AddressTextBox.BackColor = Color.FromArgb(29, 29, 28);
            AddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBox.ForeColor = Color.White;
            AddressTextBox.Location = new Point(299, 231);
            AddressTextBox.Margin = new Padding(30);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.PlaceholderText = "Address";
            AddressTextBox.Size = new Size(195, 31);
            AddressTextBox.TabIndex = 25;
            // 
            // AddProductToListButton
            // 
            AddProductToListButton.BackColor = Color.FromArgb(29, 29, 28);
            AddProductToListButton.FlatAppearance.BorderSize = 2;
            AddProductToListButton.FlatStyle = FlatStyle.Flat;
            AddProductToListButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductToListButton.ForeColor = Color.White;
            AddProductToListButton.Location = new Point(75, 231);
            AddProductToListButton.Name = "AddProductToListButton";
            AddProductToListButton.Size = new Size(132, 34);
            AddProductToListButton.TabIndex = 27;
            AddProductToListButton.Text = "Add to list";
            AddProductToListButton.UseVisualStyleBackColor = false;
            AddProductToListButton.Click += AddProductToListButton_Click;
            // 
            // ProductGridView
            // 
            ProductGridView.AllowUserToAddRows = false;
            ProductGridView.AllowUserToDeleteRows = false;
            ProductGridView.AllowUserToResizeColumns = false;
            ProductGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductGridView.BackgroundColor = Color.FromArgb(29, 29, 28);
            ProductGridView.BorderStyle = BorderStyle.None;
            ProductGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProductGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductGridView.GridColor = Color.FromArgb(43, 42, 41);
            ProductGridView.Location = new Point(12, 271);
            ProductGridView.MultiSelect = false;
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            ProductGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 41);
            ProductGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            ProductGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            ProductGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(43, 42, 41);
            ProductGridView.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            ProductGridView.RowTemplate.Height = 25;
            ProductGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGridView.ShowCellErrors = false;
            ProductGridView.ShowCellToolTips = false;
            ProductGridView.ShowEditingIcon = false;
            ProductGridView.ShowRowErrors = false;
            ProductGridView.Size = new Size(482, 148);
            ProductGridView.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveBorder;
            label8.Location = new Point(12, 195);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 29;
            label8.Text = "Available quantity:";
            // 
            // ReleaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 41);
            ClientSize = new Size(507, 471);
            Controls.Add(label8);
            Controls.Add(ProductGridView);
            Controls.Add(AddProductToListButton);
            Controls.Add(label7);
            Controls.Add(AddressTextBox);
            Controls.Add(label6);
            Controls.Add(NipTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(QuantityStatusLabel);
            Controls.Add(QuantityNumericValue);
            Controls.Add(label3);
            Controls.Add(ProductComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(CompanyTextField);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReleaseForm";
            Text = "Release product";
            Load += ReleaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityNumericValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignInButton;
        private TextBox CompanyTextField;
        private Label label1;
        private Label label2;
        private ComboBox ProductComboBox;
        private Label label3;
        private NumericUpDown QuantityNumericValue;
        private Label QuantityStatusLabel;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NipTextBox;
        private Label label7;
        private TextBox AddressTextBox;
        private Button AddProductToListButton;
        private DataGridView ProductGridView;
        private Label label8;
        private Button SaveButton;
    }
}