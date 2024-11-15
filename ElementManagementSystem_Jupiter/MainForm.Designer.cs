namespace ElementManagementSystem_Jupiter
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RetrunButton = new System.Windows.Forms.Button();
            this.RentalButton = new System.Windows.Forms.Button();
            this.OutgoingButton = new System.Windows.Forms.Button();
            this.IncomingButton = new System.Windows.Forms.Button();
            this.Mainbutton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CSVExportButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1653F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1653, 1024);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.RetrunButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.RentalButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.OutgoingButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.IncomingButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Mainbutton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveButton, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1647, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RetrunButton
            // 
            this.RetrunButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetrunButton.Location = new System.Drawing.Point(403, 3);
            this.RetrunButton.Name = "RetrunButton";
            this.RetrunButton.Size = new System.Drawing.Size(94, 88);
            this.RetrunButton.TabIndex = 5;
            this.RetrunButton.Text = "반납";
            this.RetrunButton.UseVisualStyleBackColor = true;
            this.RetrunButton.Click += new System.EventHandler(this.RetrunButton_Click);
            // 
            // RentalButton
            // 
            this.RentalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalButton.Location = new System.Drawing.Point(303, 3);
            this.RentalButton.Name = "RentalButton";
            this.RentalButton.Size = new System.Drawing.Size(94, 88);
            this.RentalButton.TabIndex = 4;
            this.RentalButton.Text = "대여";
            this.RentalButton.UseVisualStyleBackColor = true;
            this.RentalButton.Click += new System.EventHandler(this.RentalButton_Click);
            // 
            // OutgoingButton
            // 
            this.OutgoingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutgoingButton.Location = new System.Drawing.Point(203, 3);
            this.OutgoingButton.Name = "OutgoingButton";
            this.OutgoingButton.Size = new System.Drawing.Size(94, 88);
            this.OutgoingButton.TabIndex = 3;
            this.OutgoingButton.Text = "출고";
            this.OutgoingButton.UseVisualStyleBackColor = true;
            this.OutgoingButton.Click += new System.EventHandler(this.OutgoingButton_Click);
            // 
            // IncomingButton
            // 
            this.IncomingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomingButton.Location = new System.Drawing.Point(103, 3);
            this.IncomingButton.Name = "IncomingButton";
            this.IncomingButton.Size = new System.Drawing.Size(94, 88);
            this.IncomingButton.TabIndex = 2;
            this.IncomingButton.Text = "입고";
            this.IncomingButton.UseVisualStyleBackColor = true;
            this.IncomingButton.Click += new System.EventHandler(this.IncomingButton_Click);
            // 
            // Mainbutton
            // 
            this.Mainbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainbutton.Location = new System.Drawing.Point(3, 3);
            this.Mainbutton.Name = "Mainbutton";
            this.Mainbutton.Size = new System.Drawing.Size(94, 88);
            this.Mainbutton.TabIndex = 1;
            this.Mainbutton.Text = "전체";
            this.Mainbutton.UseVisualStyleBackColor = true;
            this.Mainbutton.Click += new System.EventHandler(this.Mainbutton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(1550, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 88);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "저장";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.MainTableLayoutPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 103);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1647, 918);
            this.MainPanel.TabIndex = 1;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainTableLayoutPanel.Controls.Add(this.MainDataGridView, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1647, 918);
            this.MainTableLayoutPanel.TabIndex = 5;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(3, 3);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowHeadersVisible = false;
            this.MainDataGridView.RowHeadersWidth = 62;
            this.MainDataGridView.RowTemplate.Height = 30;
            this.MainDataGridView.Size = new System.Drawing.Size(1491, 912);
            this.MainDataGridView.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 1;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.DeleteButton, 0, 2);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditButton, 0, 3);
            this.ButtonsTableLayoutPanel.Controls.Add(this.CSVExportButton, 0, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(1500, 3);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 5;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(144, 912);
            this.ButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(3, 203);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(138, 94);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 103);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(138, 94);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "추가";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.Location = new System.Drawing.Point(3, 303);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(138, 94);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "수정";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // CSVExportButton
            // 
            this.CSVExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSVExportButton.Location = new System.Drawing.Point(3, 3);
            this.CSVExportButton.Name = "CSVExportButton";
            this.CSVExportButton.Size = new System.Drawing.Size(138, 94);
            this.CSVExportButton.TabIndex = 0;
            this.CSVExportButton.Text = "CSV 추출";
            this.CSVExportButton.UseVisualStyleBackColor = true;
            this.CSVExportButton.Click += new System.EventHandler(this.CSVExportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1653, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "재고관리";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button RetrunButton;
        private System.Windows.Forms.Button RentalButton;
        private System.Windows.Forms.Button OutgoingButton;
        private System.Windows.Forms.Button IncomingButton;
        private System.Windows.Forms.Button Mainbutton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CSVExportButton;
    }
}