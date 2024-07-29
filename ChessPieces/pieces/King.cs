
namespace ChessPieces.pieces
{
    public class King : Piece
    {
        public King(char[,] keypad) : base(keypad)
        {
        }

        protected override Dictionary<char, List<char>> GetMoves(char[,] keypad)
        {
            var moves = new Dictionary<char, List<char>>();
            int[,] kingMoves = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 }, { 1, 1 }, { 1, -1 }, { -1, 1 }, { -1, -1 } };
            int kingMovesCount = kingMoves.GetLength(0);

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

                    for(int move = 0; move < kingMovesCount; move++)
                    {
                        int newR = r + kingMoves[move, 0];
                        int newC = c + kingMoves[move, 1];

                        if (newR >= 0 && newR < rows && newC >= 0 && newC < cols)
                        {
                            if (keypad[newR, newC] != '#' && keypad[newR, newC] != '*')
                            { 
                                moves[key].Add(keypad[newR, newC]);
                            }
                        }
                    }
                }
            }

            return moves;
        }
    }
}
