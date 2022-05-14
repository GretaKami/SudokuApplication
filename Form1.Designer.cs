using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuApplication
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
            this.panelBoard = new System.Windows.Forms.Panel();
            this.panel_finishedGame = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_backToMainScreen = new System.Windows.Forms.Button();
            this.button_playAgain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_checkGame = new System.Windows.Forms.Button();
            this.button_saveGame = new System.Windows.Forms.Button();
            this.panelBoard.SuspendLayout();
            this.panel_finishedGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Controls.Add(this.panel_finishedGame);
            this.panelBoard.Location = new System.Drawing.Point(31, 26);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(480, 443);
            this.panelBoard.TabIndex = 0;
            // 
            // panel_finishedGame
            // 
            this.panel_finishedGame.BackColor = System.Drawing.Color.DimGray;
            this.panel_finishedGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_finishedGame.Controls.Add(this.label3);
            this.panel_finishedGame.Controls.Add(this.button_backToMainScreen);
            this.panel_finishedGame.Controls.Add(this.button_playAgain);
            this.panel_finishedGame.Controls.Add(this.label2);
            this.panel_finishedGame.Controls.Add(this.label1);
            this.panel_finishedGame.Location = new System.Drawing.Point(45, 62);
            this.panel_finishedGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_finishedGame.Name = "panel_finishedGame";
            this.panel_finishedGame.Size = new System.Drawing.Size(385, 315);
            this.panel_finishedGame.TabIndex = 0;
            this.panel_finishedGame.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 79);
            this.label3.TabIndex = 2;
            this.label3.Text = "Would You like to play again?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button_backToMainScreen
            // 
            this.button_backToMainScreen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_backToMainScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backToMainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backToMainScreen.ForeColor = System.Drawing.Color.White;
            this.button_backToMainScreen.Location = new System.Drawing.Point(215, 209);
            this.button_backToMainScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_backToMainScreen.Name = "button_backToMainScreen";
            this.button_backToMainScreen.Size = new System.Drawing.Size(123, 41);
            this.button_backToMainScreen.TabIndex = 11;
            this.button_backToMainScreen.Text = "No";
            this.button_backToMainScreen.UseVisualStyleBackColor = true;
            this.button_backToMainScreen.Click += new System.EventHandler(this.button_backToMainCreen_Click);
            this.button_backToMainScreen.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_backToMainScreen.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_playAgain
            // 
            this.button_playAgain.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playAgain.ForeColor = System.Drawing.Color.Aqua;
            this.button_playAgain.Location = new System.Drawing.Point(45, 209);
            this.button_playAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_playAgain.Name = "button_playAgain";
            this.button_playAgain.Size = new System.Drawing.Size(123, 41);
            this.button_playAgain.TabIndex = 10;
            this.button_playAgain.Text = "Yes!";
            this.button_playAgain.UseVisualStyleBackColor = true;
            this.button_playAgain.Click += new System.EventHandler(this.button_playAgain_Click);
            this.button_playAgain.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_playAgain.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "You have successfully solved the game!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations! ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button_back
            // 
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(388, 539);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(123, 41);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            this.button_back.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_back.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_checkGame
            // 
            this.button_checkGame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_checkGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkGame.ForeColor = System.Drawing.Color.Aqua;
            this.button_checkGame.Location = new System.Drawing.Point(31, 539);
            this.button_checkGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_checkGame.Name = "button_checkGame";
            this.button_checkGame.Size = new System.Drawing.Size(123, 41);
            this.button_checkGame.TabIndex = 7;
            this.button_checkGame.Text = "Check";
            this.button_checkGame.UseVisualStyleBackColor = true;
            this.button_checkGame.Click += new System.EventHandler(this.button_checkGame_Click);
            this.button_checkGame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_checkGame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_saveGame
            // 
            this.button_saveGame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_saveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveGame.ForeColor = System.Drawing.Color.White;
            this.button_saveGame.Location = new System.Drawing.Point(201, 539);
            this.button_saveGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_saveGame.Name = "button_saveGame";
            this.button_saveGame.Size = new System.Drawing.Size(123, 41);
            this.button_saveGame.TabIndex = 9;
            this.button_saveGame.Text = "Save";
            this.button_saveGame.UseVisualStyleBackColor = true;
            this.button_saveGame.Click += new System.EventHandler(this.button_saveGame_Click);
            this.button_saveGame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_saveGame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(539, 654);
            this.Controls.Add(this.button_saveGame);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_checkGame);
            this.Controls.Add(this.panelBoard);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelBoard.ResumeLayout(false);
            this.panel_finishedGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

     
        private Panel panelBoard;
        private Button button_back;
        private Button button_checkGame;
        private Button button_saveGame;
        private Panel panel_finishedGame;
        private Button button_backToMainScreen;
        private Button button_playAgain;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}

