using Microsoft.EntityFrameworkCore;
using MarcenariaApi.Models;
namespace MarcenariaApi.Data
{
    public class MarcenariaDbContext: DbContext
    {
        
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Agenda> Agendas { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("DataSource=estacionamento.db;Cache=Shared");//
        //UseSqlite("DataSource=estacionamento.db;Cache=Shared");
    }

}

}