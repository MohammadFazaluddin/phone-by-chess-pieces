namespace ChessPieces.pieces
{
    public class Pawn : Piece
    {
        protected override MoveDirection[] Moves { get; } = [MoveDirection.Up];

        public override float Step { get; } = 1;
    }
}
