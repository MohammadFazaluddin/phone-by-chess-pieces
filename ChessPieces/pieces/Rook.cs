namespace ChessPieces.pieces
{
    public class Rook : Piece
    {
        protected override MoveDirection[] Moves { get; } = [ MoveDirection.Up, MoveDirection.Down,
                                                                MoveDirection.Left, MoveDirection.Right ];
        public override float Step { get; } = -1;

    }
}
