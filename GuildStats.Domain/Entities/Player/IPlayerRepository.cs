namespace GuildStats.Domain.Entities.Player;

public interface IPlayerRepository
{
    Task<Player?> GetPlayerByIdAsync(Guid playerId, CancellationToken cancellationToken = default);
    Task<Player?> GetPlayerByNameAsync(string playerName, CancellationToken cancellationToken = default);
    void Add(Player player);
}