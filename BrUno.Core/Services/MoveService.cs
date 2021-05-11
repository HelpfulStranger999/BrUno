using BrUno.Core.Entities.Cards;
using BrUno.Core.Entities.Decks;

namespace BrUno.Core.Services
{
    public class MoveService
    {
        public bool IsValidMove(IPlayableDeck deck, Card card)
        {
            var top = deck.GetTopCard();
            return top.Color == CardColor.Wild ||
                   top.Color == card.Color ||
                   top.Type == card.Type;
        }

        public 
    }
}