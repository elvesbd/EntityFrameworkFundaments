using Blog.Models;

namespace Blog.Services
{
    public class CategoryService
    {
        public static Category Create()
        {
            return new Category
            {
                Name = "Backend",
                Slug = "backend"
            };
        }
    }
}