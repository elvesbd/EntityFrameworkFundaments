using Blog.Models;

namespace Blog.Services
{
    public class UserService
    {
        public static User Create()
        {
            return new User
            {
                Name = "Elves Brito",
                Slug = "elvesbrito",
                Email = "elves@brito.com",
                Bio = "2x Microsoft MVP",
                Image = "https://elves.io",
                PasswordHash = "123098457",
                GitHub = "https://github.com/elvesbd"
            };
        }
    }
}