using EletrodomesticosAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EletrodomesticosAppWeb.Data;

public class EletrodomesticoDbContext : DbContext
{
    public DbSet<Eletrodomestico> Eletrodomestico { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var stringConn = config.GetConnectionString("StringConn");

        optionsBuilder.UseSqlServer(stringConn);

    }
}
