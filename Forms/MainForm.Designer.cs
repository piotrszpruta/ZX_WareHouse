﻿namespace ZX_WareHouse.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavigationPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            LoginUserLabel = new Label();
            WarehouseButton = new Button();
            UsersButton = new Button();
            ReleaseHistoryButton = new Button();
            FillPanelContainer = new Panel();
            NavigationPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(43, 42, 41);
            NavigationPanel.Controls.Add(panel1);
            NavigationPanel.Controls.Add(WarehouseButton);
            NavigationPanel.Controls.Add(UsersButton);
            NavigationPanel.Controls.Add(ReleaseHistoryButton);
            NavigationPanel.Dock = DockStyle.Left;
            NavigationPanel.FlowDirection = FlowDirection.TopDown;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(204, 459);
            NavigationPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(LoginUserLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 31);
            panel1.TabIndex = 3;
            // 
            // LoginUserLabel
            // 
            LoginUserLabel.AutoSize = true;
            LoginUserLabel.ForeColor = Color.White;
            LoginUserLabel.Location = new Point(9, 6);
            LoginUserLabel.Name = "LoginUserLabel";
            LoginUserLabel.Size = new Size(94, 15);
            LoginUserLabel.TabIndex = 0;
            LoginUserLabel.Text = "Logged as: USER";
            // 
            // WarehouseButton
            // 
            WarehouseButton.BackColor = Color.FromArgb(29, 29, 28);
            WarehouseButton.Cursor = Cursors.Hand;
            WarehouseButton.Dock = DockStyle.Left;
            WarehouseButton.FlatAppearance.BorderSize = 0;
            WarehouseButton.FlatStyle = FlatStyle.Flat;
            WarehouseButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            WarehouseButton.ForeColor = Color.White;
            WarehouseButton.Location = new Point(3, 40);
            WarehouseButton.Name = "WarehouseButton";
            WarehouseButton.Size = new Size(197, 37);
            WarehouseButton.TabIndex = 1;
            WarehouseButton.Text = "Warehouse";
            WarehouseButton.UseVisualStyleBackColor = false;
            WarehouseButton.Click += WarehouseButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.FromArgb(29, 29, 28);
            UsersButton.Cursor = Cursors.Hand;
            UsersButton.Dock = DockStyle.Left;
            UsersButton.FlatAppearance.BorderSize = 0;
            UsersButton.FlatStyle = FlatStyle.Flat;
            UsersButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UsersButton.ForeColor = Color.White;
            UsersButton.Location = new Point(3, 83);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(197, 37);
            UsersButton.TabIndex = 2;
            UsersButton.Text = "Settings";
            UsersButton.UseVisualStyleBackColor = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // ReleaseHistoryButton
            // 
            ReleaseHistoryButton.BackColor = Color.FromArgb(29, 29, 28);
            ReleaseHistoryButton.Cursor = Cursors.Hand;
            ReleaseHistoryButton.Dock = DockStyle.Left;
            ReleaseHistoryButton.FlatAppearance.BorderSize = 0;
            ReleaseHistoryButton.FlatStyle = FlatStyle.Flat;
            ReleaseHistoryButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReleaseHistoryButton.ForeColor = Color.White;
            ReleaseHistoryButton.Location = new Point(3, 126);
            ReleaseHistoryButton.Name = "ReleaseHistoryButton";
            ReleaseHistoryButton.Size = new Size(197, 37);
            ReleaseHistoryButton.TabIndex = 4;
            ReleaseHistoryButton.Text = "Release history";
            ReleaseHistoryButton.UseVisualStyleBackColor = false;
            ReleaseHistoryButton.Click += ReleaseHistoryButton_Click;
            // 
            // FillPanelContainer
            // 
            FillPanelContainer.BackColor = Color.FromArgb(43, 42, 41);
            FillPanelContainer.Dock = DockStyle.Fill;
            FillPanelContainer.Location = new Point(204, 0);
            FillPanelContainer.Name = "FillPanelContainer";
            FillPanelContainer.Size = new Size(860, 459);
            FillPanelContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 459);
            Controls.Add(FillPanelContainer);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Dashboard";
            Load += MainForm_Load;
            NavigationPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel NavigationPanel;
        private Button WarehouseButton;
        private Button UsersButton;
        private Panel panel1;
        private Label LoginUserLabel;
        private Panel FillPanelContainer;
        private Button button1;
        private Button ReleaseHistoryButton;
    }
}