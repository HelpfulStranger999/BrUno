using BrUno.Core.Entities.Decks;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BrUno.Core.Entities.Games
{
    public record GameID(Guid ID)
    {
        public static GameID Create()
        {
            return new GameID(Guid.NewGuid());
        }
    }

    public interface IGame
    {
        public GameID ID { get; }

        public PlayerID CurrentPlayer { get; }
        public ImmutableArray<PlayerID> Players { get; }
        public IReadOnlyList<PlayerID> TurnOrder { get; }

        public IDrawableDeck DrawPile { get; }
        public IPlayableDeck DiscardPile { get; }

        public void ShuffleDrawPile();
    }
}