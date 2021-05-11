using BrUno.Core.Entities.Cards;
using System.Collections.Generic;

namespace BrUno.Core.Entities.Decks
{
    public class DrawableDeck : BaseDeck, IDrawableDeck
    {
        public DrawableDeck(IDeckFactory factory, IEnumerable<Card> cards) : base(factory, cards)
        {
        }

        public void DealHands(List<IHand> hands, int handSize)
        {
            for (int i = 0; i < handSize; i++)
            {
                for (int hand = 0; hand < hands.Count; hand++)
                {
                    hands[hand].Draw(Draw());
                }
            }
        }

        public Card Draw()
        {
            return Cards.Pop();
        }

        public override void ShuffleCards()
        {
            Cards = Shuffle();
        }
    }
}