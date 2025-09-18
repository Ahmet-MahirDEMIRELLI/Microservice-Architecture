using FirstMicroservice.Todos.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMicroservice.Todos.WebApi.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Todo> Todos { get; set; }
}
