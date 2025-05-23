using GuildStats.Domain.Abstractions;

namespace GuildStats.Domain.Entities.Events;

public class UserCreatedDomainEvent(Guid UserId) : IDomainEvent
{
    
}