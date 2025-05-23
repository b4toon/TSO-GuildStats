using GuildStats.Domain.Abstractions;

namespace GuildStats.Domain.Entities.Events;

public class GuildDailySnapshotCreatedEvent(Guid SnapshotId) : IDomainEvent;