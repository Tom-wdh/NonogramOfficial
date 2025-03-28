using System;
using System.Threading.Tasks;

namespace NonogramOfficial.Initializers
{
    public static class PuzzleInitializer
    {
        public static void InitializePuzzle(out int[,] puzzle, out int[,] solution, int gridSize)
        {
            puzzle = new int[gridSize, gridSize];
            solution = new int[gridSize, gridSize];
            var threadLocalRandom = new System.Threading.ThreadLocal<Random>(() => new Random(Guid.NewGuid().GetHashCode()));

            int[,] localSolution = new int[gridSize, gridSize];

            for (int row = 0; row < gridSize; row++)
            {
                var random = threadLocalRandom.Value;
                for (int col = 0; col < gridSize; col++)
                {
                    localSolution[row, col] = random.Next(2);
                }
            }

            // Initialize the puzzle with zeros (blank cells)
            Array.Clear(puzzle, 0, puzzle.Length);
            Array.Copy(localSolution, solution, localSolution.Length);
        }
    }
}
