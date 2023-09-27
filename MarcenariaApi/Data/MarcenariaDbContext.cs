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
       optionsBuilder.UseSqlite("Data Source=marcenaria.db");

       
       
       // optionsBuilder.UseSqlite("C:/Github/MarcenariaApiT/MarcenariaApi}/marcenaria.db");
            
            //"DataSource=marcenaria.db;Cache=Shared");



        //"Server=localhost;" + "Port=5432;Database=postgres;"+ "User Id=postgres;"+ "Password=postgres;"
        //Data Source=marcenaria.db
        //;Cache=Shared
        //UseSqlServer("DataSource=estacionamento.db;Cache=Shared");//
        //UseSqlite("DataSource=estacionamento.db;Cache=Shared");   
    }

}

}