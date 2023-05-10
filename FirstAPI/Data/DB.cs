using FirstAPI.Models;

namespace FirstAPI.Data
{
    public static class DB
    {
        public static List<User> Users = new List<User>()
        {
            new User(){Id = 1, Name = "FirstUser"},
            new User(){Id = 2, Name = "SecondUser"}
        };
    }
}
