using Blog.Models;

namespace Blog.Services
{
    public class PostService
    {
        public static Post Create(User user, Category category)
        {
            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello World!</p>",
                Slug = "comecando-com-ef-core",
                Summary = "Nesse artigo vamos aprender EF Core",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            return post;
        }
    }
}