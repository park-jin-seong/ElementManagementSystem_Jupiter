namespace ElementManagementSystem_Jupiter.PanelControls
{
    partial class OutgoingUserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CSVExportButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.MainDataGridView.Size = new System.Drawing.Size(766, 644);
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
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(775, 3);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 5;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(144, 644);
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
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(922, 650);
            this.MainTableLayoutPanel.TabIndex = 3;
            // 
            // OutgoingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "OutgoingUserControl";
            this.Size = new System.Drawing.Size(922, 650);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CSVExportButton;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
    }
}
