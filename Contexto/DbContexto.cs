using entity.Models;
using Microsoft.EntityFrameworkCore;

namespace entity.Contexto;

public class DbContexto : DbContext
{
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    // public DbContexto() { }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     var conexao = Environment.GetEnvironmentVariable("DATABASE_CDF");
    //     if(conexao == null) conexao = "Server=localhost;Database=persistencia_codigo_do_futuro;Uid=root;Pwd=root;";
    //     optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
    // }

    public DbSet<Cliente> Clientes { get; set; } = default!;
    public DbSet<Fornecedor> Fornecedores { get; set; } = default!;
} 