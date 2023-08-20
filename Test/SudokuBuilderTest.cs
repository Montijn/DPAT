
using DPAT.Builder;
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
                { 0, 3, 5, 4, 1, 6, 9, 2, 7 },
                { 2, 9, 6, 8, 5, 7, 4, 3, 1 },
                { 4, 1, 7, 2, 9, 3, 0, 5, 8 },
                { 5, 6, 9, 0, 3, 4, 7, 8, 2 },
                { 1, 0, 3, 6, 7, 8, 5, 4, 0 },
                { 7, 4, 8, 5, 2, 9, 1, 6, 3 },
                { 6, 5, 2, 0, 8, 1, 3, 9, 4 },
                { 9, 8, 1, 3, 4, 5, 2, 7, 6 },
                { 3, 7, 4, 9, 6, 2, 8, 1, 5 }
            };

            var builder = new SquareSudokuBuilder(initialPuzzle);
            var director = new SudokuDirector(); // Create the director

            // Act
            director.Construct(builder); // Use the director to build the Sudoku

            // Assert
            var sudoku = builder.GetSudoku();
            Assert.NotNull(sudoku);
            Assert.That(sudoku.Boxes.Length, Is.EqualTo(9));
        }

        [Test]
        public void BuildSudoku_ShouldCreateSudokuWithCorrectRows()
        {
            // Arrange
            int[,] initialPuzzle = new int[9, 9]
            {
                { 0, 3, 5, 4, 1, 6, 9, 2, 7 },
                { 2, 9, 6, 8, 5, 7, 4, 3, 1 },
                { 4, 1, 7, 2, 9, 3, 0, 5, 8 },
                { 5, 6, 9, 0, 3, 4, 7, 8, 2 },
                { 1, 0, 3, 6, 7, 8, 5, 4, 0 },
                { 7, 4, 8, 5, 2, 9, 1, 6, 3 },
                { 6, 5, 2, 0, 8, 1, 3, 9, 4 },
                { 9, 8, 1, 3, 4, 5, 2, 7, 6 },
                { 3, 7, 4, 9, 6, 2, 8, 1, 5 }
            };

            var builder = new SquareSudokuBuilder(initialPuzzle);
            var director = new SudokuDirector(); // Create the director

            // Act
            director.Construct(builder); // Use the director to build the Sudoku

            // Assert
            var sudoku = builder.GetSudoku();

            // Verify the constructed rows
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var cellValue = sudoku.Rows[i].Cells[j].Value;
                    var expectedValue = initialPuzzle[i, j];

                    Assert.That(cellValue, Is.EqualTo(expectedValue));
                }
            }
        }
    }
}


