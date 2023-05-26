namespace ZX_WareHouse.UserControls
{
    partial class SettingsPanel
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ClearButton = new Button();
            RemoveUserButton = new Button();
            SaveUserButton = new Button();
            groupBox2 = new GroupBox();
            selectedID = new Label();
            GeneratePasswordButton = new Button();
            PasswordTextBox = new TextBox();
            SecondNameTextField = new TextBox();
            FirstNameTextField = new TextBox();
            EmailTextField = new TextBox();
            NameTextField = new TextBox();
            groupBox1 = new GroupBox();
            UserGridView = new DataGridView();
            label1 = new Label();
            AdministratorRadioButton = new RadioButton();
            ModeratorRadioButton = new RadioButton();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 42, 41);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(RemoveUserButton);
            panel1.Controls.Add(SaveUserButton);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 411);
            panel1.TabIndex = 0;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(29, 29, 28);
            ClearButton.FlatAppearance.BorderColor = Color.White;
            ClearButton.FlatAppearance.BorderSize = 2;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(311, 6);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(96, 31);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // RemoveUserButton
            // 
            RemoveUserButton.BackColor = Color.FromArgb(29, 29, 28);
            RemoveUserButton.FlatAppearance.BorderColor = Color.White;
            RemoveUserButton.FlatAppearance.BorderSize = 2;
            RemoveUserButton.FlatStyle = FlatStyle.Flat;
            RemoveUserButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveUserButton.ForeColor = Color.White;
            RemoveUserButton.Location = new Point(413, 6);
            RemoveUserButton.Name = "RemoveUserButton";
            RemoveUserButton.Size = new Size(96, 31);
            RemoveUserButton.TabIndex = 5;
            RemoveUserButton.Text = "Remove";
            RemoveUserButton.UseVisualStyleBackColor = false;
            RemoveUserButton.Click += RemoveUserButton_Click;
            // 
            // SaveUserButton
            // 
            SaveUserButton.BackColor = Color.FromArgb(29, 29, 28);
            SaveUserButton.FlatAppearance.BorderColor = Color.White;
            SaveUserButton.FlatAppearance.BorderSize = 2;
            SaveUserButton.FlatStyle = FlatStyle.Flat;
            SaveUserButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUserButton.ForeColor = Color.White;
            SaveUserButton.Location = new Point(515, 6);
            SaveUserButton.Name = "SaveUserButton";
            SaveUserButton.Size = new Size(96, 31);
            SaveUserButton.TabIndex = 4;
            SaveUserButton.Text = "Save";
            SaveUserButton.UseVisualStyleBackColor = false;
            SaveUserButton.Click += SaveUserButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ModeratorRadioButton);
            groupBox2.Controls.Add(AdministratorRadioButton);
            groupBox2.Controls.Add(selectedID);
            groupBox2.Controls.Add(GeneratePasswordButton);
            groupBox2.Controls.Add(PasswordTextBox);
            groupBox2.Controls.Add(SecondNameTextField);
            groupBox2.Controls.Add(FirstNameTextField);
            groupBox2.Controls.Add(EmailTextField);
            groupBox2.Controls.Add(NameTextField);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(614, 171);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "User data";
            // 
            // selectedID
            // 
            selectedID.AutoSize = true;
            selectedID.Location = new Point(3, 25);
            selectedID.Name = "selectedID";
            selectedID.Size = new Size(27, 21);
            selectedID.TabIndex = 7;
            selectedID.Text = "ID";
            selectedID.Visible = false;
            // 
            // GeneratePasswordButton
            // 
            GeneratePasswordButton.BackColor = Color.FromArgb(29, 29, 28);
            GeneratePasswordButton.FlatAppearance.BorderColor = Color.White;
            GeneratePasswordButton.FlatAppearance.BorderSize = 2;
            GeneratePasswordButton.FlatStyle = FlatStyle.Flat;
            GeneratePasswordButton.Location = new Point(39, 123);
            GeneratePasswordButton.Name = "GeneratePasswordButton";
            GeneratePasswordButton.Size = new Size(170, 33);
            GeneratePasswordButton.TabIndex = 6;
            GeneratePasswordButton.Text = "Generate password";
            GeneratePasswordButton.UseVisualStyleBackColor = false;
            GeneratePasswordButton.Click += GeneratePasswordButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(29, 29, 28);
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.Location = new Point(39, 83);
            PasswordTextBox.Margin = new Padding(30);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(170, 31);
            PasswordTextBox.TabIndex = 5;
            // 
            // SecondNameTextField
            // 
            SecondNameTextField.BackColor = Color.FromArgb(29, 29, 28);
            SecondNameTextField.BorderStyle = BorderStyle.FixedSingle;
            SecondNameTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            SecondNameTextField.ForeColor = Color.White;
            SecondNameTextField.Location = new Point(234, 83);
            SecondNameTextField.Margin = new Padding(30);
            SecondNameTextField.Name = "SecondNameTextField";
            SecondNameTextField.PlaceholderText = "Last name";
            SecondNameTextField.Size = new Size(170, 31);
            SecondNameTextField.TabIndex = 4;
            // 
            // FirstNameTextField
            // 
            FirstNameTextField.BackColor = Color.FromArgb(29, 29, 28);
            FirstNameTextField.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTextField.ForeColor = Color.White;
            FirstNameTextField.Location = new Point(234, 45);
            FirstNameTextField.Margin = new Padding(30);
            FirstNameTextField.Name = "FirstNameTextField";
            FirstNameTextField.PlaceholderText = "Firstname";
            FirstNameTextField.Size = new Size(170, 31);
            FirstNameTextField.TabIndex = 3;
            // 
            // EmailTextField
            // 
            EmailTextField.BackColor = Color.FromArgb(29, 29, 28);
            EmailTextField.BorderStyle = BorderStyle.FixedSingle;
            EmailTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextField.ForeColor = Color.White;
            EmailTextField.Location = new Point(417, 45);
            EmailTextField.Margin = new Padding(30);
            EmailTextField.Name = "EmailTextField";
            EmailTextField.PlaceholderText = "Email";
            EmailTextField.Size = new Size(170, 31);
            EmailTextField.TabIndex = 2;
            // 
            // NameTextField
            // 
            NameTextField.BackColor = Color.FromArgb(29, 29, 28);
            NameTextField.BorderStyle = BorderStyle.FixedSingle;
            NameTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextField.ForeColor = Color.White;
            NameTextField.Location = new Point(39, 45);
            NameTextField.Margin = new Padding(30);
            NameTextField.Name = "NameTextField";
            NameTextField.PlaceholderText = "Login";
            NameTextField.Size = new Size(170, 31);
            NameTextField.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(43, 42, 41);
            groupBox1.Controls.Add(UserGridView);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 198);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users list";
            // 
            // UserGridView
            // 
            UserGridView.AllowUserToAddRows = false;
            UserGridView.AllowUserToDeleteRows = false;
            UserGridView.AllowUserToResizeColumns = false;
            UserGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            UserGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            UserGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UserGridView.BackgroundColor = Color.FromArgb(43, 42, 41);
            UserGridView.BorderStyle = BorderStyle.None;
            UserGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            UserGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            UserGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGridView.Dock = DockStyle.Fill;
            UserGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            UserGridView.GridColor = Color.FromArgb(43, 42, 41);
            UserGridView.Location = new Point(3, 25);
            UserGridView.MultiSelect = false;
            UserGridView.Name = "UserGridView";
            UserGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            UserGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            UserGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            UserGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            UserGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 41);
            UserGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            UserGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            UserGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(43, 42, 41);
            UserGridView.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            UserGridView.RowTemplate.Height = 25;
            UserGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserGridView.ShowCellErrors = false;
            UserGridView.ShowCellToolTips = false;
            UserGridView.ShowEditingIcon = false;
            UserGridView.ShowRowErrors = false;
            UserGridView.Size = new Size(608, 170);
            UserGridView.TabIndex = 1;
            UserGridView.SelectionChanged += UserGridView_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 0;
            label1.Text = "Users Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdministratorRadioButton
            // 
            AdministratorRadioButton.AutoSize = true;
            AdministratorRadioButton.Location = new Point(417, 86);
            AdministratorRadioButton.Name = "AdministratorRadioButton";
            AdministratorRadioButton.Size = new Size(134, 25);
            AdministratorRadioButton.TabIndex = 8;
            AdministratorRadioButton.Text = "Administrator";
            AdministratorRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModeratorRadioButton
            // 
            ModeratorRadioButton.AutoSize = true;
            ModeratorRadioButton.Checked = true;
            ModeratorRadioButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            ModeratorRadioButton.FlatAppearance.BorderSize = 4;
            ModeratorRadioButton.Location = new Point(417, 123);
            ModeratorRadioButton.Name = "ModeratorRadioButton";
            ModeratorRadioButton.Size = new Size(109, 25);
            ModeratorRadioButton.TabIndex = 9;
            ModeratorRadioButton.TabStop = true;
            ModeratorRadioButton.Text = "Moderator";
            ModeratorRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SettingsPanel";
            Size = new Size(620, 411);
            Load += UsersPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox FirstNameTextField;
        private TextBox EmailTextField;
        private TextBox NameTextField;
        private Button SaveUserButton;
        private TextBox SecondNameTextField;
        private TextBox PasswordTextBox;
        private Button GeneratePasswordButton;
        private Button RemoveUserButton;
        private DataGridView UserGridView;
        private Button ClearButton;
        private Label selectedID;
        private RadioButton ModeratorRadioButton;
        private RadioButton AdministratorRadioButton;
    }
}
