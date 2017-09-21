namespace TicTacToe2
{
    public class OMarker : IMarker
    {
        public override int GetHashCode()
        {
            return 1;
        }

        public override bool Equals(object obj)
        {
            return obj is OMarker;
        }
    }
}
