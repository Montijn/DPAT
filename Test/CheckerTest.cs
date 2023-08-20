using DPAT.Builder;


namespace DPAT.Test
{
    [TestFixture]
    public class CheckerTests
    {
        [Test]
        public void IsSolvedCorrectly_ShouldReturnTrueForValidSudoku()
        {
            // Arrange
            int[,] validSudoku = new int[9, 9]
            {
                { 8, 3, 5, 4, 1, 6, 9, 2, 7 },
                { 2, 9, 6, 8, 5, 7, 4, 3, 1 },
                { 4, 1, 7, 2, 9, 3, 6, 5, 8 },
                { 5, 6, 9, 1, 3, 4, 7, 8, 2 },
                { 1, 2, 3, 6, 7, 8, 5, 4, 9 },
                { 7, 4, 8, 5, 2, 9, 1, 6, 3 },
                { 6, 5, 2, 7, 8, 1, 3, 9, 4 },
                { 9, 8, 1, 3, 4, 5, 2, 7, 6 },
                { 3, 7, 4, 9, 6, 2, 8, 1, 5 }
            };

            var builder = new SquareSudokuBuilder(validSudoku);
            var director = new SudokuDirector();
            director.Construct(builder); // Use the director to build the Sudoku

            var sudoku = builder.GetSudoku();
            var checker = new Checker(sudoku);

            // Act
            bool result = checker.IsSolvedCorrectly();

            // Assert
            Assert.True(result);
        }

        [Test]
        public void IsSolvedCorrectly_ShouldReturnFalseForInvalidSudoku()
        {
            // Arrange
            int[,] invalidSudoku = new int[9, 9]
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

            var builder = new SquareSudokuBuilder(invalidSudoku);
            var director = new SudokuDirector();
            director.Construct(builder);

            var sudoku = builder.GetSudoku();
            var checker = new Checker(sudoku);

            // Act
            bool result = checker.IsSolvedCorrectly();

            // Assert
            Assert.False(result);
        }
    }
}





