using BrUno.Core.Entities;
using BrUno.Core.Entities.Games;
using Microsoft.Extensions.Logging;

namespace BrUno.Core.Services
{
    public class DeckService
    {
        private ILogger<DeckService> Log { get; init; }

        private IGameService GameService { get; }

        public DeckService(ILogger<DeckService> logger, IGameService gameService)
        {
            Log = logger;
            GameService = gameService;
        }

        public void DrawCard(GameID gameID, IHand hand)
        {
            var game = GameService.GetGame(gameID);
            if (game.DrawPile.Cards.IsEmpty)
            {
                game.ShuffleDrawPile();
            }

            hand.Draw(game.DrawPile.Draw());
        }
    }
}