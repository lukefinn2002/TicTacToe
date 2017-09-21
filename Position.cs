namespace TicTacToe2
{
    public class Position
    {
        public Position(int rowIndex, int columnIndex)
        {
            this.RowIndex = rowIndex;
            this.ColumnIndex = columnIndex;
        }

        public int RowIndex { get; private set; }

        public int ColumnIndex { get; private set; }
    }
}