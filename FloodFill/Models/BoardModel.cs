using System;

namespace FloodFill.Models
{
    internal class BoardModel
    {
        public int Size { get; }
        public CellModel[,] Grid { get; }
        public int NumShapes { get; }

        public BoardModel(int size, int numShapes)
        {
            Size = size; NumShapes = numShapes;
            Grid = new CellModel[size, size];
            for (int r = 0; r < size; r++)
                for (int c = 0; c < size; c++)
                    Grid[r, c] = new CellModel(r, c);
            PlaceShapes();
        }

        private void PlaceShapes()
        {
            var rnd = new Random();
            int sq = Math.Max(3, Size / 4);
            for (int k = 0; k < NumShapes; k++)
            {
                int top = rnd.Next(0, Size - sq + 1);
                int left = rnd.Next(0, Size - sq + 1);
                for (int i = 0; i < sq; i++)
                {
                    Grid[top, left + i].Contents = "W";
                    Grid[top + sq - 1, left + i].Contents = "W";
                    Grid[top + i, left].Contents = "W";
                    Grid[top + i, left + sq - 1].Contents = "W";
                }
            }
        }
    }
}
