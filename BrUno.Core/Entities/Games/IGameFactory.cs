using System.Collections.Generic;

namespace BrUno.Core.Entities.Games
{
    public interface IGameFactory
    {
        public IGame CreateNewGame();
        public IGame CreateNewGame(IEnumerable<PlayerID> players);
        public IGame CreateNewGame(params PlayerID[] players);
    }
}