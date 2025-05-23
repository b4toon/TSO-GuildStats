using GuildStats.Domain.Abstractions;

namespace GuildStats.Domain.Entities.Events;

public sealed class PlayerCreatedEvent(Guid PlayerId) : IDomainEvent;
