// See https://aka.ms/new-console-template for more information
using System;

namespace Milestone1ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(10);
            board.setupLiveNeighbors();
            board.calculateLiveNeighbors();
            printBoard(board);
        }

        static void printBoard(Board board)
        {
            Console.WriteLine("Minesweeper");
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    Cell cell = board.Grid[row, col];
                    if (cell.Live)
                    {
                        Console.Write("X "); // Print 'X' for live cells (bombs)
                    }
                    else
                    {
                        Console.Write(cell.LiveNeighbors + " "); // Print the number of live neighbors
                    }
                }
                Console.WriteLine();
            }
        }
    }
}