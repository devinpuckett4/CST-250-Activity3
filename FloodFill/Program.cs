using System;
using System.Threading;
using FloodFill.Models;

namespace FloodFill
{
    internal static class Utility
    {
        internal static void PrintBoard(BoardModel b)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            for (int c = 0; c < b.Size; c++) Console.Write($"{c,2} ");
            Console.WriteLine();
            for (int r = 0; r < b.Size; r++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"{r,2} ");
                for (int c = 0; c < b.Size; c++)
                {
                    var s = b.Grid[r, c].Contents;
                    if (s == "W") { Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" W "); }
                    else if (s == "F") { Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" F "); }
                    else { Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" . "); }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        internal static void Flood(BoardModel b, int r, int c, int delayMs = 30)
        {
            if (r < 0 || c < 0 || r >= b.Size || c >= b.Size) return;
            var cell = b.Grid[r, c];
            if (cell.Contents == "W" || cell.Contents == "F") return;

            cell.Contents = "F";
            Console.Clear();
            PrintBoard(b);
            Thread.Sleep(delayMs);

            Flood(b, r - 1, c, delayMs);
            Flood(b, r, c + 1, delayMs);
            Flood(b, r + 1, c, delayMs);
            Flood(b, r, c - 1, delayMs);
        }
    }

    internal class Program
    {
        static void Main()
        {
            var board = new BoardModel(size: 20, numShapes: 3);
            Utility.PrintBoard(board);
            Console.Write("Start row: "); int r = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Start col: "); int c = int.Parse(Console.ReadLine() ?? "0");
            Utility.Flood(board, r, c, 50);
            Console.WriteLine("Done.");
        }
    }
}
