namespace SudokuApplication
{
    partial class MainScreen_StartNewGame
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
            this.groupBox_gameDifficulty = new System.Windows.Forms.GroupBox();
            this.button_difficultyHard = new System.Windows.Forms.Button();
            this.button_difficultyMedium = new System.Windows.Forms.Button();
            this.button_difficultyEasy = new System.Windows.Forms.Button();
            this.button_startGame = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_gameDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_gameDifficulty
            // 
            this.groupBox_gameDifficulty.BackColor = System.Drawing.Color.Maroon;
            this.groupBox_gameDifficulty.Controls.Add(this.button_difficultyHard);
            this.groupBox_gameDifficulty.Controls.Add(this.button_difficultyMedium);
            this.groupBox_gameDifficulty.Controls.Add(this.button_difficultyEasy);
            this.groupBox_gameDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_gameDifficulty.ForeColor = System.Drawing.Color.White;
            this.groupBox_gameDifficulty.Location = new System.Drawing.Point(31, 198);
            this.groupBox_gameDifficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_gameDifficulty.Name = "groupBox_gameDifficulty";
            this.groupBox_gameDifficulty.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_gameDifficulty.Size = new System.Drawing.Size(396, 100);
            this.groupBox_gameDifficulty.TabIndex = 4;
            this.groupBox_gameDifficulty.TabStop = false;
            this.groupBox_gameDifficulty.Text = "Game difficulty";
            // 
            // button_difficultyHard
            // 
            this.button_difficultyHard.BackColor = System.Drawing.Color.White;
            this.button_difficultyHard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_difficultyHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_difficultyHard.ForeColor = System.Drawing.Color.Black;
            this.button_difficultyHard.Location = new System.Drawing.Point(275, 39);
            this.button_difficultyHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_difficultyHard.Name = "button_difficultyHard";
            this.button_difficultyHard.Size = new System.Drawing.Size(93, 37);
            this.button_difficultyHard.TabIndex = 2;
            this.button_difficultyHard.Text = "Hard";
            this.button_difficultyHard.UseVisualStyleBackColor = false;
            this.button_difficultyHard.Click += new System.EventHandler(this.button_gameDifficulty_Click);
            // 
            // button_difficultyMedium
            // 
            this.button_difficultyMedium.BackColor = System.Drawing.Color.White;
            this.button_difficultyMedium.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_difficultyMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_difficultyMedium.ForeColor = System.Drawing.Color.Black;
            this.button_difficultyMedium.Location = new System.Drawing.Point(151, 39);
            this.button_difficultyMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_difficultyMedium.Name = "button_difficultyMedium";
            this.button_difficultyMedium.Size = new System.Drawing.Size(93, 37);
            this.button_difficultyMedium.TabIndex = 1;
            this.button_difficultyMedium.Text = "Medium";
            this.button_difficultyMedium.UseVisualStyleBackColor = false;
            this.button_difficultyMedium.Click += new System.EventHandler(this.button_gameDifficulty_Click);
            // 
            // button_difficultyEasy
            // 
            this.button_difficultyEasy.BackColor = System.Drawing.Color.White;
            this.button_difficultyEasy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_difficultyEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_difficultyEasy.ForeColor = System.Drawing.Color.Black;
            this.button_difficultyEasy.Location = new System.Drawing.Point(28, 39);
            this.button_difficultyEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_difficultyEasy.Name = "button_difficultyEasy";
            this.button_difficultyEasy.Size = new System.Drawing.Size(93, 37);
            this.button_difficultyEasy.TabIndex = 0;
            this.button_difficultyEasy.Text = "Easy";
            this.button_difficultyEasy.UseVisualStyleBackColor = false;
            this.button_difficultyEasy.Click += new System.EventHandler(this.button_gameDifficulty_Click);
            // 
            // button_startGame
            // 
            this.button_startGame.Enabled = false;
            this.button_startGame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startGame.ForeColor = System.Drawing.Color.Aqua;
            this.button_startGame.Location = new System.Drawing.Point(72, 358);
            this.button_startGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(123, 41);
            this.button_startGame.TabIndex = 5;
            this.button_startGame.Text = "Start !";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            this.button_startGame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_startGame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_back
            // 
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(253, 358);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(123, 41);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.buttonBack_Click);
            this.button_back.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_back.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 144);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please choose the difficulty level!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainScreen_StartNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(461, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_startGame);
            this.Controls.Add(this.groupBox_gameDifficulty);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainScreen_StartNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_StartNewGame_FormClosing);
            this.groupBox_gameDifficulty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_gameDifficulty;
        private System.Windows.Forms.Button button_difficultyHard;
        private System.Windows.Forms.Button button_difficultyMedium;
        private System.Windows.Forms.Button button_difficultyEasy;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label1;
    }
}