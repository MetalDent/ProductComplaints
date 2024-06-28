namespace Complaints.Models
{
    public class Users
    {
        public static List<User> UsersList = new List<User>()
        {
            new User() { Username = "john", Password = "doe" },
            new User() { Username = "jane", Password = "doess" },
        };
    }
}
