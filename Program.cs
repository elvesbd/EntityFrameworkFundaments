using System.Security.Cryptography.X509Certificates;
using Blog.Data;
using Blog.Models;
using Blog.Services;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using var ctx = new BlogDataContext();

        var post = await ctx.Posts.ToListAsync();
        var users = await ctx.Users.ToListAsync();

        var posts = await GetPosts(ctx);

        Console.WriteLine("");
    }

    public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext ctx)
    {
        return await ctx.Posts.ToListAsync();
    }
}