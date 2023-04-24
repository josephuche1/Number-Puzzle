namespace Assignment_2_Puzzle
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
            menuStrip1 = new MenuStrip();
            gameMenuStrip = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            beginnerToolStripMenuItem = new ToolStripMenuItem();
            advancedToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            gameGrid = new TableLayoutPanel();
            btn_6 = new Button();
            btn_2 = new Button();
            btn_5 = new Button();
            btn_7 = new Button();
            btn_1 = new Button();
            btn_4 = new Button();
            btn_8 = new Button();
            btn_3 = new Button();
            btnNewGame = new Button();
            movesCountlbl = new Label();
            FireWorks1 = new PictureBox();
            Fireworks2 = new PictureBox();
            menuStrip1.SuspendLayout();
            gameGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FireWorks1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fireworks2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameMenuStrip, colorToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(483, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuStrip
            // 
            gameMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, rulesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            gameMenuStrip.Name = "gameMenuStrip";
            gameMenuStrip.Size = new Size(62, 24);
            gameMenuStrip.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(165, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beginnerToolStripMenuItem, advancedToolStripMenuItem });
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(165, 26);
            rulesToolStripMenuItem.Text = "Level";
            // 
            // beginnerToolStripMenuItem
            // 
            beginnerToolStripMenuItem.CheckOnClick = true;
            beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            beginnerToolStripMenuItem.Size = new Size(158, 26);
            beginnerToolStripMenuItem.Text = "Beginner";
            beginnerToolStripMenuItem.Click += beginnerToolStripMenuItem_Click;
            // 
            // advancedToolStripMenuItem
            // 
            advancedToolStripMenuItem.CheckOnClick = true;
            advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            advancedToolStripMenuItem.Size = new Size(158, 26);
            advancedToolStripMenuItem.Text = "Advanced";
            advancedToolStripMenuItem.Click += advancedToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, blueToolStripMenuItem, greenToolStripMenuItem, yellowToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(59, 24);
            colorToolStripMenuItem.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(131, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(131, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(131, 26);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new Size(131, 26);
            yellowToolStripMenuItem.Text = "Other";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // gameGrid
            // 
            gameGrid.BackColor = Color.LightGray;
            gameGrid.ColumnCount = 3;
            gameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            gameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            gameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            gameGrid.Controls.Add(btn_6, 2, 1);
            gameGrid.Controls.Add(btn_2, 0, 2);
            gameGrid.Controls.Add(btn_5, 1, 0);
            gameGrid.Controls.Add(btn_7, 0, 0);
            gameGrid.Controls.Add(btn_1, 2, 0);
            gameGrid.Controls.Add(btn_4, 1, 1);
            gameGrid.Controls.Add(btn_8, 0, 1);
            gameGrid.Controls.Add(btn_3, 2, 2);
            gameGrid.Location = new Point(44, 65);
            gameGrid.Name = "gameGrid";
            gameGrid.RowCount = 3;
            gameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gameGrid.Size = new Size(402, 341);
            gameGrid.TabIndex = 1;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.Gray;
            btn_6.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(270, 116);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(127, 106);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Gray;
            btn_2.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(3, 229);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(127, 106);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.Gray;
            btn_5.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.Location = new Point(136, 3);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(127, 106);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.Gray;
            btn_7.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(3, 3);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(127, 106);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Gray;
            btn_1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(270, 3);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(127, 106);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.Gray;
            btn_4.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(136, 116);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(127, 106);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.Gray;
            btn_8.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(3, 116);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(127, 106);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.Gray;
            btn_3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(270, 229);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(127, 106);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(194, 480);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(104, 46);
            btnNewGame.TabIndex = 2;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // movesCountlbl
            // 
            movesCountlbl.AutoSize = true;
            movesCountlbl.Location = new Point(204, 445);
            movesCountlbl.Name = "movesCountlbl";
            movesCountlbl.Size = new Size(67, 20);
            movesCountlbl.TabIndex = 3;
            movesCountlbl.Text = "Move #0";
            movesCountlbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // FireWorks1
            // 
            FireWorks1.Image = Properties.Resources.XNwd;
            FireWorks1.Location = new Point(44, 429);
            FireWorks1.Name = "FireWorks1";
            FireWorks1.Size = new Size(130, 97);
            FireWorks1.SizeMode = PictureBoxSizeMode.StretchImage;
            FireWorks1.TabIndex = 4;
            FireWorks1.TabStop = false;
            FireWorks1.Visible = false;
            // 
            // Fireworks2
            // 
            Fireworks2.Image = Properties.Resources.XNwd;
            Fireworks2.Location = new Point(316, 429);
            Fireworks2.Name = "Fireworks2";
            Fireworks2.Size = new Size(130, 97);
            Fireworks2.SizeMode = PictureBoxSizeMode.StretchImage;
            Fireworks2.TabIndex = 5;
            Fireworks2.TabStop = false;
            Fireworks2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 579);
            Controls.Add(Fireworks2);
            Controls.Add(FireWorks1);
            Controls.Add(movesCountlbl);
            Controls.Add(btnNewGame);
            Controls.Add(gameGrid);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Puzzle";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gameGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FireWorks1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fireworks2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameMenuStrip;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TableLayoutPanel gameGrid;
        private Button btn_1;
        private ToolStripMenuItem beginnerToolStripMenuItem;
        private ToolStripMenuItem advancedToolStripMenuItem;
        private Button btn_8;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_7;
        private Button btnNewGame;
        private Label movesCountlbl;
        private Button btn_6;
        private PictureBox FireWorks1;
        private PictureBox Fireworks2;
    }
}