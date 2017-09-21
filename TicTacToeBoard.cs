using System;
using System.Data;
using TicTacToe2;

namespace TicTacToe2
{
    public class TicTacToeBoard
    {
        //private IMarker[,] boardMarkers = new IMarker[3,3];
        private IMarker previousMarker = new OMarker();

        public void PlaceMarker(IMarker marker, Position position)
        {
            if (marker.Equals(previousMarker))
            {
                throw new InvalidOperationException();
            }

            previousMarker = marker;
        }

        public GameState CalculateGameState()
        {
            return GameState.Unfinished;
        }
    }
}