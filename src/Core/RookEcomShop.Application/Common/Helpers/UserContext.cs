
namespace RookEcomShop.Application.Common.Helpers
{
    public sealed class UserContext
    {
        public Guid UserId { get; private set; }
        public string? UserEmail { get; private set; }
        public Guid UserRoleId { get; private set; }


        public void SetContext(Guid userId, string userEmail, Guid userRole)
        {
            UserId = userId;
            UserEmail = userEmail;
            UserRoleId = userRole;
        }

        public void SetContext(Guid userId, Guid userRole)
        {
            UserId = userId;
            UserRoleId = userRole;
        }

        public void SetContext(Guid userId)
        {
            UserId = userId;
        }
    }
}