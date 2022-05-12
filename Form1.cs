using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createCells();
        }

        System.Windows.Forms.Button[,] cells = new SudokuCells[9, 9];
        private object panel1;

        public object HardButton { get; private set; }

        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCells();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(60, 60);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 60, j * 60);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    //cells[i, j].X = i;
                    //cells[i, j].Y = j;
                    cells[i, j].KeyPress += cell_keyPressed;
                    panelBoard.Controls.Add(cells[i, j]);
                }

            }

        }
        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCells;

            int value;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EasyButton.Checked == true)
            {
                EasyButton.PerformClick();
            }
            if (MediumButton.Checked == true)
            {
                MediumButton.PerformClick();
            }
            if (ButtonHard.Checked != true)
            {
                ButtonHard.PerformClick();

            }
        }
    }
}
