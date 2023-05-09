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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            WindowPanel = new Panel();
            MinimizeFormButton = new Button();
            CloseFormButton = new Button();
            panel3 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            WindowPanel.SuspendLayout();
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
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // WindowPanel
            // 
            WindowPanel.BackColor = Color.FromArgb(43, 42, 41);
            WindowPanel.Controls.Add(MinimizeFormButton);
            WindowPanel.Controls.Add(CloseFormButton);
            WindowPanel.Controls.Add(label1);
            WindowPanel.Dock = DockStyle.Top;
            WindowPanel.Location = new Point(0, 0);
            WindowPanel.Name = "WindowPanel";
            WindowPanel.Size = new Size(386, 37);
            WindowPanel.TabIndex = 6;
            WindowPanel.MouseMove += WindowPanel_MouseMove;
            // 
            // MinimizeFormButton
            // 
            MinimizeFormButton.BackColor = Color.FromArgb(242, 242, 242);
            MinimizeFormButton.FlatAppearance.BorderSize = 0;
            MinimizeFormButton.FlatStyle = FlatStyle.Flat;
            MinimizeFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizeFormButton.ForeColor = Color.FromArgb(43, 42, 41);
            MinimizeFormButton.Location = new Point(277, 4);
            MinimizeFormButton.Name = "MinimizeFormButton";
            MinimizeFormButton.Size = new Size(48, 29);
            MinimizeFormButton.TabIndex = 5;
            MinimizeFormButton.Text = "━";
            MinimizeFormButton.UseVisualStyleBackColor = false;
            MinimizeFormButton.Click += MinimizeFormButton_Click;
            // 
            // CloseFormButton
            // 
            CloseFormButton.BackColor = Color.FromArgb(255, 50, 0);
            CloseFormButton.FlatAppearance.BorderSize = 0;
            CloseFormButton.FlatStyle = FlatStyle.Flat;
            CloseFormButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseFormButton.ForeColor = Color.FromArgb(43, 42, 41);
            CloseFormButton.Location = new Point(331, 4);
            CloseFormButton.Name = "CloseFormButton";
            CloseFormButton.Size = new Size(48, 29);
            CloseFormButton.TabIndex = 4;
            CloseFormButton.Text = "✕";
            CloseFormButton.UseVisualStyleBackColor = false;
            CloseFormButton.Click += CloseFormButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 147);
            panel3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 42, 41);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(152, 102);
            button1.Name = "button1";
            button1.Size = new Size(227, 36);
            button1.TabIndex = 2;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(43, 42, 41);
            textBox2.Location = new Point(152, 58);
            textBox2.Margin = new Padding(30);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(227, 36);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(43, 42, 41);
            textBox1.Location = new Point(152, 10);
            textBox1.Margin = new Padding(30);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Login";
            textBox1.Size = new Size(227, 36);
            textBox1.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 184);
            Controls.Add(panel3);
            Controls.Add(WindowPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            WindowPanel.ResumeLayout(false);
            WindowPanel.PerformLayout();
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button MinimizeFormButton;
        private Button CloseFormButton;
    }
}