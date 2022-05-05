using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    internal class BoardGenerator
    {
        public int [,] GameBoard { get; set; }

        public BoardGenerator()
        {
             int [,] sudokuBoard = {
                { 8, 2, 7, 1, 5, 4, 3, 9, 6 },
                { 9, 6, 5, 3, 2, 7, 1, 4, 8 },
                { 3, 4, 1, 6, 8, 9, 7, 5, 2 },
                { 5, 9, 3, 4, 6, 8, 2, 7, 1 },
                { 4, 7, 2, 5, 1, 3, 6, 8, 9 },
                { 6, 1, 8, 9, 7, 2, 4, 3, 5 },
                { 7, 8, 6, 2, 3, 5, 9, 1, 4 },
                { 1, 5, 4, 7, 9, 6, 8, 2, 3 },
                { 2, 3, 9, 8, 4, 1, 5, 6, 7 } };

            GameBoard = sudokuBoard;

                       
        }

        private int[,] GeneratePrimaryBoard()
        {
            int[,] sudokuBoard = new int[9, 9];

            List<int> rowNumbers1to9 = new List<int>();
            Random randomNumber = new Random();
            bool correctBoard = true;

            List<List<int>> listOfColumnLists = new List<List<int>>();
            List<List<int>> listOfSmallBlockLists = new List<List<int>>();


            for (int listNumber = 0; listNumber < 9; listNumber++)
            {
                List<int> columnNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                List<int> smallBlockNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                listOfColumnLists.Add(columnNumbers);
                listOfSmallBlockLists.Add(smallBlockNumbers);
            }

            for (int row = 0; row < 9; row++)
            {
                for (int i = 1; i < 10; i++)
                {
                    rowNumbers1to9.Add(i);

                }

                for (int column = 0; column < 9; column++)
                {
                    List<int> currentColumn = listOfColumnLists[column];
                    List<int> currentSmallBlock = listOfSmallBlockLists[row / 3 * 3 + (column / 3)];

                    int randomPosition;

                    List<int> possibleNumberChoice = new List<int>();

                    foreach (int number in rowNumbers1to9)
                    {
                        if (currentColumn.Contains(number) && currentSmallBlock.Contains(number))
                        {
                            possibleNumberChoice.Add(number);
                        }
                    }

                    if (possibleNumberChoice.Count == 0)
                    {
                        correctBoard = false;
                        break;
                    }

                    randomPosition = randomNumber.Next(possibleNumberChoice.Count);

                    sudokuBoard[row, column] = possibleNumberChoice[randomPosition];
                    currentColumn.Remove(possibleNumberChoice[randomPosition]);
                    rowNumbers1to9.Remove(possibleNumberChoice[randomPosition]);
                    currentSmallBlock.Remove(possibleNumberChoice[randomPosition]);

                }
                if (!correctBoard) { break; }
            }

            return sudokuBoard;
        }

        private bool CheckRowsAndColumns(int [,] gameBoard)
        {
            bool correctBoard = true;
            for (int row=0; row<9; row++)
            {
                List<int> rowNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                List<int> columnNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                for (int column = 0; column < 9; column++)
                {
                    if(rowNumbers.Contains(gameBoard[row, column]))
                    {
                        rowNumbers.Remove(gameBoard[row, column]);
                    }
                    else
                    {
                        correctBoard = false;
                        break;
                    }

                    if(columnNumbers.Contains(gameBoard[column, row]))
                    {
                        columnNumbers.Remove(gameBoard[column, row]);
                    }
                    else
                    {
                        correctBoard = false;
                        break;
                    }
                     
                }

            }
                      
            return correctBoard;
        }

        public int[,] GenerateNewBoard(int gameLevel)
        {
            int[,] board = new int[9, 9];

            do
            {
                board = GeneratePrimaryBoard();
            }
            while(!CheckRowsAndColumns(board));

            Random random = new Random();
            int randomNumber = 0;
            switch (gameLevel)
            {
                case 1:
                    randomNumber = random.Next(15, 25);                                        
                    break;
                case 2:
                    randomNumber = random.Next(35, 45);
                    break;
                case 3:
                    randomNumber = random.Next(55, 65);
                    break;
                default:
                    break;
            }

            for (int i = 0; i < randomNumber; i++)
            {
                int randomRow = random.Next(9);
                int randomColumn = random.Next(9);

                board[randomRow, randomColumn] = 0;
            }

            return board;
        }

       
    }
}
