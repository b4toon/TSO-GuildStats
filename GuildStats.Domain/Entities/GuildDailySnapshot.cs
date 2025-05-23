using GuildStats.Domain.Abstractions;
using GuildStats.Domain.Entities.Events;
using GuildStats.Domain.Entities.Player;

namespace GuildStats.Domain.Entities;

public sealed class GuildDailySnapshot : Entity
{
    private GuildDailySnapshot(Guid id, DateTime timestamp) : base(id)
    {
        Timestamp = timestamp;
    }
    public DateTime Timestamp { get; private set; }
    
    
    //When to populate this list?
    // 1. on creation in constructor
    // 2. after creation and after loading from processed file
    public List<PlayerDailyStatus> PlayersDailyStatusList { get; private set; }
    
    public static GuildDailySnapshot Create(DateTime timestamp)
    {
        var guildDailySnapshot = new GuildDailySnapshot(Guid.NewGuid(), timestamp);
        guildDailySnapshot.RaiseDomainEvent(new GuildDailySnapshotCreatedEvent(guildDailySnapshot.Id));
        return guildDailySnapshot;
    }
}