using Microsoft.EntityFrameworkCore;

namespace Webapi.Models;

public class HelloDbContext(DbContextOptions<HelloDbContext> options) : DbContext(options)
{
    public required DbSet<Hello> Users { get; set; } 
}