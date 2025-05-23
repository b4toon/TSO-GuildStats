using GuildStats.Domain.Abstractions;
using GuildStats.Domain.Entities.Events;

namespace GuildStats.Domain.Entities.User;

public class User : Entity
{
    private User(Guid id, UserName userName, Email email) : base(id)
    {
        UserName = userName;
        Email = email;
    }
    
    public UserName UserName { get; private set; }

    public Email Email { get; private set; }

    public static User Create(UserName userName, Email email)
    {
        var user = new User(Guid.NewGuid(), userName, email);
        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));
        return user;
    }
}