namespace FloodFill.Models
{
    internal class CellModel
    {
        public int Row { get; }
        public int Column { get; }
        public string Contents { get; set; } = "E";
        public CellModel(int r, int c, string contents = "E")
        { Row = r; Column = c; Contents = contents; }
    }
}
