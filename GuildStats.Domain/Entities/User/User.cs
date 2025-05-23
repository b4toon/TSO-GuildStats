using GuildStats.Domain.Abstractions;

namespace GuildStats.Domain.Entities.User;

public class User : Entity
{
    private User(Guid id, UserName userName, Email email) : base(id)
    {
        
    }
    
}