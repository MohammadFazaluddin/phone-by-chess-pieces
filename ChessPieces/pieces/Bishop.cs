
namespace ChessPieces.pieces
{
    public class Bishop : Piece
    {
        public Bishop(char[,] keypad) : base(keypad)
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

                    for (int i = 1; i < Math.Max(rows, cols); i++)
                    {

                        if (r + i < rows && c + i < cols) 
                        {
                            if (keypad[r + i, c + i] != '#' && keypad[r + i, c + i] != '*')
                            {
                               moves[key].Add(keypad[r + i, c + i]);
                            }
                        }
                        if (r - i >= 0 && c + i < cols)
                        {
                            if (keypad[r - i, c + i] != '#' && keypad[r - i, c + i] != '*')
                            {
                                moves[key].Add(keypad[r - i, c + i]);
                            }
                        }
                        if (r + i < rows && c - i >= 0)
                        {
                            if (keypad[r + i, c - i] != '#' && keypad[r + i, c - i] != '*')
                            {
                                moves[key].Add(keypad[r + i, c - i]);
                            }
                        }
                        if (r - i >= 0 && c - i >= 0)
                        {
                            if (keypad[r - i, c - i] != '#' && keypad[r - i, c - i] != '*')
                            {
                                moves[key].Add(keypad[r - i, c - i]);
                            }
                        }
                    }
                }
            }

            return moves;
        }
    }
}
