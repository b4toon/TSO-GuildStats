using GuildStats.Domain.Entities.Player;

namespace GuildStats.Domain.Entities;

public class GuildDailySnapshot
{
    public DateTime Timestamp { get; private set; }
    
    public List<PlayerDailyStatus> PlayersDailyStatusList { get; private set; }
}