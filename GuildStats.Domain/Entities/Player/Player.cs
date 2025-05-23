using GuildStats.Domain.Abstractions;
using GuildStats.Domain.Entities.Events;

namespace GuildStats.Domain.Entities.Player;

public sealed class Player : Entity
{
    private Player(Guid id, string name, DateTime firstSeen) : base(id)
    {
        Name = name;
        FirstSeen = firstSeen;
    }
    public string Name { get; private set; }
    public DateTime FirstSeen { get; private set; }
    
    public static Player Create(string name, DateTime firstSeen)
    {
        var player = new Player(Guid.NewGuid(), name, firstSeen);
        player.RaiseDomainEvent( new PlayerCreatedEvent(player.Id));
        return player;
    }
}