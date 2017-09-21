namespace TicTacToe2
{
    public class XMarker : IMarker
    {
        public override int GetHashCode()
        {
            return 2;
        }

        public override bool Equals(object obj)
        {
            return obj is XMarker;
        }
    }
}
