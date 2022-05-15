namespace SudokuApplication
{
    partial class MainScreen_LoadGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen_LoadGame));
            this.label1 = new System.Windows.Forms.Label();
            this.listView_loadGame = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Difficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Solved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_back = new System.Windows.Forms.Button();
            this.button_startGame = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the game you want to load!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listView_loadGame
            // 
            this.listView_loadGame.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Difficulty,
            this.Solved});
            this.listView_loadGame.FullRowSelect = true;
            this.listView_loadGame.HideSelection = false;
            this.listView_loadGame.Location = new System.Drawing.Point(29, 144);
            this.listView_loadGame.MultiSelect = false;
            this.listView_loadGame.Name = "listView_loadGame";
            this.listView_loadGame.Size = new System.Drawing.Size(290, 120);
            this.listView_loadGame.TabIndex = 1;
            this.listView_loadGame.UseCompatibleStateImageBehavior = false;
            this.listView_loadGame.View = System.Windows.Forms.View.Details;
            this.listView_loadGame.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_loadGame_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Difficulty
            // 
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.Width = 99;
            // 
            // Solved
            // 
            this.Solved.Text = "Solved part";
            this.Solved.Width = 126;
            // 
            // button_back
            // 
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(226, 295);
            this.button_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(92, 33);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            this.button_back.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_back.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_startGame
            // 
            this.button_startGame.Enabled = false;
            this.button_startGame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startGame.ForeColor = System.Drawing.Color.Aqua;
            this.button_startGame.Location = new System.Drawing.Point(29, 295);
            this.button_startGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(92, 33);
            this.button_startGame.TabIndex = 7;
            this.button_startGame.Text = "Start!";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            this.button_startGame.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_startGame.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(126, 295);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 33);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            this.button_delete.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_delete.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // MainScreen_LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(346, 368);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_startGame);
            this.Controls.Add(this.listView_loadGame);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen_LoadGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_LoadGame_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_loadGame;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Difficulty;
        private System.Windows.Forms.ColumnHeader Solved;
        private System.Windows.Forms.Button button_delete;
    }
}