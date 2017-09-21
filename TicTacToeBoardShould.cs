using System;
using System.Configuration;
using NUnit.Framework;
using TicTacToe2;

namespace TicTacToe2Tests
{
    [TestFixture]
    public class TicTacToeBoardShould
    {
        [Test]
        public void ShowUnfinishedGameWithOneX()
        {
            var ticTacToeBoard = new TicTacToeBoard();
            ticTacToeBoard.PlaceMarker(new XMarker(), new Position(0,0));

            var state = ticTacToeBoard.CalculateGameState();
            
            Assert.That(state, Is.EqualTo(GameState.Unfinished));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NotAllowOToGoFirst()
        {
            var ticTacToeBoard = new TicTacToeBoard();
            ticTacToeBoard.PlaceMarker(new OMarker(), new Position(0, 0));

            ticTacToeBoard.CalculateGameState();
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EnsurePlayersCannotSkipATurn()
        {
            
            var ticTacToeBoard = new TicTacToeBoard();
            ticTacToeBoard.PlaceMarker(new XMarker(), new Position(0, 0));
            ticTacToeBoard.PlaceMarker(new XMarker(), new Position(0, 1));

            ticTacToeBoard.CalculateGameState();
        }
    }
}
