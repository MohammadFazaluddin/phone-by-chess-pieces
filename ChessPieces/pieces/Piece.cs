using System.Reflection.Metadata.Ecma335;

namespace ChessPieces.pieces
{
    public abstract class Piece
    {
        public Dictionary<char, List<char>> Moves { get; protected set; }

        protected Piece(char[,] keypad)
        {
            Moves = GetMoves(keypad);    
        }

        protected abstract Dictionary<char, List<char>> GetMoves(char[,] keypad);
    }
}
