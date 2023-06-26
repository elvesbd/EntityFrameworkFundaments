using System.Security.Cryptography.X509Certificates;
using Blog.Data;
using Blog.Models;
using Blog.Services;
using Microsoft.EntityFrameworkCore;

using var ctx = new BlogDataContext();

var user = UserService.Create();
ctx.Users?.Add(user);
ctx.SaveChanges();
