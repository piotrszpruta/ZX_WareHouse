namespace ZX_WareHouse.UserControls
{
    partial class WarehousePanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ProductGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            newDeliveryToolStripMenuItem = new ToolStripMenuItem();
            newTakeOutToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 1;
            label1.Text = "Warehouse";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(43, 42, 41);
            groupBox1.Controls.Add(ProductGridView);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(4, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 336);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
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
            ProductGridView.BackgroundColor = Color.FromArgb(43, 42, 41);
            ProductGridView.BorderStyle = BorderStyle.None;
            ProductGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProductGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Dock = DockStyle.Fill;
            ProductGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductGridView.GridColor = Color.FromArgb(43, 42, 41);
            ProductGridView.Location = new Point(3, 25);
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
            ProductGridView.Size = new Size(608, 308);
            ProductGridView.TabIndex = 0;
            ProductGridView.DoubleClick += ProductGridView_DoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newDeliveryToolStripMenuItem, newTakeOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 0, 0, 0);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(620, 39);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "Menu";
            // 
            // newDeliveryToolStripMenuItem
            // 
            newDeliveryToolStripMenuItem.BackColor = Color.FromArgb(29, 29, 28);
            newDeliveryToolStripMenuItem.ForeColor = Color.White;
            newDeliveryToolStripMenuItem.Name = "newDeliveryToolStripMenuItem";
            newDeliveryToolStripMenuItem.Size = new Size(87, 39);
            newDeliveryToolStripMenuItem.Text = "New delivery";
            newDeliveryToolStripMenuItem.Click += newDeliveryToolStripMenuItem_Click;
            // 
            // newTakeOutToolStripMenuItem
            // 
            newTakeOutToolStripMenuItem.BackColor = Color.FromArgb(29, 29, 28);
            newTakeOutToolStripMenuItem.ForeColor = Color.White;
            newTakeOutToolStripMenuItem.Name = "newTakeOutToolStripMenuItem";
            newTakeOutToolStripMenuItem.Padding = new Padding(10);
            newTakeOutToolStripMenuItem.Size = new Size(94, 39);
            newTakeOutToolStripMenuItem.Text = "New release";
            newTakeOutToolStripMenuItem.Click += newTakeOutToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(513, 65);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Double tap to edit";
            // 
            // WarehousePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 41);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "WarehousePanel";
            Size = new Size(620, 411);
            Load += WarehousePanel_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView ProductGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newDeliveryToolStripMenuItem;
        private ToolStripMenuItem newTakeOutToolStripMenuItem;
        private Label label2;
    }
}
