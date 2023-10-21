namespace Tic_Tak_Toe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yangiUyinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malumotlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yangiUyinToolStripMenuItem,
            this.malumotlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yangiUyinToolStripMenuItem
            // 
            this.yangiUyinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yangiUyinToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yangiUyinToolStripMenuItem.Name = "yangiUyinToolStripMenuItem";
            this.yangiUyinToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.yangiUyinToolStripMenuItem.Text = "Yangi uyin";
            this.yangiUyinToolStripMenuItem.Click += new System.EventHandler(this.yangiUyinToolStripMenuItem_Click);
            // 
            // malumotlarToolStripMenuItem
            // 
            this.malumotlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.malumotlarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.malumotlarToolStripMenuItem.Name = "malumotlarToolStripMenuItem";
            this.malumotlarToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.malumotlarToolStripMenuItem.Text = "Ma\'lumotlar";
            this.malumotlarToolStripMenuItem.Click += new System.EventHandler(this.malumotlarToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 683);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // b9
            // 
            this.b9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b9.FlatAppearance.BorderSize = 5;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.Location = new System.Drawing.Point(589, 458);
            this.b9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(286, 221);
            this.b9.TabIndex = 8;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b8.FlatAppearance.BorderSize = 5;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b8.Location = new System.Drawing.Point(296, 458);
            this.b8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(285, 221);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b7.FlatAppearance.BorderSize = 5;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.Location = new System.Drawing.Point(4, 458);
            this.b7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(284, 221);
            this.b7.TabIndex = 6;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b6.FlatAppearance.BorderSize = 5;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.Location = new System.Drawing.Point(589, 231);
            this.b6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(286, 219);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b5
            // 
            this.b5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b5.FlatAppearance.BorderSize = 5;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.Location = new System.Drawing.Point(296, 231);
            this.b5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(285, 219);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b4.FlatAppearance.BorderSize = 5;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.Location = new System.Drawing.Point(4, 231);
            this.b4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(284, 219);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3.FlatAppearance.BorderSize = 5;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.Location = new System.Drawing.Point(589, 4);
            this.b3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(286, 219);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2.FlatAppearance.BorderSize = 5;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.Location = new System.Drawing.Point(296, 4);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(285, 219);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1.FlatAppearance.BorderSize = 5;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Location = new System.Drawing.Point(4, 4);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(284, 219);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 708);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1281, 1222);
            this.MinimumSize = new System.Drawing.Size(445, 606);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tak Toe";
            this.Click += new System.EventHandler(this.button_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yangiUyinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malumotlarToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
    }
}

