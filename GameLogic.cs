using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApplication
{
    public class GameLogic
    {

        public Button[,] grid { get; set; }
        public int[,] cellValues { get; set; }
        public int[,] originalShownGridValues { get; set; }

        public GameLogic(Button [,] cells)
        {
            grid = cells;
            cellValues = new int[9, 9];
            originalShownGridValues = new int[9, 9];
        }

        //Cells[,] grid = new Cells[9, 9];

        
        //public int hintsCount = 25;

        public void showRandomValuesHints(int hintsCount)
        {
            List<int> possibleCells = new List<int>();
            for(int i = 0; i < 81; i++)
            {
                possibleCells.Add(i);
            }

            int counter = 0;
            bool continueShowingCells = true;
            do
            {
                int randomCell = random.Next(0, possibleCells.Count);

                int X = possibleCells[randomCell] / 9;
                int Y = possibleCells[randomCell] - (X * 9);
                grid[X, Y].Text = cellValues[X, Y].ToString();
                grid[X, Y].Enabled = false;

                originalShownGridValues[X, Y] = cellValues[X, Y];

                possibleCells.RemoveAt(randomCell);
                counter++;

                if (counter == hintsCount) { continueShowingCells = false; }
            }
            while (continueShowingCells);

            //for (int i = 0; i < hintsCount; i++)
            //{
            //    var randX = random.Next(9);
            //    var randY = random.Next(9);

            //    grid[randX, randY].Text = cellValues[randX, randY].ToString();
            //    grid[randX, randY].Enabled = false;

            //}
        }

        public void loadValues()
        {
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    cellValues[i, j] = 0;
                    grid[i, j].Text = String.Empty;
                    grid[i, j].Enabled = true;
                }
            }
            //foreach (var cell in grid)
            //{
            //    cell.Value = 0;
            //    cell.Clear();
            //}

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
                    cellValues[i, j] = 0;
                    return false;
                }

                value = numsLeft[random.Next(0, numsLeft.Count)];
                cellValues[i, j] = value;

                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && cellValues[x, i] == value)
                    return false;

                if (i != x && cellValues[i, y] == value)
                    return false;
            }

            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cellValues[i, j] == value)
                        return false;
                }
            }

            return true;
        }

        public bool isGameSolvedCorrectly(Button[,] cells)
        {
            int falseValuesCounter = 0;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (cells[row, col].Text == cellValues[row, col].ToString())
                    {
                        if(cells[row, col].Text == originalShownGridValues[row, col].ToString())
                        {
                            cells[row, col].ForeColor = Color.Black;
                        }
                        else cells[row, col].ForeColor = Color.Green;
                        
                    }
                    else
                    {
                        cells[row, col].ForeColor = Color.Red;
                        falseValuesCounter++;
                        
                    }

                }
            }

            if (falseValuesCounter == 0) { return true; }
            else { return false; }

            
        }

        public void LoadValuesFromSavedGame(Gameboard savedGame)
        {
            cellValues = savedGame.OriginalGridValues;
            originalShownGridValues = savedGame.OriginalShownGridNumbers;

            for (int row = 0; row < 9; row++)
            {
                for(int col = 0; col < 9; col++)
                {
                    if(savedGame.OriginalShownGridNumbers[row, col] != 0)
                    {
                        grid[row, col].Text = savedGame.OriginalShownGridNumbers[row, col].ToString();
                        grid[row, col].Enabled = false;
                    }
                    if(savedGame.EnteredGridNumbers[row, col] != 0)
                    {
                        grid[row, col].ForeColor = Color.DeepSkyBlue;
                        grid[row, col].Text = savedGame.EnteredGridNumbers[row, col].ToString();
                    }
                    
                }
            }
        }
    }
}
