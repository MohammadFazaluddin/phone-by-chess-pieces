using ChessPieces;
using Xunit;

namespace Chess.Tests
{
    public class ChessPiecesTests
    {
        [Theory]
        [InlineData(6, 9, MoveDirection.UpLeft, 5, 7)]
        [InlineData(0, 2, MoveDirection.DownRight, 1, 4)]
        [InlineData(8, 5, MoveDirection.UpRight, 9, 3)]
        [InlineData(0, 1, MoveDirection.DownLeft, -1, 3)]
        [InlineData(0, 1, MoveDirection.Up, -1, -1)]
        public void Knight_Should_ReturnHalfStep(int posX, int posY, MoveDirection direction,
                int expectedX, int expectedY)
        {
            // Arrange 
            Piece knight = new Knight();

            // Act 
            (int y, int x) = knight.MovePiece(posY, posX, direction);

            // Assert
            Assert.True(x == expectedX && y == expectedY);
        }

        [Theory]
        [InlineData(0, 1, 3, MoveDirection.DownRight, 3, 4)]
        [InlineData(3, 6, 5, MoveDirection.UpRight, 8, 1)]
        [InlineData(8, 6, 5, MoveDirection.Down, -1, -1)]
        public void Bishop_Should_ReturnDiagonalStep(int posX, int posY, int steps, MoveDirection direction,
                int expectedX, int expectedY)
        {
            // Arrange 
            Piece bishop = new Bishop();

            // Act 
            (int y, int x) = bishop.MovePiece(posY, posX, direction, steps);

            // Assert
            Assert.True(x == expectedX && y == expectedY);
        }

        [Theory]
        [InlineData(0, 1, 3, MoveDirection.DownRight, 3, 4)]
        [InlineData(3, 6, 5, MoveDirection.UpRight, 8, 1)]
        [InlineData(8, 6, 3, MoveDirection.Down, 8, 9)]
        [InlineData(1, 3, 2, MoveDirection.Right, 3, 3)]
        public void Queen_Should_ReturnAllSteps(int posX, int posY, int steps, MoveDirection direction,
                int expectedX, int expectedY)
        {
            // Arrange 
            Piece queen = new Queen();

            // Act 
            (int y, int x) = queen.MovePiece(posY, posX, direction, steps);

            // Assert
            Assert.True(x == expectedX && y == expectedY);
        }

        [Theory]
        [InlineData(3, 5, 1, MoveDirection.Up, 3, 4)]
        [InlineData(7, 2, 1, MoveDirection.DownLeft, 6, 3)]
        [InlineData(1, 3, 4, MoveDirection.Right, 2, 3)]
        public void King_Should_ReturnAllSteps_ByOne(int posX, int posY, int steps, MoveDirection direction,
                int expectedX, int expectedY)
        {
            // Arrange 
            Piece king = new King();

            // Act 
            (int y, int x) = king.MovePiece(posY, posX, direction, steps);

            // Assert
            Assert.True(x == expectedX && y == expectedY);
        }

        [Theory]
        [InlineData(3, 5, 4, MoveDirection.Up, 3, 1)]
        [InlineData(7, 2, 1, MoveDirection.DownLeft, -1, -1)]
        [InlineData(1, 3, 8, MoveDirection.Right, 9, 3)]
        public void Rook_Should_ReturnStraightSteps(int posX, int posY, int steps, MoveDirection direction,
                int expectedX, int expectedY)
        {
            // Arrange 
            Piece rook = new Rook();

            // Act 
            (int y, int x) = rook.MovePiece(posY, posX, direction, steps);

            // Assert
            Assert.True(x == expectedX && y == expectedY);
        }

        [Theory]
        [InlineData(3, 2, 1, MoveDirection.Up, 3, 1)]
        [InlineData(7, 2, 1, MoveDirection.DownLeft, -1, -1)]
        [InlineData(1, 3, 8, MoveDirection.Right, -1, -1)]
        public void Pawn_Should_ReturnOneStepOnly(int posX, int posY, int steps, MoveDirection direction,
                int expectedX, int expectedY)
        {
            // Arrange 
            Piece pawn = new Pawn();

            // Act 
            (int y, int x) = pawn.MovePiece(posY, posX, direction, steps);

            // Assert
            Assert.True(x == expectedX && y == expectedY);
        }

    }
    

}
