using System;
using System.Threading.Tasks;

namespace NonogramPuzzle.Initializers
{
    public static class PuzzleInitializer
    {
        public static void InitializePuzzle(out int[,] puzzle, out int[,] solution, int gridSize)
        {
            puzzle = new int[gridSize, gridSize];
            solution = new int[gridSize, gridSize];
            var threadLocalRandom = new System.Threading.ThreadLocal<Random>(() => new Random(Guid.NewGuid().GetHashCode()));

            int[,] localPuzzle = new int[gridSize, gridSize];
            int[,] localSolution = new int[gridSize, gridSize];

            Parallel.For(0, gridSize, row =>
            {
                var random = threadLocalRandom.Value;
                for (int col = 0; col < gridSize; col++)
                {
                    localPuzzle[row, col] = random.Next(2);
                    localSolution[row, col] = localPuzzle[row, col];
                }
            });

            Array.Copy(localPuzzle, puzzle, localPuzzle.Length);
            Array.Copy(localSolution, solution, localSolution.Length);
        }
    }
}
