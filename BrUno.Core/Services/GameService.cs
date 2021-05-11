using BrUno.Core.Entities;
using BrUno.Core.Entities.Games;
using System;
using System.Collections.Concurrent;

namespace BrUno.Core.Services
{
    public class GameService : IGameService
    {
        private ConcurrentDictionary<GameID, IGame> Games { get; } = new();
        private IGameFactory GameFactory { get; }

        public IPlayer AdvanceGame(GameID game)
        {
            throw new NotImplementedException();
        }

        public IGame CreateGame()
        {
            var game = GameFactory.CreateNewGame();
            Games.TryAdd(game.ID, game);
            return game;
        }

        public IGame EndGame(GameID gameID)
        {
            if (Games.TryRemove(gameID, out var game))
            {
                return game;
            }

            throw new InvalidOperationException("Game not found");
        }

        public IGame GetGame(GameID gameID)
        {
            if (Games.TryGetValue(gameID, out var game))
            {
                return game;
            }

            throw new InvalidOperationException("Game not found");
        }
    }
}