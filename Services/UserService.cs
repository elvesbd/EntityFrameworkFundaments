using Blog.Models;

namespace Blog.Services
{
    public class UserService
    {
        public static User Create()
        {
            return new User()
            {
                Name = "Isabel Cristina",
                Slug = "isabelcristina",
                Email = "isabel@cristina.com",
                Bio = "2x Microsoft MVP",
                Image = "https://elves.io",
                PasswordHash = "123098457",
            };
        }
    }
}