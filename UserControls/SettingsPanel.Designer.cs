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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            PermissionsPanel = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            SecondNameTextField = new TextBox();
            FirstNameTextField = new TextBox();
            EmailTextField = new TextBox();
            NameTextField = new TextBox();
            groupBox1 = new GroupBox();
            UserGridView = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            PermissionsPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 42, 41);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PermissionsPanel);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 411);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 29, 28);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(515, 6);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // PermissionsPanel
            // 
            PermissionsPanel.Controls.Add(checkBox4);
            PermissionsPanel.Controls.Add(checkBox3);
            PermissionsPanel.Controls.Add(checkBox2);
            PermissionsPanel.Controls.Add(checkBox1);
            PermissionsPanel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PermissionsPanel.ForeColor = Color.White;
            PermissionsPanel.Location = new Point(426, 237);
            PermissionsPanel.Name = "PermissionsPanel";
            PermissionsPanel.Size = new Size(191, 171);
            PermissionsPanel.TabIndex = 3;
            PermissionsPanel.TabStop = false;
            PermissionsPanel.Text = "Permissions";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(42, 128);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(108, 25);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(42, 97);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(108, 25);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Location = new Point(42, 66);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(42, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SecondNameTextField);
            groupBox2.Controls.Add(FirstNameTextField);
            groupBox2.Controls.Add(EmailTextField);
            groupBox2.Controls.Add(NameTextField);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 171);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "User data";
            // 
            // SecondNameTextField
            // 
            SecondNameTextField.BackColor = Color.FromArgb(29, 29, 28);
            SecondNameTextField.BorderStyle = BorderStyle.FixedSingle;
            SecondNameTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            SecondNameTextField.ForeColor = Color.White;
            SecondNameTextField.Location = new Point(214, 100);
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
            FirstNameTextField.Location = new Point(27, 100);
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
            EmailTextField.Location = new Point(214, 45);
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
            NameTextField.Location = new Point(27, 45);
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
            UserGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UserGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UserGridView.BackgroundColor = Color.FromArgb(43, 42, 41);
            UserGridView.BorderStyle = BorderStyle.None;
            UserGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGridView.Dock = DockStyle.Fill;
            UserGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            UserGridView.GridColor = Color.FromArgb(43, 42, 41);
            UserGridView.Location = new Point(3, 25);
            UserGridView.MultiSelect = false;
            UserGridView.Name = "UserGridView";
            UserGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UserGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UserGridView.RowHeadersVisible = false;
            UserGridView.RowTemplate.Height = 25;
            UserGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserGridView.ShowCellErrors = false;
            UserGridView.ShowCellToolTips = false;
            UserGridView.ShowEditingIcon = false;
            UserGridView.ShowRowErrors = false;
            UserGridView.Size = new Size(608, 170);
            UserGridView.TabIndex = 0;
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
            // UsersPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UsersPanel";
            Size = new Size(620, 411);
            Load += UsersPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PermissionsPanel.ResumeLayout(false);
            PermissionsPanel.PerformLayout();
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
        private GroupBox PermissionsPanel;
        private GroupBox groupBox2;
        private DataGridView UserGridView;
        private TextBox FirstNameTextField;
        private TextBox EmailTextField;
        private TextBox NameTextField;
        private Button button1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox SecondNameTextField;
    }
}
