using System.Collections.Generic;

namespace NonogramOfficial.Models
{
    public class SaveData
    {
        public int[,] Puzzle { get; set; }
        public int[,] Solution { get; set; }
        public string Timer { get; set; }
        public List<CellState> CurrentState { get; set; }
    }
}
