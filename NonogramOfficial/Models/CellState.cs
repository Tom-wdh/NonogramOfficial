namespace NonogramPuzzle.Models
{
    public class CellState
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public bool IsFilled { get; set; }
        public bool IsMarked { get; set; }
    }
}
