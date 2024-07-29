namespace ChessPieces.pieces
{
    public class Knight : Piece
    {
        public Knight(char[,] keypad) : base(keypad)
        {
        }

        protected override Dictionary<char, List<char>> GetMoves(char[,] keypad)
        {
            var moves = new Dictionary<char, List<char>>();

            // using array instead of if else for readability
            int[,] knightMoves = { { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 }, { -2, -1 }, { -1, -2 }, { 1, -2 }, { 2, -1 } };
            int knightMovesCount = knightMoves.GetLength(0);
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

                    for (int move = 0; move < knightMovesCount; move++)
                    {
                        int newR = r + knightMoves[move, 0];
                        int newC = c + knightMoves[move, 1];

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
