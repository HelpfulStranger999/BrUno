using BrUno.Core.Entities.Cards;
using System.Collections.Generic;

namespace BrUno.Core.Entities.Decks
{
    public interface IDrawableDeck : IDeck
    {
        public Card Draw();
        public void DealHands(List<IHand> hands, int handSize);
    }
}