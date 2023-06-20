using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using var ctx = new BlogDataContext();
/* var tag = new Tag
{
    Name = "ASP.NET",
    Slug = "aspnet"
};
ctx.Tags.Add(tag); // quando essa operação acontece fica na memoria
ctx.SaveChanges(); // agora com essa função a informação será persistida no banco */

/* var tag = ctx.Tags?.FirstOrDefault(x => x.Id == 8);
if (tag != null)
{
    tag.Name = ".NET";
    tag.Slug = "dotnet";
    ctx.Update(tag);
    ctx.SaveChanges();
} */

/* var tag = ctx.Tags?.FirstOrDefault(x => x.Id == 8);
if (tag != null)
{
    ctx.Remove(tag);
    ctx.SaveChanges();
} */

/* //var tags = ctx.Tags; // essa operação não foi executada no banco de dados (aqui temos apenas a referência)
var tags = ctx
    .Tags?
    // desabilita o tracking (rastreamento) para minha consulta significa que as entidades retornadas pela
    // consulta não serão rastreadas pelo contexto. Isso pode ser útil quando você está apenas lendo dados
    // e não pretende fazer atualizações ou gravações posteriores.
    .AsNoTracking()
    .ToList(); // o uso do ToList força a execução da query no banco de dados sempre deve ser colocado por ultimo
if (tags != null)
{
    foreach (var tag in tags) // aqui de fato ocorreu a consulta no bando de dados
    {
        Console.WriteLine(tag.Name);
    }
} */

/* var tag = ctx
    .Tags?
    .AsNoTracking()
    // First procura o item e se não encontra lança erro
    // FirstOrDefault procura o item e se não encontra trás como nulo
    .FirstOrDefault(x => x.Id == 9);
Console.WriteLine(tag?.Name); */