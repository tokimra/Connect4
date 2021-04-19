
namespace Connect4
{
    partial class Form2
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColumn1 = new System.Windows.Forms.Button();
            this.btnColumn2 = new System.Windows.Forms.Button();
            this.btnColumn3 = new System.Windows.Forms.Button();
            this.btnColumn4 = new System.Windows.Forms.Button();
            this.btnColumn6 = new System.Windows.Forms.Button();
            this.btnColumn5 = new System.Windows.Forms.Button();
            this.btnColumn7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.menuNewGamePress);
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitGameToolStripMenuItem.Text = "Quit";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.menuQuitPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 394);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColumn7);
            this.groupBox1.Controls.Add(this.btnColumn5);
            this.groupBox1.Controls.Add(this.btnColumn6);
            this.groupBox1.Controls.Add(this.btnColumn4);
            this.groupBox1.Controls.Add(this.btnColumn3);
            this.groupBox1.Controls.Add(this.btnColumn2);
            this.groupBox1.Controls.Add(this.btnColumn1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 25);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnColumn1
            // 
            this.btnColumn1.Location = new System.Drawing.Point(21, 0);
            this.btnColumn1.Name = "btnColumn1";
            this.btnColumn1.Size = new System.Drawing.Size(75, 23);
            this.btnColumn1.TabIndex = 0;
            this.btnColumn1.Text = "Column 1";
            this.btnColumn1.UseVisualStyleBackColor = true;
            this.btnColumn1.Click += new System.EventHandler(this.btnColumn1Press);
            // 
            // btnColumn2
            // 
            this.btnColumn2.Location = new System.Drawing.Point(129, 0);
            this.btnColumn2.Name = "btnColumn2";
            this.btnColumn2.Size = new System.Drawing.Size(75, 23);
            this.btnColumn2.TabIndex = 1;
            this.btnColumn2.Text = "Column 2";
            this.btnColumn2.UseVisualStyleBackColor = true;
            this.btnColumn2.Click += new System.EventHandler(this.btnColumn2Press);
            // 
            // btnColumn3
            // 
            this.btnColumn3.Location = new System.Drawing.Point(244, 0);
            this.btnColumn3.Name = "btnColumn3";
            this.btnColumn3.Size = new System.Drawing.Size(75, 23);
            this.btnColumn3.TabIndex = 2;
            this.btnColumn3.Text = "Column 3";
            this.btnColumn3.UseVisualStyleBackColor = true;
            this.btnColumn3.Click += new System.EventHandler(this.btnColumn3Press);
            // 
            // btnColumn4
            // 
            this.btnColumn4.Location = new System.Drawing.Point(358, 0);
            this.btnColumn4.Name = "btnColumn4";
            this.btnColumn4.Size = new System.Drawing.Size(75, 23);
            this.btnColumn4.TabIndex = 3;
            this.btnColumn4.Text = "Column 4";
            this.btnColumn4.UseVisualStyleBackColor = true;
            this.btnColumn4.Click += new System.EventHandler(this.btnColumn4Press);
            // 
            // btnColumn6
            // 
            this.btnColumn6.Location = new System.Drawing.Point(582, 0);
            this.btnColumn6.Name = "btnColumn6";
            this.btnColumn6.Size = new System.Drawing.Size(75, 23);
            this.btnColumn6.TabIndex = 4;
            this.btnColumn6.Text = "Column 6";
            this.btnColumn6.UseVisualStyleBackColor = true;
            this.btnColumn6.Click += new System.EventHandler(this.btnColumn6Press);
            // 
            // btnColumn5
            // 
            this.btnColumn5.Location = new System.Drawing.Point(468, 0);
            this.btnColumn5.Name = "btnColumn5";
            this.btnColumn5.Size = new System.Drawing.Size(75, 23);
            this.btnColumn5.TabIndex = 5;
            this.btnColumn5.Text = "Column 5";
            this.btnColumn5.UseVisualStyleBackColor = true;
            this.btnColumn5.Click += new System.EventHandler(this.btnColumn5Press);
            // 
            // btnColumn7
            // 
            this.btnColumn7.Location = new System.Drawing.Point(702, 0);
            this.btnColumn7.Name = "btnColumn7";
            this.btnColumn7.Size = new System.Drawing.Size(75, 23);
            this.btnColumn7.TabIndex = 6;
            this.btnColumn7.Text = "Column 7";
            this.btnColumn7.UseVisualStyleBackColor = true;
            this.btnColumn7.Click += new System.EventHandler(this.btnColumn7Press);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColumn7;
        private System.Windows.Forms.Button btnColumn5;
        private System.Windows.Forms.Button btnColumn6;
        private System.Windows.Forms.Button btnColumn4;
        private System.Windows.Forms.Button btnColumn3;
        private System.Windows.Forms.Button btnColumn2;
        private System.Windows.Forms.Button btnColumn1;
    }
}