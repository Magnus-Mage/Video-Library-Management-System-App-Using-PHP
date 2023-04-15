namespace VLMSApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Help = new FontAwesome.Sharp.IconButton();
            this.Inventory = new FontAwesome.Sharp.IconButton();
            this.Members = new FontAwesome.Sharp.IconButton();
            this.Entries = new FontAwesome.Sharp.IconButton();
            this.DashBoard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.MinimiseBtn = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Help);
            this.panelMenu.Controls.Add(this.Inventory);
            this.panelMenu.Controls.Add(this.Members);
            this.panelMenu.Controls.Add(this.Entries);
            this.panelMenu.Controls.Add(this.DashBoard);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 577);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // Help
            // 
            this.Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.ForeColor = System.Drawing.Color.Gainsboro;
            this.Help.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.Help.IconColor = System.Drawing.Color.Gainsboro;
            this.Help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Help.IconSize = 32;
            this.Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help.Location = new System.Drawing.Point(0, 380);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Help.Size = new System.Drawing.Size(220, 60);
            this.Help.TabIndex = 5;
            this.Help.Text = "Help";
            this.Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Inventory
            // 
            this.Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inventory.FlatAppearance.BorderSize = 0;
            this.Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory.ForeColor = System.Drawing.Color.Gainsboro;
            this.Inventory.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Inventory.IconColor = System.Drawing.Color.Gainsboro;
            this.Inventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Inventory.IconSize = 32;
            this.Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.Location = new System.Drawing.Point(0, 320);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Inventory.Size = new System.Drawing.Size(220, 60);
            this.Inventory.TabIndex = 4;
            this.Inventory.Text = "Inventory";
            this.Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Members
            // 
            this.Members.Dock = System.Windows.Forms.DockStyle.Top;
            this.Members.FlatAppearance.BorderSize = 0;
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.ForeColor = System.Drawing.Color.Gainsboro;
            this.Members.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.Members.IconColor = System.Drawing.Color.Gainsboro;
            this.Members.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Members.IconSize = 32;
            this.Members.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Members.Location = new System.Drawing.Point(0, 260);
            this.Members.Name = "Members";
            this.Members.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Members.Size = new System.Drawing.Size(220, 60);
            this.Members.TabIndex = 3;
            this.Members.Text = "Members";
            this.Members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Members.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Members.UseVisualStyleBackColor = true;
            this.Members.Click += new System.EventHandler(this.Members_Click);
            // 
            // Entries
            // 
            this.Entries.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entries.FlatAppearance.BorderSize = 0;
            this.Entries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entries.ForeColor = System.Drawing.Color.Gainsboro;
            this.Entries.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.Entries.IconColor = System.Drawing.Color.Gainsboro;
            this.Entries.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Entries.IconSize = 32;
            this.Entries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Entries.Location = new System.Drawing.Point(0, 200);
            this.Entries.Name = "Entries";
            this.Entries.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Entries.Size = new System.Drawing.Size(220, 60);
            this.Entries.TabIndex = 2;
            this.Entries.Text = "Entries";
            this.Entries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Entries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Entries.UseVisualStyleBackColor = true;
            this.Entries.Click += new System.EventHandler(this.Entries_Click);
            // 
            // DashBoard
            // 
            this.DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoard.FlatAppearance.BorderSize = 0;
            this.DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoard.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashBoard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.DashBoard.IconColor = System.Drawing.Color.Gainsboro;
            this.DashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashBoard.IconSize = 32;
            this.DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoard.Location = new System.Drawing.Point(0, 140);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DashBoard.Size = new System.Drawing.Size(220, 60);
            this.DashBoard.TabIndex = 1;
            this.DashBoard.Text = "DashBoard";
            this.DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashBoard.UseVisualStyleBackColor = true;
            this.DashBoard.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::VLMSApp.Properties.Resources.file2_0;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(195, 99);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.MinimiseBtn);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.button3);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1191, 70);
            this.panelTitleBar.TabIndex = 6;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // MinimiseBtn
            // 
            this.MinimiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.MinimiseBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimiseBtn.IconColor = System.Drawing.Color.White;
            this.MinimiseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimiseBtn.IconSize = 25;
            this.MinimiseBtn.Location = new System.Drawing.Point(1123, 12);
            this.MinimiseBtn.Name = "MinimiseBtn";
            this.MinimiseBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimiseBtn.TabIndex = 3;
            this.MinimiseBtn.TabStop = false;
            this.MinimiseBtn.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(60, 15);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(50, 20);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1154, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1191, 498);
            this.panelDesktop.TabIndex = 8;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1191, 9);
            this.panelShadow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1411, 577);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private Panel panel2;
        private Panel panelTitleBar;
        private Button button3;
        private FontAwesome.Sharp.IconButton Help;
        private FontAwesome.Sharp.IconButton Inventory;
        private FontAwesome.Sharp.IconButton Members;
        private FontAwesome.Sharp.IconButton Entries;
        private FontAwesome.Sharp.IconButton DashBoard;
        private PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelDesktop;
        private Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox MinimiseBtn;
    }
}