namespace RookEcomShop.Api.UnitTest.TestUtils;

public class ConcreteUserContext
{
    public Guid UserId { get; private set; }
    public string? UserEmail { get; private set; }
    public string UserRole { get; private set; } = null!;


    public void SetContext(Guid userId, string userEmail, string userRole)
    {
        UserId = userId;
        UserEmail = userEmail;
        UserRole = userRole;
    }

    public void SetContext(Guid userId, string userRole)
    {
        UserId = userId;
        UserRole = userRole;
    }

    public void SetContext(Guid userId)
    {
        UserId = userId;
    }
}