using DPAT;
using NUnit.Framework;

namespace DPAT.Test
{
    [TestFixture]
    public class SquareSudokuBuilderTests
    {
        [Test]
        public void BuildSudoku_ShouldCreateSudokuWithCorrectBoxes()
        {
            // Arrange
            int[,] initialPuzzle = new int[9, 9]
            {
                // Initialize your puzzle here
            };

            var builder = new SquareSudokuBuilder(initialPuzzle);

            // Act
            builder.BuildSudoku();

            // Assert
            var sudoku = builder.GetSudoku();

            // Add your assertions here to check if the Sudoku is built correctly
            // For example:
            Assert.NotNull(sudoku);
            Assert.AreEqual(9, sudoku.Boxes.Length);
            // More assertions...
        }

        // Add more test methods for other builder functionality...
    }
}
