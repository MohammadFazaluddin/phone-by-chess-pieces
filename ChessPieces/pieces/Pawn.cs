
namespace ChessPieces.pieces
{
    public class Pawn : Piece
    {
        public Pawn(char[,] keypad) : base(keypad)
        {
        }

        protected override Dictionary<char, List<char>> GetMoves(char[,] keypad)
        {
            var moves = new Dictionary<char, List<char>>();
            int rows = keypad.GetLength(0);
            int cols = keypad.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    char key = keypad[r, c];
                    moves[key] = new List<char>();

                    if (key == '*' || key == '#')
                    {
                        continue;
                    }

                    if (r + 1 < rows)
                    {
                        if (keypad[r + 1, c] != '#' && keypad[r + 1, c] != '*')
                        {
                            moves[key].Add(keypad[r + 1, c]);
                        }
                    }
                }
            }

            return moves;
        }
    }
}
