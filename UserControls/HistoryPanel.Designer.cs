namespace ZX_WareHouse.UserControls
{
    partial class HistoryPanel
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
            panel1 = new Panel();
            HistoryGridView = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 42, 41);
            panel1.Controls.Add(HistoryGridView);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 411);
            panel1.TabIndex = 0;
            // 
            // HistoryGridView
            // 
            HistoryGridView.AllowUserToAddRows = false;
            HistoryGridView.AllowUserToDeleteRows = false;
            HistoryGridView.AllowUserToResizeColumns = false;
            HistoryGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HistoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            HistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoryGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            HistoryGridView.BackgroundColor = Color.FromArgb(43, 42, 41);
            HistoryGridView.BorderStyle = BorderStyle.None;
            HistoryGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            HistoryGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            HistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryGridView.Dock = DockStyle.Bottom;
            HistoryGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            HistoryGridView.GridColor = Color.FromArgb(43, 42, 41);
            HistoryGridView.Location = new Point(0, 33);
            HistoryGridView.MultiSelect = false;
            HistoryGridView.Name = "HistoryGridView";
            HistoryGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            HistoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            HistoryGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(43, 42, 41);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            HistoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            HistoryGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HistoryGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 41);
            HistoryGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            HistoryGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            HistoryGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(43, 42, 41);
            HistoryGridView.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            HistoryGridView.RowTemplate.Height = 25;
            HistoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HistoryGridView.ShowCellErrors = false;
            HistoryGridView.ShowCellToolTips = false;
            HistoryGridView.ShowEditingIcon = false;
            HistoryGridView.ShowRowErrors = false;
            HistoryGridView.Size = new Size(620, 378);
            HistoryGridView.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 1;
            label1.Text = "Release history";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HistoryPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HistoryPanel";
            Size = new Size(620, 411);
            Load += HistoryPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView HistoryGridView;
    }
}
