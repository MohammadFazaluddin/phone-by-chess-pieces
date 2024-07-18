namespace ChessPieces.pieces
{
    public class Knight : Piece
    {
        protected override MoveDirection[] Moves { get; } = [ MoveDirection.UpRight, MoveDirection.UpLeft,
                                                                MoveDirection.DownRight, MoveDirection.DownLeft];

        public override float Step { get; } = 2.5F;

    }
}
