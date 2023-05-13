namespace ZX_WareHouse.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            WindowPanel = new Panel();
            MinimizeFormButton = new Button();
            CloseFormButton = new Button();
            panel3 = new Panel();
            ErrorMessage = new Label();
            SignInButton = new Button();
            PasswordTextField = new TextBox();
            LoginTextField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(43, 42, 41);
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.personal_logo;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // WindowPanel
            // 
            WindowPanel.Location = new Point(0, 0);
            WindowPanel.Name = "WindowPanel";
            WindowPanel.Size = new Size(200, 100);
            WindowPanel.TabIndex = 8;
            // 
            // MinimizeFormButton
            // 
            MinimizeFormButton.Location = new Point(0, 0);
            MinimizeFormButton.Name = "MinimizeFormButton";
            MinimizeFormButton.Size = new Size(75, 23);
            MinimizeFormButton.TabIndex = 0;
            // 
            // CloseFormButton
            // 
            CloseFormButton.Location = new Point(0, 0);
            CloseFormButton.Name = "CloseFormButton";
            CloseFormButton.Size = new Size(75, 23);
            CloseFormButton.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 42, 41);
            panel3.Controls.Add(ErrorMessage);
            panel3.Controls.Add(SignInButton);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(PasswordTextField);
            panel3.Controls.Add(LoginTextField);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 142);
            panel3.TabIndex = 7;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(149, 80);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(156, 17);
            ErrorMessage.TabIndex = 5;
            ErrorMessage.Text = "Invalid login or password";
            ErrorMessage.Visible = false;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.FromArgb(29, 29, 28);
            SignInButton.FlatAppearance.BorderSize = 2;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(149, 101);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(195, 34);
            SignInButton.TabIndex = 2;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // PasswordTextField
            // 
            PasswordTextField.BackColor = Color.FromArgb(29, 29, 28);
            PasswordTextField.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextField.ForeColor = Color.White;
            PasswordTextField.Location = new Point(149, 45);
            PasswordTextField.Margin = new Padding(30);
            PasswordTextField.Name = "PasswordTextField";
            PasswordTextField.PasswordChar = '*';
            PasswordTextField.PlaceholderText = "Password";
            PasswordTextField.Size = new Size(195, 31);
            PasswordTextField.TabIndex = 1;
            // 
            // LoginTextField
            // 
            LoginTextField.BackColor = Color.FromArgb(29, 29, 28);
            LoginTextField.BorderStyle = BorderStyle.FixedSingle;
            LoginTextField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextField.ForeColor = Color.White;
            LoginTextField.Location = new Point(149, 7);
            LoginTextField.Margin = new Padding(30);
            LoginTextField.Name = "LoginTextField";
            LoginTextField.PlaceholderText = "Login";
            LoginTextField.Size = new Size(195, 31);
            LoginTextField.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 142);
            Controls.Add(panel3);
            Controls.Add(WindowPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel WindowPanel;
        private Panel panel3;
        private TextBox PasswordTextField;
        private TextBox LoginTextField;
        private Button SignInButton;
        private Button MinimizeFormButton;
        private Button CloseFormButton;
        private Label ErrorMessage;
    }
}