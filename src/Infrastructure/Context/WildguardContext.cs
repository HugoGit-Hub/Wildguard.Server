using Infrastructure.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class WildguardContext(DbContextOptions<WildguardContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
}