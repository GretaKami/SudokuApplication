using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SudokuApplication
{
    internal static class Program
    {
       static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Cells[,] grid = new Cells[9, 9];

            var hintsCount = 25;

            void showRandomValuesHints(int hintsCount)
            {

                for (int i = 0; i < hintsCount; i++)
                {
                    var randX = random.Next(9);
                    var randY = random.Next(9);

                    grid[randX, randY].Text = grid[randX, randY].Value.ToString();
                    grid[randX, randY].IsLocked = true;

                }
            }

            private void loadValues()
            {

                foreach (var cell in grid)
                {
                    cell.Value = 0;
                    cell.Clear();
                }

                findValueForNextCell(0, -1);
            }

            Random random = new Random();

            private bool findValueForNextCell(int i, int j)
            {

                if (++j > 8)
                {
                    j = 0;

                    if (++i > 8)
                        return true;
                }

                var value = 0;
                var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                do
                {

                    if (numsLeft.Count < 1)
                    {
                        grid[i, j].Value = 0;
                        return false;
                    }

                    value = numsLeft[random.Next(0, numsLeft.Count)];
                    grid[i, j].Value = value;

                    numsLeft.Remove(value);
                }
                while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

                return true;
            }

            private bool isValidNumber(int value, int x, int y)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (i != y && grid[x, i].Value == value)
                        return false;

                    if (i != x && grid[i, y].Value == value)
                        return false;
                }

                for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
                {
                    for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                    {
                        if (i != x && j != y && grid[i, j].Value == value)
                            return false;
                    }
                }

                return true;
            }
        }
    }
}
