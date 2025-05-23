namespace GuildStats.Domain.Entities.Player;

public sealed class PlayerDailyStatus
{
    public Player Player { get; private set; }
    public int Level { get; private set; }
    public bool WasActiveIn24Hours { get; private set; }
    public bool GuildQuestDone { get; private set; }
}