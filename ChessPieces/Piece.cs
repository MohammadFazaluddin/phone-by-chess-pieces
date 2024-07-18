using System.Reflection.Metadata.Ecma335;

namespace ChessPieces
{
    public enum MoveDirection
    {
        _,
        UpLeft, 
        Up, // 2
        UpRight,
        Right, // 4
        DownRight,
        Down, // 6
        DownLeft,
        Left, // 8
    }
    public class Piece
    {
        protected virtual MoveDirection[] Moves { get; } = [];

        // -1 for till the end of rim, and rest depending on the count. 
        public virtual float Step { get; } = 0;

        public (int, int) MovePiece(int row, int col, MoveDirection dir, float steps = 0)
        {
            if (!Moves.Contains(dir))
            {
                return (-1, -1);
            }

            if (Step >= 0)
            {
                steps = Step;
            }

            if ((int)dir % 2 == 0)
            {
                GetStdMovements(ref row, ref col, dir, (int)steps); 
            } 
            else
            {
                GetDiaMovements(ref row, ref col, dir, steps);
            }

            return (row, col);
        }

        protected int GetStdMovements(ref int row, ref int col, MoveDirection dir, int steps)
        {
            return dir switch
            {
                MoveDirection.Up => row -= steps,
                MoveDirection.Down => row += steps,
                MoveDirection.Right => col += steps,
                MoveDirection.Left => col -= steps,
                MoveDirection._ => throw new InvalidCastException("Invalid Move"),
                MoveDirection.UpLeft => throw new InvalidCastException("Invalid Move"),
                MoveDirection.UpRight => throw new InvalidCastException("Invalid Move"),
                MoveDirection.DownRight => throw new InvalidCastException("Invalid Move"),
                MoveDirection.DownLeft => throw new InvalidCastException("Invalid Move"),
                _ => throw new InvalidCastException("Invalid Move"),
            };

        }

        protected void GetDiaMovements(ref int row, ref int col, MoveDirection dir, float steps)
        {
            // for knight's half step
            bool shiftHalf = false;

            if (Math.Abs(steps % 1) > (Double.Epsilon * 100))
            {
                shiftHalf = true;
            }

            if (dir == MoveDirection.UpRight)
            {
                row -= (int)steps;
                col += shiftHalf ? 1 : (int)steps;
            }
            else if (dir == MoveDirection.UpLeft)
            {
                row -= (int)steps;
                col -= shiftHalf ? 1 : (int)steps;
            }
            else if (dir == MoveDirection.DownRight)
            {
                row += (int)steps;
                col += shiftHalf ? 1 : (int)steps;
            }
            else if (dir == MoveDirection.DownLeft)
            {
                row += (int)steps;
                col -= shiftHalf ? 1 : (int)steps;
            }
            else
            {
                throw new InvalidCastException("Invalid Move");
            }

        }

    }

    public class Rook : Piece
    {
        protected override MoveDirection[] Moves { get; } = [ MoveDirection.Up, MoveDirection.Down,
                                                                MoveDirection.Left, MoveDirection.Right ];
        public override float Step { get; } = -1;

    }

    public class Knight : Piece
    {
        protected override MoveDirection[] Moves { get; } = [ MoveDirection.UpRight, MoveDirection.UpLeft,
                                                                MoveDirection.DownRight, MoveDirection.DownLeft];

        public override float Step { get; } = 2.5F;

    }

    public class Queen : Piece
    {
        protected override MoveDirection[] Moves { get; } = [   MoveDirection.Up, MoveDirection.Down,
                                                                MoveDirection.UpRight, MoveDirection.UpLeft,
                                                                MoveDirection.Left, MoveDirection.Right,
                                                                MoveDirection.DownRight, MoveDirection.DownLeft];

        public override float Step { get; } = -1;

    }

    public class Bishop : Piece
    {
        protected override MoveDirection[] Moves { get; } = [   MoveDirection.UpRight, MoveDirection.UpLeft,
                                                                MoveDirection.DownRight, MoveDirection.DownLeft];

        public override float Step { get; } = -1;
    }
    public class King : Piece
    {
        protected override MoveDirection[] Moves { get; } = [ MoveDirection.Up, MoveDirection.Down,
                                                                MoveDirection.UpRight, MoveDirection.UpLeft,
                                                                MoveDirection.Left, MoveDirection.Right,
                                                                MoveDirection.DownRight, MoveDirection.DownLeft];

        public override float Step { get; } = 1;
    }

    public class Pawn : Piece
    {
        protected override MoveDirection[] Moves { get; } = [ MoveDirection.Up ];

        public override float Step { get; } = 1;
    }
}
