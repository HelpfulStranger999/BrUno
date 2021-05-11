using System;

namespace BrUno.Core.Entities
{
    public record PlayerID(Guid ID);

    public interface IPlayer
    {
        public PlayerID ID { get; }
        public IHand Hand { get; }
    }
}