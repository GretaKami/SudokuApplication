namespace SudokuApplication
{
    partial class MainScreen
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
            this.label_hi = new System.Windows.Forms.Label();
            this.button_newGame = new System.Windows.Forms.Button();
            this.button_loadGame = new System.Windows.Forms.Button();
            this.button_statistics = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_hi
            // 
            this.label_hi.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_hi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hi.ForeColor = System.Drawing.Color.White;
            this.label_hi.Location = new System.Drawing.Point(0, 0);
            this.label_hi.Name = "label_hi";
            this.label_hi.Size = new System.Drawing.Size(461, 137);
            this.label_hi.TabIndex = 0;
            this.label_hi.Text = "Hi, ";
            this.label_hi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button_newGame
            // 
            this.button_newGame.BackColor = System.Drawing.Color.White;
            this.button_newGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newGame.ForeColor = System.Drawing.Color.Black;
            this.button_newGame.Location = new System.Drawing.Point(147, 170);
            this.button_newGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_newGame.Name = "button_newGame";
            this.button_newGame.Size = new System.Drawing.Size(167, 44);
            this.button_newGame.TabIndex = 1;
            this.button_newGame.Text = "Start new game";
            this.button_newGame.UseVisualStyleBackColor = false;
            this.button_newGame.Click += new System.EventHandler(this.button_newGame_Click);
            this.button_newGame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_newGame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_loadGame
            // 
            this.button_loadGame.BackColor = System.Drawing.Color.White;
            this.button_loadGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_loadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_loadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loadGame.ForeColor = System.Drawing.Color.Black;
            this.button_loadGame.Location = new System.Drawing.Point(147, 238);
            this.button_loadGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_loadGame.Name = "button_loadGame";
            this.button_loadGame.Size = new System.Drawing.Size(167, 44);
            this.button_loadGame.TabIndex = 2;
            this.button_loadGame.Text = "Load game";
            this.button_loadGame.UseVisualStyleBackColor = false;
            this.button_loadGame.Click += new System.EventHandler(this.button_loadGame_Click);
            this.button_loadGame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_loadGame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_statistics
            // 
            this.button_statistics.BackColor = System.Drawing.Color.White;
            this.button_statistics.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_statistics.ForeColor = System.Drawing.Color.Black;
            this.button_statistics.Location = new System.Drawing.Point(147, 300);
            this.button_statistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_statistics.Name = "button_statistics";
            this.button_statistics.Size = new System.Drawing.Size(167, 44);
            this.button_statistics.TabIndex = 3;
            this.button_statistics.Text = "Statistics";
            this.button_statistics.UseVisualStyleBackColor = false;
            this.button_statistics.Click += new System.EventHandler(this.button_statistics_Click);
            this.button_statistics.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_statistics.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_logOut
            // 
            this.button_logOut.BackColor = System.Drawing.Color.White;
            this.button_logOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logOut.ForeColor = System.Drawing.Color.Black;
            this.button_logOut.Location = new System.Drawing.Point(147, 369);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(167, 44);
            this.button_logOut.TabIndex = 4;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = false;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            this.button_logOut.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_logOut.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(461, 453);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.button_statistics);
            this.Controls.Add(this.button_loadGame);
            this.Controls.Add(this.button_newGame);
            this.Controls.Add(this.label_hi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_hi;
        private System.Windows.Forms.Button button_newGame;
        private System.Windows.Forms.Button button_loadGame;
        private System.Windows.Forms.Button button_statistics;
        private System.Windows.Forms.Button button_logOut;
    }
}

