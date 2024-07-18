using ChessPieces.pieces;

namespace ChessPieces.board
{
    public static class Board
    {
        public static char[,] keypad = {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'},
            {'#', '0', '*'},
        };

        public static int MaxLength = 7;

        public static void GetPhoneNumbers(Piece piece, int startRow, int startCol,
                MoveDirection direction, string phoneNo, int steps, List<string> numList)
        {
            // get a number then try to get all directional possible numbers 
            if (phoneNo.Length >= MaxLength)
            {
                if (!numList.Any(e => e == phoneNo))
                {
                    numList.Add(phoneNo);
                }
                return;
            }

            if (phoneNo.StartsWith('0') || phoneNo.StartsWith('1'))
            {
                return;
            }

            if (startCol < 0 || startRow < 0
                || startRow >= keypad.GetLength(0)
                || startCol >= keypad.GetLength(1))
            {
                return;
            }

            if (keypad[startRow, startCol] == '#' || keypad[startRow, startCol] == '*')
            {
                return;
            }

            phoneNo += keypad[startRow, startCol];

            int row = 0, col = 0;
            int directionLen = Enum.GetNames(typeof(MoveDirection)).Length;

            for (int i = 1; i < directionLen; ++i)
            {
                (row, col) = piece.MovePiece(startRow, startCol, (MoveDirection)i, steps);
                GetPhoneNumbers(piece, row, col, (MoveDirection)i, phoneNo, steps, numList);
            }

        }

        public static int GeneratePhoneNumbers(Piece piece)
        {
            int count = 0;

            // for row
            for (int j = 0; j < keypad.GetLength(0); ++j)
            {
                // for columns
                for (int i = 1; i < keypad.GetLength(1); ++i)
                {
                    // for taking multiple steps
                    for (int step = 1; step < keypad.GetLength(0); ++step)
                    {
                        List<string> numberList = new();
                        GetPhoneNumbers(piece, j, i, MoveDirection._, "", step, numberList);
                        count += numberList.Count;
                    }
                }
                Console.WriteLine(count);
            }

            return count;
        }

    }
}
