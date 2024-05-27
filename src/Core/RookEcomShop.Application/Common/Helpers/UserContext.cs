
namespace RookEcomShop.Application.Common.Helpers
{
    public sealed class UserContext
    {
        public int UserId { get; private set; }
        public string? UserEmail { get; private set; }
        public int UserRoleId { get; private set; }


        public void SetContext(int userId, string userEmail, int userRole)
        {
            UserId = userId;
            UserEmail = userEmail;
            UserRoleId = userRole;
        }

        public void SetContext(int userId,  int userRole)
        {
            UserId = userId;
            UserRoleId = userRole;
        }

        public void SetContext(int userId)
        {
            UserId = userId;
        }
    }
}