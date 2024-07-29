
namespace ChessPieces.pieces
{
    public class Queen : Piece
    {
        public Queen(char[,] keypad) : base(keypad)
        {
        }

        protected override Dictionary<char, List<char>> GetMoves(char[,] keypad)
        {
            var rookMoves = new Rook(keypad);
            var bishopMoves = new Bishop(keypad);
            var queenMoves = new Dictionary<char, List<char>>();

            foreach (var key in rookMoves.Moves.Keys)
            {
                queenMoves[key] = rookMoves.Moves[key].Concat(bishopMoves.Moves[key]).ToList();

            }

            return queenMoves;
        }
    }
}
