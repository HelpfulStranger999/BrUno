using BrUno.Core.Entities.Decks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BrUno.Core.Entities.Games
{
    public class Game : IGame
    {
        public GameID ID { get; }

        public PlayerID CurrentPlayer { get; private set; }

        public List<PlayerID> Players { get; } = new List<PlayerID>();
        ImmutableArray<PlayerID> IGame.Players => Players.ToImmutableArray();

        public ConcurrentQueue<PlayerID> TurnOrder { get; } = new ConcurrentQueue<PlayerID>();
        IReadOnlyList<PlayerID> IGame.TurnOrder => TurnOrder.ToImmutableArray();

        private IDeckFactory DeckFactory { get; }
        public IDrawableDeck DrawPile { get; private set; }
        public IPlayableDeck DiscardPile { get; private set; }

        public Game(IDeckFactory factory, GameID id)
        {
            ID = id;
            DeckFactory = factory;
            DrawPile = factory.CreateDefaultDrawableDeck();
            DiscardPile = factory.CreateDefaultPlayableDeck();
        }

        public void ShuffleDrawPile()
        {
            DrawPile = DeckFactory.CreateDrawableDeck(DiscardPile.Cards);
            DiscardPile = DeckFactory.CreateDefaultPlayableDeck();
        }
    }
}