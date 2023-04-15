namespace VLMSApp.Forms
{
    partial class FormInventory
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
            this.searchRecords = new System.Windows.Forms.Button();
            this.videoSearchBox = new System.Windows.Forms.TextBox();
            this.videoDataGridView = new System.Windows.Forms.DataGridView();
            this.videoPicture = new System.Windows.Forms.PictureBox();
            this.loadRecords = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.searchRecords);
            this.panelDesktop.Controls.Add(this.videoSearchBox);
            this.panelDesktop.Controls.Add(this.videoDataGridView);
            this.panelDesktop.Controls.Add(this.videoPicture);
            this.panelDesktop.Controls.Add(this.loadRecords);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1059, 510);
            this.panelDesktop.TabIndex = 12;
            // 
            // searchRecords
            // 
            this.searchRecords.Location = new System.Drawing.Point(938, 84);
            this.searchRecords.Name = "searchRecords";
            this.searchRecords.Size = new System.Drawing.Size(109, 28);
            this.searchRecords.TabIndex = 4;
            this.searchRecords.Text = "Search";
            this.searchRecords.UseVisualStyleBackColor = true;
            this.searchRecords.Click += new System.EventHandler(this.searchRecords_Click);
            // 
            // videoSearchBox
            // 
            this.videoSearchBox.Location = new System.Drawing.Point(251, 84);
            this.videoSearchBox.Name = "videoSearchBox";
            this.videoSearchBox.Size = new System.Drawing.Size(681, 27);
            this.videoSearchBox.TabIndex = 3;
            // 
            // videoDataGridView
            // 
            this.videoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoDataGridView.Location = new System.Drawing.Point(251, 124);
            this.videoDataGridView.Name = "videoDataGridView";
            this.videoDataGridView.RowHeadersWidth = 51;
            this.videoDataGridView.RowTemplate.Height = 29;
            this.videoDataGridView.Size = new System.Drawing.Size(796, 257);
            this.videoDataGridView.TabIndex = 2;
            this.videoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videoDataGridView_CellClick);
            // 
            // videoPicture
            // 
            this.videoPicture.Location = new System.Drawing.Point(26, 124);
            this.videoPicture.Name = "videoPicture";
            this.videoPicture.Size = new System.Drawing.Size(219, 257);
            this.videoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoPicture.TabIndex = 1;
            this.videoPicture.TabStop = false;
            // 
            // loadRecords
            // 
            this.loadRecords.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loadRecords.IconColor = System.Drawing.Color.Black;
            this.loadRecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loadRecords.Location = new System.Drawing.Point(120, 82);
            this.loadRecords.Name = "loadRecords";
            this.loadRecords.Size = new System.Drawing.Size(125, 29);
            this.loadRecords.TabIndex = 0;
            this.loadRecords.Text = "Load Records";
            this.loadRecords.UseVisualStyleBackColor = true;
            this.loadRecords.Click += new System.EventHandler(this.loadRecords_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 510);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDesktop;
        private Button searchRecords;
        private TextBox videoSearchBox;
        private DataGridView videoDataGridView;
        private PictureBox videoPicture;
        private FontAwesome.Sharp.IconButton loadRecords;
    }
}