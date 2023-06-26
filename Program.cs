using System.Security.Cryptography.X509Certificates;
using Blog.Data;
using Blog.Models;
using Blog.Services;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using var ctx = new BlogDataContext();
        var posts = GetPosts(ctx, 0, 25);

        Console.WriteLine("");
    }

    /*  public static List<Post> GetPosts(BlogDataContext ctx, int skip = 0, int take = 25)
     {
         var posts = ctx
             .Posts
             .AsNoTracking()
             .Skip(skip)
             .Take(take)
             .ToList();
         return posts;
     } */

    public static List<Post> GetPosts(BlogDataContext ctx, int skip = 0, int take = 25)
    {
        var posts = ctx
            .PostWithTagsCount
            .ToList();
        foreach (var item in posts)
        {
            Console.WriteLine(item.Name);
        }
        return posts;
    }
}