namespace VLMSApp.Forms
{
    partial class FormDashBoard
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.DpictureBox = new System.Windows.Forms.PictureBox();
            this.DdataGridView = new System.Windows.Forms.DataGridView();
            this.DLoadRecord = new System.Windows.Forms.Button();
            this.DSearch = new System.Windows.Forms.TextBox();
            this.DSearchButton = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.DpictureBox);
            this.panelDesktop.Controls.Add(this.DdataGridView);
            this.panelDesktop.Controls.Add(this.DSearchButton);
            this.panelDesktop.Controls.Add(this.DSearch);
            this.panelDesktop.Controls.Add(this.DLoadRecord);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1059, 510);
            this.panelDesktop.TabIndex = 11;
            // 
            // DpictureBox
            // 
            this.DpictureBox.Location = new System.Drawing.Point(12, 102);
            this.DpictureBox.Name = "DpictureBox";
            this.DpictureBox.Size = new System.Drawing.Size(282, 294);
            this.DpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DpictureBox.TabIndex = 9;
            this.DpictureBox.TabStop = false;
            // 
            // DdataGridView
            // 
            this.DdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DdataGridView.Location = new System.Drawing.Point(300, 102);
            this.DdataGridView.Name = "DdataGridView";
            this.DdataGridView.RowHeadersWidth = 51;
            this.DdataGridView.RowTemplate.Height = 29;
            this.DdataGridView.Size = new System.Drawing.Size(736, 294);
            this.DdataGridView.TabIndex = 6;
            // 
            // DLoadRecord
            // 
            this.DLoadRecord.Location = new System.Drawing.Point(65, 49);
            this.DLoadRecord.Name = "DLoadRecord";
            this.DLoadRecord.Size = new System.Drawing.Size(229, 29);
            this.DLoadRecord.TabIndex = 5;
            this.DLoadRecord.Text = "Load Records";
            this.DLoadRecord.UseVisualStyleBackColor = true;
            // 
            // DSearch
            // 
            this.DSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.DSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.DSearch.Location = new System.Drawing.Point(319, 54);
            this.DSearch.Name = "DSearch";
            this.DSearch.Size = new System.Drawing.Size(602, 24);
            this.DSearch.TabIndex = 8;
            this.DSearch.Text = "Search...";
            // 
            // DSearchButton
            // 
            this.DSearchButton.Location = new System.Drawing.Point(927, 49);
            this.DSearchButton.Name = "DSearchButton";
            this.DSearchButton.Size = new System.Drawing.Size(109, 29);
            this.DSearchButton.TabIndex = 7;
            this.DSearchButton.Text = "Search";
            this.DSearchButton.UseVisualStyleBackColor = true;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 510);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormDashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.FormDashBoard_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDesktop;
        private PictureBox DpictureBox;
        private DataGridView DdataGridView;
        private Button DLoadRecord;
        private TextBox DSearch;
        private Button DSearchButton;
    }
}