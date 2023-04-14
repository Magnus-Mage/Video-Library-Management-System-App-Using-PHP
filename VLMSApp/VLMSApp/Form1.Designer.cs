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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Help = new FontAwesome.Sharp.IconButton();
            this.Inventory = new FontAwesome.Sharp.IconButton();
            this.Members = new FontAwesome.Sharp.IconButton();
            this.Entries = new FontAwesome.Sharp.IconButton();
            this.DashBoard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(532, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(868, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1140, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(532, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Search...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(237, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.DashBoard.IconChar = FontAwesome.Sharp.IconChar.House;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1191, 41);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1163, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1411, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panelMenu;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private FontAwesome.Sharp.IconButton Help;
        private FontAwesome.Sharp.IconButton Inventory;
        private FontAwesome.Sharp.IconButton Members;
        private FontAwesome.Sharp.IconButton Entries;
        private FontAwesome.Sharp.IconButton DashBoard;
        private PictureBox btnHome;
    }
}