namespace ChessPieces.pieces
{
    public class Queen : Piece
    {
        protected override MoveDirection[] Moves { get; } = [   MoveDirection.Up, MoveDirection.Down,
                                                                MoveDirection.UpRight, MoveDirection.UpLeft,
                                                                MoveDirection.Left, MoveDirection.Right,
                                                                MoveDirection.DownRight, MoveDirection.DownLeft];

        public override float Step { get; } = -1;

    }
}
