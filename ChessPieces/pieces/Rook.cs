namespace ChessPieces.pieces
{
    public class Rook : Piece
    {
        public Rook(char[,] keypad) : base(keypad)
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

                    for (int i = 0; i < rows; i++)
                    {
                        if (keypad[i, c] != '#' && keypad[i, c] != '*')
                        {
                            if (i != r) moves[key].Add(keypad[i, c]);
                        }
                    }

                    for (int j = 0; j < cols; j++)
                    {
                        if (keypad[r, j] != '#' && keypad[r, j] != '*')
                        {
                            if (j != c) moves[key].Add(keypad[r, j]);
                        }
                    }
                }
            }

            return moves;
        }

    }
}
