using ChessPieces.board;
using ChessPieces.pieces;
using Xunit;

namespace Chess.Tests
{
    public class ChessPiecesTests
    {
        PieceMoves MovesClass; 
        public ChessPiecesTests()
        {
            MovesClass = new(); 
        }

        [Fact]
        public void Knight_Should_ReturnHalfStep()
        {
            // Arrange 
            Piece knight = new Knight(Board.keypad);
            var expectedMoves = MovesClass.GetKnightMoves();

            // Act 
            var knightMove = knight.Moves;

            // Assert
            foreach (var move in knightMove)
            {
                foreach (var val in move.Value)
                {
                    Assert.Contains(val, expectedMoves[move.Key]);
                }
            }
        }

        [Fact]
        public void Bishop_Should_ReturnDiagonalStep()
        {
           // Arrange 
            Piece bishop = new Bishop(Board.keypad);
            var expectedMoves = MovesClass.GetBishopMoves();

            // Act 
            var bishopMove = bishop.Moves;

            // Assert
            foreach (var move in bishopMove)
            {
                foreach (var val in move.Value)
                {
                    Assert.Contains(val, expectedMoves[move.Key]);
                }
            }
        }

        [Fact]
        public void Queen_Should_ReturnAllSteps()
        {
            // Arrange 
            Piece queen = new Queen(Board.keypad);
            var expectedMoves = MovesClass.GetQueenMoves();

            // Act 
            var queenMove = queen.Moves;

            // Assert
            foreach (var move in queenMove)
            {
                foreach (var val in move.Value)
                {
                    Assert.Contains(val, expectedMoves[move.Key]);
                }
            }
        }

        [Fact]
        public void King_Should_ReturnAllSteps_ByOne()
        {
            // Arrange 
            Piece king = new King(Board.keypad);
            var expectedMoves = MovesClass.GetKingMoves();

            // Act 
            var kingMove = king.Moves;

            // Assert
            foreach (var move in kingMove)
            {
                foreach (var val in move.Value)
                {
                    Assert.Contains(val, expectedMoves[move.Key]);
                }
            }
        }

        [Fact]
        public void Rook_Should_ReturnStraightSteps()
        {
            // Arrange 
            Piece rook = new Rook(Board.keypad);
            var expectedMoves = MovesClass.GetRookMoves();

            // Act 
            var rookMove = rook.Moves;

            // Assert
            foreach (var move in rookMove)
            {
                foreach (var val in move.Value)
                {
                    Assert.Contains(val, expectedMoves[move.Key]);
                }
            }
        }

    }

}
