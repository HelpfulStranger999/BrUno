using BrUno.Core.Entities;
using BrUno.Core.Entities.Games;

namespace BrUno.Core.Services
{
    public interface IGameService
    {
        //public bool TryCreateGame(out IGame game);
        public IGame CreateGame();

        //public bool TryGetGame(GameID gameID, out IGame game);
        public IGame GetGame(GameID gameID);

        //public bool TryEndGame(GameID gameID, out IGame game);
        public IGame EndGame(GameID gameID);

        //public bool TryAdvanceGame(GameID game, out IPlayer player);
        public IPlayer AdvanceGame(GameID game);
    }
}