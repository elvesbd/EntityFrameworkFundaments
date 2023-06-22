using System.Security.Cryptography.X509Certificates;
using Blog.Data;
using Blog.Models;
using Blog.Services;
using Microsoft.EntityFrameworkCore;

using var ctx = new BlogDataContext();

/* 
Create Post
var user = UserService.Create();
var category = CategoryService.Create();
var post = PostService.Create(user, category);
ctx.Posts?.Add(post);
ctx.SaveChanges(); */

/* 
Include
var posts = ctx
    .Posts?
    .AsNoTracking()
    .Include(x => x.Author)
    .Include(x => x.Category)
    .OrderBy(x => x.LastUpdateDate)
    .ToList();

foreach (var post in posts)
{
    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
} */

/* var user = UserService.Create();
ctx.Users.Add(user);
ctx.SaveChanges(); */

var user = ctx.Users.FirstOrDefault();
var category = CategoryService.Create();

var post = PostService.Create(user, category);
ctx.Posts.Add(post);
ctx.SaveChanges();



